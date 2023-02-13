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
    public class TunnelTypeJsonConverter : System.Text.Json.Serialization.JsonConverter<TunnelType>
    {
        public override TunnelType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Null)
                return TunnelType.SingleTrackTunnel;
            else if (reader.TokenType != JsonTokenType.String)
                throw new JsonSerializationException(string.Format("Unexpected token {0}", reader.TokenType));
            var s = reader.GetString();
            switch (s)
            {
                case "Single Track Tunnel":
                    return TunnelType.SingleTrackTunnel;
                case "Double Track Tunnel":
                    return TunnelType.DoubleTrackTunnel;
                case "Wide":
                    return TunnelType.Wide_crossSectionTunnel;
                default:
                    return TunnelType.SingleTrackTunnel;
            }
        }
        public override void Write(Utf8JsonWriter writer, TunnelType value, JsonSerializerOptions options)
        {

            switch (value)
            {
                case TunnelType.SingleTrackTunnel:
                    writer.WriteStringValue("Single Track Tunnel");
                    break;
                case TunnelType.DoubleTrackTunnel:
                    writer.WriteStringValue("Double Track Tunnel");
                    break;
                case TunnelType.Wide_crossSectionTunnel:
                    writer.WriteStringValue("Wide");
                    break;
                default:
                    writer.WriteNullValue();
                    break;
            }
        }
    }
}
