// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ParameterAttribute.cs" company="James Flaherty">
//   2014
// </copyright>
// <summary>
//   Attribute that defines name for parameter serialization.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Flaherty.Services
{
    using System;

    /// <summary>
    /// Attribute that defines name for parameter serialization.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class ParameterAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ParameterAttribute"/> class.
        /// </summary>
        /// <param name="name">
        /// The parameter name.
        /// </param>
        public ParameterAttribute(string name)
        {
            this.Name = name;
            this.UrlEncode = true;
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to url encode.
        /// </summary>
        public bool UrlEncode { get; set; }
    }
}
