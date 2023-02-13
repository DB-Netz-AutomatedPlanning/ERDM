using Newtonsoft.Json;
using ERDM.Tier_0;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace ERDM
{
    public class TypeOfTheOperationalPointJsonConverter : System.Text.Json.Serialization.JsonConverter<TypeOfTheOperationalPoint?>
    {
        public override TypeOfTheOperationalPoint? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Null)
                return null;
            else if (reader.TokenType != JsonTokenType.String)
                throw new JsonSerializationException(string.Format("Unexpected token {0}", reader.TokenType));
            var s = reader.GetString();
            switch (s)
            {
                case "station":
                    return TypeOfTheOperationalPoint.station;
                case "small station":
                    return TypeOfTheOperationalPoint.smallStation;
                case "passenger terminal":
                    return TypeOfTheOperationalPoint.passengerTerminal;
                case "passenger stop":
                    return TypeOfTheOperationalPoint.passengerStop;
                case "freight terminal":
                    return TypeOfTheOperationalPoint.freightTerminal;
                case "depot":
                    return TypeOfTheOperationalPoint.depot;
                case "train technical services":
                    return TypeOfTheOperationalPoint.trainTechnicalServices;
                case "junction":
                    return TypeOfTheOperationalPoint.junction;
                case "point":
                    return TypeOfTheOperationalPoint.point;
                case "shunting yard":
                    return TypeOfTheOperationalPoint.shuntingYard;
                case "technical change":
                    return TypeOfTheOperationalPoint.technicalChange;
                case "private siding":
                    return TypeOfTheOperationalPoint.privateSiding;
                case "border point":
                    return TypeOfTheOperationalPoint.borderPoint;
                case "domestic border point":
                    return TypeOfTheOperationalPoint.domesticBorderPoint;
                default:
                    return null;
            }
        }
        public override void Write(Utf8JsonWriter writer, TypeOfTheOperationalPoint? value, JsonSerializerOptions options)
        {

            switch (value)
            {
                case TypeOfTheOperationalPoint.station:
                    writer.WriteStringValue("station");
                    break;
                case TypeOfTheOperationalPoint.smallStation:
                    writer.WriteStringValue("small station");
                    break;
                case TypeOfTheOperationalPoint.passengerTerminal:
                    writer.WriteStringValue("passenger terminal");
                    break;
                case TypeOfTheOperationalPoint.passengerStop:
                    writer.WriteStringValue("passenger stop");
                    break;
                case TypeOfTheOperationalPoint.freightTerminal:
                    writer.WriteStringValue("freight terminal");
                    break;
                case TypeOfTheOperationalPoint.depot:
                    writer.WriteStringValue("depot");
                    break;
                case TypeOfTheOperationalPoint.trainTechnicalServices:
                    writer.WriteStringValue("train technical services");
                    break;
                case TypeOfTheOperationalPoint.junction:
                    writer.WriteStringValue("junction");
                    break;
                case TypeOfTheOperationalPoint.point:
                    writer.WriteStringValue("point");
                    break;
                case TypeOfTheOperationalPoint.shuntingYard:
                    writer.WriteStringValue("shunting yard");
                    break;
                case TypeOfTheOperationalPoint.technicalChange:
                    writer.WriteStringValue("technical change");
                    break;
                case TypeOfTheOperationalPoint.privateSiding:
                    writer.WriteStringValue("private siding");
                    break;
                case TypeOfTheOperationalPoint.borderPoint:
                    writer.WriteStringValue("border point");
                    break;
                case TypeOfTheOperationalPoint.domesticBorderPoint:
                    writer.WriteStringValue("domestic border point");
                    break;
                default:
                    writer.WriteNullValue();
                    break;
            }
        }
    }
}
