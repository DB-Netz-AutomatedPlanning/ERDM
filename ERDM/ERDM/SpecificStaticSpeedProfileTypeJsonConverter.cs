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
    public class SpecificStaticSpeedProfileTypeJsonConverter : System.Text.Json.Serialization.JsonConverter<SpecificStaticSpeedProfileType?>
    {
        public override SpecificStaticSpeedProfileType? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Null)
                return null;
            else if (reader.TokenType != JsonTokenType.String)
                throw new JsonSerializationException(string.Format("Unexpected token {0}", reader.TokenType));
            var s = reader.GetString();
            switch (s)
            {
                case "Cant Deficiency":
                    return SpecificStaticSpeedProfileType.CantDeficiency;
                case "Other Specific SSP":
                    return SpecificStaticSpeedProfileType.OtherSpecificSSP;
                default:
                    return null;
            }
        }
        public override void Write(Utf8JsonWriter writer, SpecificStaticSpeedProfileType? value, JsonSerializerOptions options)
        {

            switch (value)
            {
                case SpecificStaticSpeedProfileType.CantDeficiency:
                    writer.WriteStringValue("Cant Deficiency");
                    break;
                case SpecificStaticSpeedProfileType.OtherSpecificSSP:
                    writer.WriteStringValue("Other Specific SSP");
                    break;
                default:
                    writer.WriteNullValue();
                    break;
            }
        }
    }
}
