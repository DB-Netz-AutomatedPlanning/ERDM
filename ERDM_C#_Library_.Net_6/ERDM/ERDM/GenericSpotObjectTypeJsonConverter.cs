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
    public class GenericSpotObjectTypeJsonConverter : System.Text.Json.Serialization.JsonConverter<GenericSpotObjectType?>
    {
        public override GenericSpotObjectType? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Null)
                return null;
            else if (reader.TokenType != JsonTokenType.String)
                throw new JsonSerializationException(string.Format("Unexpected token {0}", reader.TokenType));
            var s = reader.GetString();
            switch (s)
            {
                case "Catenary Post":
                    return GenericSpotObjectType.CatenaryPost;
                case "Signal Post":
                    return GenericSpotObjectType.SignPost;
                case "Radio Post":
                    return GenericSpotObjectType.SignalPost;
                case "Mileage Stone":
                    return GenericSpotObjectType.RadioPost;
                case "Camera Post":
                    return GenericSpotObjectType.MileageStone;
                case "Communication":
                    return GenericSpotObjectType.HectometreSign;
                case "Post":
                    return GenericSpotObjectType.CameraPost;
                case "End of Track":
                    return GenericSpotObjectType.Communication;
                case "Other Post":
                    return GenericSpotObjectType.Post;
                default:
                    return null;
            }
        }
        public override void Write(Utf8JsonWriter writer, GenericSpotObjectType? value, JsonSerializerOptions options)
        {

            switch (value)
            {
                case GenericSpotObjectType.CatenaryPost:
                    writer.WriteStringValue("Catenary Post");
                    break;
                case GenericSpotObjectType.SignPost:
                    writer.WriteStringValue("Signal Post");
                    break;
                case GenericSpotObjectType.RadioPost:
                    writer.WriteStringValue("Radio Post");
                    break;
                case GenericSpotObjectType.MileageStone:
                    writer.WriteStringValue("Mileage Stone");
                    break;
                case GenericSpotObjectType.CameraPost:
                    writer.WriteStringValue("Camera Post");
                    break;
                case GenericSpotObjectType.Communication:
                    writer.WriteStringValue("Communication");
                    break;
                case GenericSpotObjectType.Post:
                    writer.WriteStringValue("Post");
                    break;
                case GenericSpotObjectType.EndOfTrack:
                    writer.WriteStringValue("End of Track");
                    break;
                case GenericSpotObjectType.OtherPost:
                    writer.WriteStringValue("Other Post");
                    break;
                default:
                    writer.WriteNullValue();
                    break;
            }
        }
    }
}
