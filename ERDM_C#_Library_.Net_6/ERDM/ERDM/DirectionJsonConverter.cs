using Newtonsoft.Json;
using ERDM.Tier_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ERDM
{
    public class DirectionJsonConverter : System.Text.Json.Serialization.JsonConverter<Direction?>
    {
        public override Direction? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Null)
                return null;
            else if (reader.TokenType != JsonTokenType.String)
                throw new JsonSerializationException(string.Format("Unexpected token {0}", reader.TokenType));
            var s = reader.GetString();
            switch (s)
            {
                case "Start to End":
                    return Direction.StartToEnd;
                case "End to Start":
                    return Direction.EndToStart;
                case "Both":
                    return Direction.Both;
                default:
                    return null;
            }
        }
        public override void Write(Utf8JsonWriter writer, Direction? value, JsonSerializerOptions options)
        {

            switch (value)
            {
                case Direction.StartToEnd:
                    writer.WriteStringValue("Start to End");
                    break;
                case Direction.EndToStart:
                    writer.WriteStringValue("End to Start");
                    break;
                case Direction.Both:
                    writer.WriteStringValue("Both");
                    break;
                default:
                    writer.WriteNullValue();
                    break;
            }
        }
    }
}
