using ERDM.Tier_0;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ERDM
{
    public class JsonTypeConverter : JsonConverter<object>
    {
        public override void Write(Utf8JsonWriter writer, object value, JsonSerializerOptions options)
        {
            Type type = value.GetType();
            JsonTypeAttribute typeAttr = type.GetCustomAttribute<JsonTypeAttribute>();
            if (typeAttr != null)
            {
                writer.WriteStartObject();
                writer.WriteString("$type", typeAttr.TypeName);
                JsonSerializer.Serialize(writer, value, value.GetType(), options);
                writer.WriteEndObject();
            }
            else
            {
                JsonSerializer.Serialize(writer, value, value.GetType(), options);
            }
        }

        public override object Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }
    }
}
