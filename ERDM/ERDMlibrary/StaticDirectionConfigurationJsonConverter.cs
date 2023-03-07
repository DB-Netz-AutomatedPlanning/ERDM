using Newtonsoft.Json;
using ERDM.Tier_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ERDM
{
    public class StaticDirectionConfigurationJsonConverter : System.Text.Json.Serialization.JsonConverter<StaticDirectionConfiguration?>
    {
        public override StaticDirectionConfiguration? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Null)
                return null;
            else if (reader.TokenType != JsonTokenType.String)
                throw new JsonSerializationException(string.Format("Unexpected token {0}", reader.TokenType));
            var s = reader.GetString();
            switch (s)
            {
                case "None":
                    return StaticDirectionConfiguration.None;
                case "Start to End":
                    return StaticDirectionConfiguration.StartToEnd;
                case "End to Start":
                    return StaticDirectionConfiguration.EndToStart;
                case "Both":
                    return StaticDirectionConfiguration.Both;
                default:
                    return null;
            }
        }
        public override void Write(Utf8JsonWriter writer, StaticDirectionConfiguration? value, JsonSerializerOptions options)
        {

            switch (value)
            {
                case StaticDirectionConfiguration.None:
                    writer.WriteStringValue("None");
                    break;
                case StaticDirectionConfiguration.StartToEnd:
                    writer.WriteStringValue("Start to End");
                    break;
                case StaticDirectionConfiguration.EndToStart:
                    writer.WriteStringValue("End to Start");
                    break;
                case StaticDirectionConfiguration.Both:
                    writer.WriteStringValue("Both");
                    break;
                default:
                    writer.WriteNullValue();
                    break;
            }
        }
    }
}
