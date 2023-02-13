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
    public class StopLocationToleranceJsonConverter : System.Text.Json.Serialization.JsonConverter<StopLocationTolerance?>
    {
        public override StopLocationTolerance? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Null)
                return null;
            else if (reader.TokenType != JsonTokenType.String)
                throw new JsonSerializationException(string.Format("Unexpected token {0}", reader.TokenType));
            var s = reader.GetString();
            switch (s)
            {
                case "10cm":
                    return StopLocationTolerance._10cm;
                case "20cm":
                    return StopLocationTolerance._20cm;
                case "30cm":
                    return StopLocationTolerance._30cm;
                case "40cm":
                    return StopLocationTolerance._40cm;
                case "50cm":
                    return StopLocationTolerance._50cm;
                case "1m":
                    return StopLocationTolerance._1m;
                case "1.5m":
                    return StopLocationTolerance._1_5m;
                case "2m":
                    return StopLocationTolerance._2m;
                case "2.5m":
                    return StopLocationTolerance._2_5m;
                case "3m":
                    return StopLocationTolerance._3m;
                case "5m":
                    return StopLocationTolerance._5m;
                case "7.5m":
                    return StopLocationTolerance._7_5m;
                case "10m":
                    return StopLocationTolerance._10m;
                case "15m":
                    return StopLocationTolerance._15m;
                case "20m":
                    return StopLocationTolerance._20m;
                case "25m":
                    return StopLocationTolerance._25m;
                case "30m":
                    return StopLocationTolerance._30m;
                case "50m":
                    return StopLocationTolerance._50m;
                case "75m":
                    return StopLocationTolerance._75m;
                case "100m":
                    return StopLocationTolerance._100m;
                default:
                    return null;
            }
        }
        public override void Write(Utf8JsonWriter writer, StopLocationTolerance? value, JsonSerializerOptions options)
        {

            switch (value)
            {
                case StopLocationTolerance._10cm:
                    writer.WriteStringValue("10cm");
                    break;
                case StopLocationTolerance._20cm:
                    writer.WriteStringValue("20cm");
                    break;
                case StopLocationTolerance._30cm:
                    writer.WriteStringValue("30cm");
                    break;
                case StopLocationTolerance._40cm:
                    writer.WriteStringValue("40cm");
                    break;
                case StopLocationTolerance._50cm:
                    writer.WriteStringValue("50cm");
                    break;
                case StopLocationTolerance._1m:
                    writer.WriteStringValue("1m");
                    break;
                case StopLocationTolerance._1_5m:
                    writer.WriteStringValue("1.5m");
                    break;
                case StopLocationTolerance._2m:
                    writer.WriteStringValue("2m");
                    break;
                case StopLocationTolerance._2_5m:
                    writer.WriteStringValue("2.5m");
                    break;
                case StopLocationTolerance._3m:
                    writer.WriteStringValue("3m");
                    break;
                case StopLocationTolerance._5m:
                    writer.WriteStringValue("5m");
                    break;
                case StopLocationTolerance._7_5m:
                    writer.WriteStringValue("7.5m");
                    break;
                case StopLocationTolerance._10m:
                    writer.WriteStringValue("10m");
                    break;
                case StopLocationTolerance._15m:
                    writer.WriteStringValue("15m");
                    break;
                case StopLocationTolerance._20m:
                    writer.WriteStringValue("20m");
                    break;
                case StopLocationTolerance._25m:
                    writer.WriteStringValue("25m");
                    break;
                case StopLocationTolerance._30m:
                    writer.WriteStringValue("30m");
                    break;
                case StopLocationTolerance._50m:
                    writer.WriteStringValue("50m");
                    break;
                case StopLocationTolerance._75m:
                    writer.WriteStringValue("75m");
                    break;
                case StopLocationTolerance._100m:
                    writer.WriteStringValue("100m");
                    break;
                default:
                    writer.WriteNullValue();
                    break;
            }
        }
    }
}
