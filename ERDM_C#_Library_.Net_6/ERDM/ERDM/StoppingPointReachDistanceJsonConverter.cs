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
    public class StoppingPointReachDistanceJsonConverter : System.Text.Json.Serialization.JsonConverter<StoppingPointReachDistance?>
    {
        public override StoppingPointReachDistance? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Null)
                return null;
            else if (reader.TokenType != JsonTokenType.String)
                throw new JsonSerializationException(string.Format("Unexpected token {0}", reader.TokenType));
            var s = reader.GetString();
            switch (s)
            {
                case "10cm":
                    return StoppingPointReachDistance._10cm;
                case "20cm":
                    return StoppingPointReachDistance._20cm;
                case "30cm":
                    return StoppingPointReachDistance._30cm;
                case "40cm":
                    return StoppingPointReachDistance._40cm;
                case "50cm":
                    return StoppingPointReachDistance._50cm;
                case "1m":
                    return StoppingPointReachDistance._1m;
                case "1.5m":
                    return StoppingPointReachDistance._1_5m;
                case "2m":
                    return StoppingPointReachDistance._2m;
                case "2.5m":
                    return StoppingPointReachDistance._2_5m;
                case "3m":
                    return StoppingPointReachDistance._3m;
                case "5m":
                    return StoppingPointReachDistance._5m;
                case "7.5m":
                    return StoppingPointReachDistance._7_5m;
                case "10m":
                    return StoppingPointReachDistance._10m;
                case "15m":
                    return StoppingPointReachDistance._15m;
                case "20m":
                    return StoppingPointReachDistance._20m;
                case "25m":
                    return StoppingPointReachDistance._25m;
                case "30m":
                    return StoppingPointReachDistance._30m;
                case "50m":
                    return StoppingPointReachDistance._50m;
                case "75m":
                    return StoppingPointReachDistance._75m;
                case "100m":
                    return StoppingPointReachDistance._100m;
                default:
                    return null;
            }
        }
        public override void Write(Utf8JsonWriter writer, StoppingPointReachDistance? value, JsonSerializerOptions options)
        {

            switch (value)
            {
                case StoppingPointReachDistance._10cm:
                    writer.WriteStringValue("10cm");
                    break;
                case StoppingPointReachDistance._20cm:
                    writer.WriteStringValue("20cm");
                    break;
                case StoppingPointReachDistance._30cm:
                    writer.WriteStringValue("30cm");
                    break;
                case StoppingPointReachDistance._40cm:
                    writer.WriteStringValue("40cm");
                    break;
                case StoppingPointReachDistance._50cm:
                    writer.WriteStringValue("50cm");
                    break;
                case StoppingPointReachDistance._1m:
                    writer.WriteStringValue("1m");
                    break;
                case StoppingPointReachDistance._1_5m:
                    writer.WriteStringValue("1.5m");
                    break;
                case StoppingPointReachDistance._2m:
                    writer.WriteStringValue("2m");
                    break;
                case StoppingPointReachDistance._2_5m:
                    writer.WriteStringValue("2.5m");
                    break;
                case StoppingPointReachDistance._3m:
                    writer.WriteStringValue("3m");
                    break;
                case StoppingPointReachDistance._5m:
                    writer.WriteStringValue("5m");
                    break;
                case StoppingPointReachDistance._7_5m:
                    writer.WriteStringValue("7.5m");
                    break;
                case StoppingPointReachDistance._10m:
                    writer.WriteStringValue("10m");
                    break;
                case StoppingPointReachDistance._15m:
                    writer.WriteStringValue("15m");
                    break;
                case StoppingPointReachDistance._20m:
                    writer.WriteStringValue("20m");
                    break;
                case StoppingPointReachDistance._25m:
                    writer.WriteStringValue("25m");
                    break;
                case StoppingPointReachDistance._30m:
                    writer.WriteStringValue("30m");
                    break;
                case StoppingPointReachDistance._50m:
                    writer.WriteStringValue("50m");
                    break;
                case StoppingPointReachDistance._75m:
                    writer.WriteStringValue("75m");
                    break;
                case StoppingPointReachDistance._100m:
                    writer.WriteStringValue("100m");
                    break;
                default:
                    writer.WriteNullValue();
                    break;
            }
        }
    }
}
