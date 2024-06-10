using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Balikuj.Client.Converters
{
    public class UpperCaseListStringJsonConverter : JsonConverterFactory
    {
        public override bool CanConvert(Type typeToConvert)
        {
            return typeToConvert == typeof(List<string>);
        }

        public override JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options)
        {
            JsonConverter converter = (JsonConverter)Activator.CreateInstance(
                typeof(UpperCaseListStringJsonConverterInner),
                BindingFlags.Instance | BindingFlags.Public,
                binder: null,
                args: new object[] { options },
                culture: null);

            return converter;
        }
    }

    public class UpperCaseListStringJsonConverterInner : JsonConverter<List<string>>
    {
        private readonly JsonConverter<List<string>> _valueConverter;


        public UpperCaseListStringJsonConverterInner(JsonSerializerOptions options)
        {
            // For performance, use the existing converter.
            _valueConverter = (JsonConverter<List<string>>)options.GetConverter(typeof(List<string>));
        }

        public override bool HandleNull => false;


        public override bool CanConvert(Type typeToConvert)
        {
            return typeToConvert == typeof(List<string>);
        }


        public override List<string> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType != JsonTokenType.StartArray)
            {
                throw new JsonException();
            }

            var list = new List<string>();

            while (reader.Read())
            {
                if (reader.TokenType == JsonTokenType.EndArray)
                {
                    return list;
                }

                // Get the key.
                if (reader.TokenType != JsonTokenType.String)
                {
                    throw new JsonException();
                }

                string propertyValue = reader.GetString()?.ToUpperInvariant();
                if (!string.IsNullOrEmpty(propertyValue) && !list.Contains(propertyValue))
                {
                    list.Add(propertyValue);
                }
            }

            throw new JsonException();
        }

        public override void Write(Utf8JsonWriter writer, List<string> value, JsonSerializerOptions options)
        {
            _valueConverter.Write(writer, value, options);
        }

    }
}
