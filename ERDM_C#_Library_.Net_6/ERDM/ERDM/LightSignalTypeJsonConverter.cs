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
    public class LightSignalTypeJsonConverter : System.Text.Json.Serialization.JsonConverter<LightSignalType?>
    {
        public override LightSignalType? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Null)
                return null;
            else if (reader.TokenType != JsonTokenType.String)
                throw new JsonSerializationException(string.Format("Unexpected token {0}", reader.TokenType));
            var s = reader.GetString();
            switch (s)
            {
                case "Main signal":
                    return LightSignalType.MainSignal;
                case "Shunting signal":
                    return LightSignalType.ShuntingSignal;
                default:
                    return null;
            }
        }
        public override void Write(Utf8JsonWriter writer, LightSignalType? value, JsonSerializerOptions options)
        {

            switch (value)
            {
                case LightSignalType.MainSignal:
                    writer.WriteStringValue("Main signal");
                    break;
                case LightSignalType.ShuntingSignal:
                    writer.WriteStringValue("Shunting signal");
                    break;
                default:
                    writer.WriteNullValue();
                    break;
            }
        }
    }
}
