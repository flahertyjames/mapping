// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Parameters.cs" company="James Flaherty">
//   2014
// </copyright>
// <summary>
//   Abstract class for parameter-based requests.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Flaherty.Services
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Reflection;
    using System.Web;

    /// <summary>
    /// Abstract class for parameter-based requests.
    /// </summary>
    public abstract class Parameters : IParameters
    {
        /// <summary>
        /// Generates a parameter string.
        /// </summary>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public virtual string ToParameterString()
        {
            var type = this.GetType();
            var pairs = new List<string>();
            foreach (var property in type.GetProperties(BindingFlags.Instance | BindingFlags.Public))
            {
                var ignoreAtts = property.GetCustomAttributes(typeof(ParameterIgnoreAttribute), false);
                if (ignoreAtts.Length == 0)
                {
                    var parameterAtts = property.GetCustomAttributes(typeof(ParameterAttribute), false);
                    var key = parameterAtts.Length > 0 ? ((ParameterAttribute)parameterAtts[0]).Name : property.Name;
                    var value = property.GetValue(this, null);

                    if (value != null)
                    {
                        var converterAtts = property.GetCustomAttributes(typeof(ParameterConverterAttribute), false);
                        if (converterAtts.Length > 0)
                        {
                            var converterType = ((ParameterConverterAttribute)converterAtts[0]).ConverterType;
                            var converter = (TypeConverter)Activator.CreateInstance(converterType);
                            value = converter.ConvertFrom(value) ?? string.Empty;
                        }

                        if (parameterAtts.Length > 0 && ((ParameterAttribute)parameterAtts[0]).UrlEncode)
                        {
                            value = HttpUtility.UrlEncode(value.ToString());
                        }

                        pairs.Add(string.Format("{0}={1}", key, value));
                    }
                }
            }

            return string.Join("&", pairs.ToArray());
        }
    }
}
