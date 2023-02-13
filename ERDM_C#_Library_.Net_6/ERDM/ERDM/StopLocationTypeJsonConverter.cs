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
    public class StopLocationTypeJsonConverter : System.Text.Json.Serialization.JsonConverter<StopLocationType?>
    {
        public override StopLocationType? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Null)
                return null;
            else if (reader.TokenType != JsonTokenType.String)
                throw new JsonSerializationException(string.Format("Unexpected token {0}", reader.TokenType));
            var s = reader.GetString();
            switch (s)
            {
                case "Generic stop location (valid for all type of trains)":
                    return StopLocationType.Generic;
                case "Stop location based on train length (200m, 300m, ...)":
                    return StopLocationType.BasedOnNumberOfWagons;
                case "Stop location based on the number of wagons (1, 2, 3, ...)":
                    return StopLocationType.BasedOnNumberOfAxles;
                case "Stop location based on number of axles":
                    return StopLocationType.BasedOnConfigurationOfTrainUnits;
                case "Stop location based on the configuration of train units (short train, half train, full train)":
                    return StopLocationType.BasedOnTrainLength;
                default:
                    return null;
            }
        }
        public override void Write(Utf8JsonWriter writer, StopLocationType? value, JsonSerializerOptions options)
        {

            switch (value)
            {
                case StopLocationType.Generic:
                    writer.WriteStringValue("Generic stop location (valid for all type of trains)");
                    break;
                case StopLocationType.BasedOnNumberOfWagons:
                    writer.WriteStringValue("Stop location based on train length (200m, 300m, ...)");
                    break;
                case StopLocationType.BasedOnNumberOfAxles:
                    writer.WriteStringValue("Stop location based on the number of wagons (1, 2, 3, ...)");
                    break;
                case StopLocationType.BasedOnConfigurationOfTrainUnits:
                    writer.WriteStringValue("Stop location based on number of axles");
                    break;
                case StopLocationType.BasedOnTrainLength:
                    writer.WriteStringValue("Stop location based on the configuration of train units (short train, half train, full train)");
                    break;
                default:
                    writer.WriteNullValue();
                    break;
            }
        }
    }
}
