// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ParameterIgnoreAttribute.cs" company="James Flaherty">
//   2014
// </copyright>
// <summary>
//   Attribute that ignores a property for parameter serialization.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Flaherty.Services
{
    using System;

    /// <summary>
    /// Attribute that ignores a property for parameter serialization.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class ParameterIgnoreAttribute : Attribute
    {
    }
}