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
    public class SlipCrossingTypeJsonConverter : System.Text.Json.Serialization.JsonConverter<SlipCrossingType?>
    {
        public override SlipCrossingType? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Null)
                return null;
            else if (reader.TokenType != JsonTokenType.String)
                throw new JsonSerializationException(string.Format("Unexpected token {0}", reader.TokenType));
            var s = reader.GetString();
            switch (s)
            {
                case "Single Slip":
                    return SlipCrossingType.SingleSlip;
                case "Double Slip":
                    return SlipCrossingType.DoubleSlip;
                default:
                    return null;
            }
        }
        public override void Write(Utf8JsonWriter writer, SlipCrossingType? value, JsonSerializerOptions options)
        {

            switch (value)
            {
                case SlipCrossingType.SingleSlip:
                    writer.WriteStringValue("Single Slip");
                    break;
                case SlipCrossingType.DoubleSlip:
                    writer.WriteStringValue("Double Slip");
                    break;
                default:
                    writer.WriteNullValue();
                    break;
            }
        }
    }
}
