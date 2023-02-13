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
    public class MarkerTypeJsonConverter : System.Text.Json.Serialization.JsonConverter<MarkerType?>
    {
        public override MarkerType? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Null)
                return null;
            else if (reader.TokenType != JsonTokenType.String)
                throw new JsonSerializationException(string.Format("Unexpected token {0}", reader.TokenType));
            var s = reader.GetString();
            switch (s)
            {
                case "ETCS Marker":
                    return MarkerType.ETCSMarker;
                case "stopping Location":
                    return MarkerType.StoppingLocation;
                case "balise":
                    return MarkerType.Balise;
                case "Other":
                    return MarkerType.Other;
                default:
                    return null;
            }
        }
        public override void Write(Utf8JsonWriter writer, MarkerType? value, JsonSerializerOptions options)
        {

            switch (value)
            {
                case MarkerType.ETCSMarker:
                    writer.WriteStringValue("ETCS Marker");
                    break;
                case MarkerType.StoppingLocation:
                    writer.WriteStringValue("stopping Location");
                    break;
                case MarkerType.Balise:
                    writer.WriteStringValue("balise");
                    break;
                case MarkerType.Other:
                    writer.WriteStringValue("Other");
                    break;
                default:
                    writer.WriteNullValue();
                    break;
            }
        }
    }
}
