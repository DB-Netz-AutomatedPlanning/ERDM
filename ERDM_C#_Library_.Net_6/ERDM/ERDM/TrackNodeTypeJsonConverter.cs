using Newtonsoft.Json;
using ERDM.Tier_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ERDM
{
    public class TrackNodeTypeJsonConverter : System.Text.Json.Serialization.JsonConverter<TrackNodeType?>
    {
        public override TrackNodeType? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Null)
                return null;
            else if (reader.TokenType != JsonTokenType.String)
                throw new JsonSerializationException(string.Format("Unexpected token {0}", reader.TokenType));
            var s = reader.GetString();
            switch (s)
            {
                case "Point":
                    return TrackNodeType.Point;
                case "System Border":
                    return TrackNodeType.SystemBorder;
                case "End of Track":
                    return TrackNodeType.EndOfTrack;
                default:
                    return null;
            }
        }
        public override void Write(Utf8JsonWriter writer, TrackNodeType? value, JsonSerializerOptions options)
        {

            switch (value)
            {
                case TrackNodeType.Point:
                    writer.WriteStringValue("Point");
                    break;
                case TrackNodeType.SystemBorder:
                    writer.WriteStringValue("System Border");
                    break;
                case TrackNodeType.EndOfTrack:
                    writer.WriteStringValue("End of Track");
                    break;
                default:
                    writer.WriteNullValue();
                    break;
            }
        }
    }
}
