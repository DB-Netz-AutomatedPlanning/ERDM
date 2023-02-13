using Newtonsoft.Json;
using ERDM.Tier_1;
using ERDM.Tier_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ERDM
{
    public class TrackEdgeGaugeJsonListConverter : System.Text.Json.Serialization.JsonConverter<List<TrackEdgeGauge?>>
    {
        
        public override List<TrackEdgeGauge?>? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Null) {
                return null;
            } 
            else if (reader.TokenType != JsonTokenType.StartArray){
                throw new JsonSerializationException(string.Format("Unexpected token {0}", reader.TokenType));
            }
            List<TrackEdgeGauge?> newList = new List<TrackEdgeGauge?>();
            while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
            {
                try
                {
                    var s = reader.GetString();
                    switch (s)
                    {
                        case "750":
                            newList.Add(TrackEdgeGauge._750);
                            break;
                        case "1000":
                            newList.Add(TrackEdgeGauge._1000);
                            break;
                        case "1435":
                            newList.Add(TrackEdgeGauge._1435);
                            break;
                        case "1520":
                            newList.Add(TrackEdgeGauge._1520);
                            break;
                        case "1524":
                            newList.Add(TrackEdgeGauge._1524);
                            break;
                        case "1600":
                            newList.Add(TrackEdgeGauge._1600);
                            break;
                        case "1668":
                            newList.Add(TrackEdgeGauge._1668);
                            break;
                        default:
                            newList.Add(null);
                            break;
                    }
                }
                catch (Exception)
                {

                }

            }

            return newList;
        }
        public override void Write(Utf8JsonWriter writer, List<TrackEdgeGauge?> value, JsonSerializerOptions options)
        {
            writer.WriteStartArray();
            foreach (var item in value)
            {
                switch (item)
                {
                    case TrackEdgeGauge._750:
                        writer.WriteStringValue("750");
                        break;
                    case TrackEdgeGauge._1000:
                        writer.WriteStringValue("1000");
                        break;
                    case TrackEdgeGauge._1435:
                        writer.WriteStringValue("1435");
                        break;
                    case TrackEdgeGauge._1520:
                        writer.WriteStringValue("1520");
                        break;
                    case TrackEdgeGauge._1524:
                        writer.WriteStringValue("1524");
                        break;
                    case TrackEdgeGauge._1600:
                        writer.WriteStringValue("1600");
                        break;
                    case TrackEdgeGauge._1668:
                        writer.WriteStringValue("1668");
                        break;
                    default:
                        writer.WriteNullValue();
                        break;
                }
            }
            writer.WriteEndArray();
            //writer.WriteEndObject();
        }
    }
}
