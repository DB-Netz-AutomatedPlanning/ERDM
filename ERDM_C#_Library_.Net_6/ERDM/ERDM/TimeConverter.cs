using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ERDM
{
    public class TimeConverter : System.Text.Json.Serialization.JsonConverter<TimeSpan>
    {
        public override TimeSpan Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Null)
                return new TimeSpan(0, 0, 0);
            else if (reader.TokenType != JsonTokenType.String)
                return new TimeSpan(0, 0, 0);
            var s = reader.GetString();
            return TimeSpan.Parse(s);
        }

        public override void Write(Utf8JsonWriter writer, TimeSpan value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToString(@"\-hh\:mm"));
        }
    }
}
