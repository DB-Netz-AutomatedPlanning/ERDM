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
    public class OtherSpecificSSPJsonConverter : System.Text.Json.Serialization.JsonConverter<OtherSpecificSSP?>
    {
        public override OtherSpecificSSP? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Null)
                return null;
            else if (reader.TokenType != JsonTokenType.String)
                throw new JsonSerializationException(string.Format("Unexpected token {0}", reader.TokenType));
            var s = reader.GetString();
            switch (s)
            {
                case "Specific Freight Train P":
                    return OtherSpecificSSP.SpecificFreightTrainP;
                case "Specific Freight Train G":
                    return OtherSpecificSSP.SpecificFreightTrainG;
                case "Specific Passenger Train":
                    return OtherSpecificSSP.SpecificPassengerTrain;
                default:
                    return null;
            }
        }
        public override void Write(Utf8JsonWriter writer, OtherSpecificSSP? value, JsonSerializerOptions options)
        {

            switch (value)
            {
                case OtherSpecificSSP.SpecificFreightTrainP:
                    writer.WriteStringValue("Specific Freight Train P");
                    break;
                case OtherSpecificSSP.SpecificFreightTrainG:
                    writer.WriteStringValue("Specific Freight Train G");
                    break;
                case OtherSpecificSSP.SpecificPassengerTrain:
                    writer.WriteStringValue("Specific Passenger Train");
                    break;
                default:
                    writer.WriteNullValue();
                    break;
            }
        }
    }
}
