// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CoordinateConverter.cs" company="James Flaherty">
//   2014
// </copyright>
// <summary>
//   Converts a coordinate-based object to JSON.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Flaherty.Mapping.BingMaps.Javascript.Json
{
    using System;

    using Newtonsoft.Json;

    /// <summary>
    /// Converts a coordinate-based object to JSON.
    /// </summary>
    /// <typeparam name="T">
    /// The type of the coordinate-based object.
    /// </typeparam>
    public abstract class CoordinateConverter<T> : JsonConverter
        where T : BingMapsObject
    {
        /// <summary>
        /// Writes a coordinate-based object to JSON.
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
            var coord = (T)value;
            writer.WriteRawValue(coord.ToJavascript());
        }

        /// <summary>
        /// Reads a coordinate-based object from JSON.
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