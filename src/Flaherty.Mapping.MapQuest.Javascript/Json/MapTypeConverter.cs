// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MapTypeConverter.cs" company="James Flaherty">
//   2014
// </copyright>
// <summary>
//   Converts a map type to JSON.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Flaherty.Mapping.MapQuest.Javascript.Json
{
    using System;

    using Newtonsoft.Json;

    /// <summary>
    /// Converts a map type value to JSON.
    /// </summary>
    public class MapTypeConverter : JsonConverter
    {
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
            var enumValue = (MapType)value;
            var stringValue = enumValue.ToString();
            switch (enumValue)
            {
                case MapType.Hybrid:
                    stringValue = "hyb";
                    break;
                case MapType.OpenStreetMap:
                    stringValue = "osm";
                    break;
                case MapType.Satellite:
                    stringValue = "sat";
                    break;
            }

            writer.WriteValue(stringValue);
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
            return objectType == typeof(MapType);
        }
    }
}