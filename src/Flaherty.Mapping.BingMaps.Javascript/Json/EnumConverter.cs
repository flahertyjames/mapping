// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EnumConverter.cs" company="James Flaherty">
//   2014
// </copyright>
// <summary>
//   Converts an enumeration value to JSON.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Flaherty.Mapping.BingMaps.Javascript.Json
{
    using System;

    using Newtonsoft.Json;

    /// <summary>
    /// Converts an enumeration value to JSON.
    /// </summary>
    /// <typeparam name="T">
    /// The enumeration type.
    /// </typeparam>
    public abstract class EnumConverter<T> : JsonConverter
    {
        /// <summary>
        /// Gets the Microsoft Maps type name.
        /// </summary>
        protected virtual string TypeName
        {
            get
            {
                return typeof(T).Name;
            }
        }

        /// <summary>
        /// Writes a enumeration value to JSON.
        /// </summary>
        /// <param name="writer">
        /// The writer.
        /// </param>
        /// <param name="value">
        /// The value.
        /// </param>
        /// <param name="serializer">
        /// The serializer.
        /// </param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var enumValue = (T)value;
            writer.WriteRawValue(string.Format("Microsoft.Maps.{0}.{1}", this.TypeName, enumValue.ToString().ToLower()));
        }

        /// <summary>
        /// Reads an enumeration value from JSON.
        /// </summary>
        /// <param name="reader">
        /// The reader.
        /// </param>
        /// <param name="objectType">
        /// The object type.
        /// </param>
        /// <param name="existingValue">
        /// The existing value.
        /// </param>
        /// <param name="serializer">
        /// The serializer.
        /// </param>
        /// <returns>
        /// The <see cref="object"/>.
        /// </returns>
        /// <exception cref="NotImplementedException">
        /// This method is not implemented
        /// </exception>
        public override object ReadJson(
            JsonReader reader,
            Type objectType,
            object existingValue,
            JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Determines whether the supplied object can be converted.
        /// </summary>
        /// <param name="objectType">
        /// The object type.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(T);
        }
    }
}