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
    public class ETCSmarkerFunctionJsonConverter : System.Text.Json.Serialization.JsonConverter<ETCSmarkerFunction?>
    {
        public override ETCSmarkerFunction? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Null)
                return null;
            else if (reader.TokenType != JsonTokenType.String)
                throw new JsonSerializationException(string.Format("Unexpected token {0}", reader.TokenType));
            var s = reader.GetString();
            switch (s)
            {
                case "ETCS Stop Marker":
                    return ETCSmarkerFunction.ETCSstopMarker;
                case "ETCS Location Marker":
                    return ETCSmarkerFunction.ETCSlocationMarker;
                default:
                    return null;
            }
        }
        public override void Write(Utf8JsonWriter writer, ETCSmarkerFunction? value, JsonSerializerOptions options)
        {

            switch (value)
            {
                case ETCSmarkerFunction.ETCSstopMarker:
                    writer.WriteStringValue("ETCS Stop Marker");
                    break;
                case ETCSmarkerFunction.ETCSlocationMarker:
                    writer.WriteStringValue("ETCS Location Marker");
                    break;
                default:
                    writer.WriteNullValue();
                    break;
            }
        }
    }
}
