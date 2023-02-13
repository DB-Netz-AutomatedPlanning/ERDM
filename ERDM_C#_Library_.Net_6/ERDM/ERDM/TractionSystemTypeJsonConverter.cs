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
    public class TractionSystemTypeJsonConverter : System.Text.Json.Serialization.JsonConverter<TractionSystemType?>
    {
        public override TractionSystemType? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Null)
                return null;
            else if (reader.TokenType != JsonTokenType.String)
                throw new JsonSerializationException(string.Format("Unexpected token {0}", reader.TokenType));
            var s = reader.GetString();
            switch (s)
            {
                case "Line not fitted with any traction system":
                    return TractionSystemType.LineNotFittedWithAnyTractionSystem;
                case "DC 600V":
                    return TractionSystemType.DC600V;
                case "DC 650V":
                    return TractionSystemType.DC650V;
                case "DC 750V":
                    return TractionSystemType.DC750V;
                case "DC 850V":
                    return TractionSystemType.DC850V;
                case "DC 1.5kV":
                    return TractionSystemType.DC1_5kV;
                case "DC 3kV":
                    return TractionSystemType.DC3kV;
                case "AC 15kV 16.7Hz":
                    return TractionSystemType.AC15kV16_7Hz;
                case "AC 25kV 50Hz":
                    return TractionSystemType.AC25kV_50Hz;
                case "other":
                    return TractionSystemType.other;
                default:
                    return null;
            }
        }
        public override void Write(Utf8JsonWriter writer, TractionSystemType? value, JsonSerializerOptions options)
        {

            switch (value)
            {
                case TractionSystemType.LineNotFittedWithAnyTractionSystem:
                    writer.WriteStringValue("Line not fitted with any traction system");
                    break;
                case TractionSystemType.DC600V:
                    writer.WriteStringValue("DC 600V");
                    break;
                case TractionSystemType.DC650V:
                    writer.WriteStringValue("DC 650V");
                    break;
                case TractionSystemType.DC750V:
                    writer.WriteStringValue("DC 750V");
                    break;
                case TractionSystemType.DC850V:
                    writer.WriteStringValue("DC 850V");
                    break;
                case TractionSystemType.DC1_5kV:
                    writer.WriteStringValue("DC 1.5kV");
                    break;
                case TractionSystemType.DC3kV:
                    writer.WriteStringValue("DC 3kV");
                    break;
                case TractionSystemType.AC15kV16_7Hz:
                    writer.WriteStringValue("AC 15kV 16.7Hz");
                    break;
                case TractionSystemType.AC25kV_50Hz:
                    writer.WriteStringValue("AC 25kV 50Hz");
                    break;
                case TractionSystemType.other:
                    writer.WriteStringValue("other");
                    break;
                default:
                    writer.WriteNullValue();
                    break;
            }
        }
    }
}
