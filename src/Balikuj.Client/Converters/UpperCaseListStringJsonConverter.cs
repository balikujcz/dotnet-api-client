/*
* Copyright (c) 2024 Balíkuj.cz
* http://balikuj.cz
*
* Permission is hereby granted, free of charge, to any person obtaining a copy
* of this software and associated documentation files (the "Software"), to deal
* in the Software without restriction, including without limitation the rights
* to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
* copies of the Software, and to permit persons to whom the Software is
* furnished to do so, subject to the following conditions:
*
* The above copyright notice and this permission notice shall be included in
* all copies or substantial portions of the Software.
*
* THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
* IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
* FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
* AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
* LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
* OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
* THE SOFTWARE.
*/

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
