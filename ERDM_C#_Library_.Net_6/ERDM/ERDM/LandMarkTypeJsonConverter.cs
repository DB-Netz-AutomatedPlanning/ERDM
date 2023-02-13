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
    public class LandmarkTypeJsonConverter : System.Text.Json.Serialization.JsonConverter<LandmarkType?>
    {
        public override LandmarkType? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Null)
                return null;
            else if (reader.TokenType != JsonTokenType.String)
                throw new JsonSerializationException(string.Format("Unexpected token {0}", reader.TokenType));
            var s = reader.GetString();
            switch (s)
            {
                case "Catenary Post":
                    return LandmarkType.CatenaryPost;
                case "Building":
                    return LandmarkType.Building;
                case "Sign Post":
                    return LandmarkType.SignPost;
                case "Signal Post":
                    return LandmarkType.SignalPost;
                case "Radio Post":
                    return LandmarkType.RadioPost;
                case "Mileage Stone":
                    return LandmarkType.MileageStone;
                case "Hectometre Sign":
                    return LandmarkType.HectometreSign;
                case "Other Post":
                    return LandmarkType.OtherPost;
                default:
                    return null;
            }
        }
        public override void Write(Utf8JsonWriter writer, LandmarkType? value, JsonSerializerOptions options)
        {

            switch (value)
            {
                case LandmarkType.CatenaryPost:
                    writer.WriteStringValue("Catenary Post");
                    break;
                case LandmarkType.Building:
                    writer.WriteStringValue("Building");
                    break;
                case LandmarkType.SignPost:
                    writer.WriteStringValue("Sign Post");
                    break;
                case LandmarkType.SignalPost:
                    writer.WriteStringValue("Signal Post");
                    break;
                case LandmarkType.RadioPost:
                    writer.WriteStringValue("Radio Post");
                    break;
                case LandmarkType.MileageStone:
                    writer.WriteStringValue("Mileage Stone");
                    break;
                case LandmarkType.HectometreSign:
                    writer.WriteStringValue("Hectometre Sign");
                    break;
                case LandmarkType.OtherPost:
                    writer.WriteStringValue("Other Post");
                    break;
                default:
                    writer.WriteNullValue();
                    break;
            }
        }
    }
}
