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
    public class CantDeficiencyJsonConverter : System.Text.Json.Serialization.JsonConverter<CantDeficiency?>
    {
        public override CantDeficiency? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Null)
                return null;
            else if (reader.TokenType != JsonTokenType.String)
                throw new JsonSerializationException(string.Format("Unexpected token {0}", reader.TokenType));
            var s = reader.GetString();
            switch (s)
            {
                case "80mm":
                    return CantDeficiency._80;
                case "100mm":
                    return CantDeficiency._100;
                case "130mm":
                    return CantDeficiency._130;
                case "150mm":
                    return CantDeficiency._150;
                case "165mm":
                    return CantDeficiency._165;
                case "180mm":
                    return CantDeficiency._180;
                case "210mm":
                    return CantDeficiency._210;
                case "225mm":
                    return CantDeficiency._225;
                case "245mm":
                    return CantDeficiency._245;
                case "275mm":
                    return CantDeficiency._275;
                case "300mm":
                    return CantDeficiency._300;
                default:
                    return null;
            }
        }
        public override void Write(Utf8JsonWriter writer, CantDeficiency? value, JsonSerializerOptions options)
        {

            switch (value)
            {
                case CantDeficiency._80:
                    writer.WriteStringValue("80mm");
                    break;
                case CantDeficiency._100:
                    writer.WriteStringValue("100mm");
                    break;
                case CantDeficiency._130:
                    writer.WriteStringValue("130mm");
                    break;
                case CantDeficiency._150:
                    writer.WriteStringValue("150mm");
                    break;
                case CantDeficiency._165:
                    writer.WriteStringValue("165mm");
                    break;
                case CantDeficiency._180:
                    writer.WriteStringValue("180mm");
                    break;
                case CantDeficiency._210:
                    writer.WriteStringValue("210mm");
                    break;
                case CantDeficiency._225:
                    writer.WriteStringValue("225mm");
                    break;
                case CantDeficiency._245:
                    writer.WriteStringValue("245mm");
                    break;
                case CantDeficiency._275:
                    writer.WriteStringValue("275mm");
                    break;
                case CantDeficiency._300:
                    writer.WriteStringValue("300mm");
                    break;
                default:
                    writer.WriteNullValue();
                    break;
            }
        }
    }
}
