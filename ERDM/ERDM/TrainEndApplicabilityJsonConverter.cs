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
    public class TrainEndApplicabilityJsonConverter : System.Text.Json.Serialization.JsonConverter<TrainEndApplicability?>
    {
        public override TrainEndApplicability? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Null)
                return null;
            else if (reader.TokenType != JsonTokenType.String)
                throw new JsonSerializationException(string.Format("Unexpected token {0}", reader.TokenType));
            var s = reader.GetString();
            switch (s)
            {
                case "Train length delay on validity end point of profile element.":
                    return TrainEndApplicability.TrainLengthDelay;
                case "No Train length delay on validity end point of profile element.":
                    return TrainEndApplicability.NoTrainLengthDelay;
                default:
                    return null;
            }
        }
        public override void Write(Utf8JsonWriter writer, TrainEndApplicability? value, JsonSerializerOptions options)
        {

            switch (value)
            {
                case TrainEndApplicability.TrainLengthDelay:
                    writer.WriteStringValue("Train length delay on validity end point of profile element.");
                    break;
                case TrainEndApplicability.NoTrainLengthDelay:
                    writer.WriteStringValue("No Train length delay on validity end point of profile element.");
                    break;
                default:
                    writer.WriteNullValue();
                    break;
            }
        }
    }
}
