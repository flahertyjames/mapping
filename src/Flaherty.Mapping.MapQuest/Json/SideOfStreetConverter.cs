// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SideOfStreetConverter.cs" company="James Flaherty">
//   2014
// </copyright>
// <summary>
//   Converts a side of street to JSON.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Flaherty.Mapping.MapQuest.Json
{
    using System;

    using Newtonsoft.Json;

    /// <summary>
    /// Converts a side of street to JSON.
    /// </summary>
    public class SideOfStreetConverter : JsonConverter
    {
        /// <summary>
        /// Writes a side of street to JSON.
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
            var sideOfStreet = (SideOfStreet)value;
            writer.WriteRawValue(sideOfStreet.ToString().Substring(0, 1).ToUpper());
        }

        /// <summary>
        /// Reads a side of street from JSON.
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
            if (reader.TokenType != JsonToken.Null)
            {
                var value = serializer.Deserialize<string>(reader);
                switch (value)
                {
                    case "L":
                        return SideOfStreet.Left;
                    case "R":
                        return SideOfStreet.Right;
                }
            }

            return SideOfStreet.None;
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
            return objectType == typeof(SideOfStreet);
        }
    }
}