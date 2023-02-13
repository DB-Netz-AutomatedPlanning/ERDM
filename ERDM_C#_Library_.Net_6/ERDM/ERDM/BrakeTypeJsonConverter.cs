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
    public class BrakeTypeJsonConverter : System.Text.Json.Serialization.JsonConverter<BrakeType?>
    {
        public override BrakeType? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Null)
                return null;
            else if (reader.TokenType != JsonTokenType.String)
                throw new JsonSerializationException(string.Format("Unexpected token {0}", reader.TokenType));
            var s = reader.GetString();
            switch (s)
            {
                case "service brake":
                    return BrakeType.ServiceBrake;
                case "emergency brake":
                    return BrakeType.EmergencyBrake;
                default:
                    return null;
            }
        }
        public override void Write(Utf8JsonWriter writer, BrakeType? value, JsonSerializerOptions options)
        {

            switch (value)
            {
                case BrakeType.ServiceBrake:
                    writer.WriteStringValue("service brake");
                    break;
                case BrakeType.EmergencyBrake:
                    writer.WriteStringValue("emergency brake");
                    break;
                default:
                    writer.WriteNullValue();
                    break;
            }
        }
    }
}
