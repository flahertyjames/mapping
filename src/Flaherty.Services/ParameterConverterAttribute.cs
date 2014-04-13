// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ParameterConverterAttribute.cs" company="James Flaherty">
//   2014
// </copyright>
// <summary>
//   Attribute that defines value converter for parameter serialization.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Flaherty.Services
{
    using System;

    /// <summary>
    /// Attribute that defines value converter for parameter serialization.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class ParameterConverterAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ParameterConverterAttribute"/> class.
        /// </summary>
        /// <param name="type">
        /// The converter type.
        /// </param>
        public ParameterConverterAttribute(Type type)
        {
            this.ConverterType = type;
        }

        /// <summary>
        /// Gets or sets the converter type.
        /// </summary>
        /// <value>
        /// The converter type.
        /// </value>
        public Type ConverterType { get; set; }
    }
}