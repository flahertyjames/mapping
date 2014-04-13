// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ElementConverter.cs" company="James Flaherty">
//   2014
// </copyright>
// <summary>
//   Converts a target element id value to JSON.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Flaherty.Mapping.MapQuest.Javascript.Json
{
    using System;

    using Newtonsoft.Json;

    /// <summary>
    /// Converts a target element id value to JSON.
    /// </summary>
    public class ElementConverter : JsonConverter
    {
        /// <summary>
        /// Writes a target element id value to JSON.
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
            var stringValue = (string)value;
            writer.WriteRawValue(string.Format("document.getElementById('{0}')", stringValue));
        }

        /// <summary>
        /// Reads an target element id value from JSON.
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
            return objectType == typeof(string);
        }
    }
}