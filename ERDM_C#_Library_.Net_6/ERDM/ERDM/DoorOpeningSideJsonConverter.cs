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
    public class DoorOpeningSideJsonConverter : System.Text.Json.Serialization.JsonConverter<DoorOpeningSide?>
    {
        public override DoorOpeningSide? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Null)
                return null;
            else if (reader.TokenType != JsonTokenType.String)
                throw new JsonSerializationException(string.Format("Unexpected token {0}", reader.TokenType));
            var s = reader.GetString();
            switch (s)
            {
                case "None":
                    return DoorOpeningSide.None;
                case "Right":
                    return DoorOpeningSide.Right;
                case "Left":
                    return DoorOpeningSide.Left;
                case "Both":
                    return DoorOpeningSide.Both;
                default:
                    return null;
            }
        }
        public override void Write(Utf8JsonWriter writer, DoorOpeningSide? value, JsonSerializerOptions options)
        {

            switch (value)
            {
                case DoorOpeningSide.None:
                    writer.WriteStringValue("None");
                    break;
                case DoorOpeningSide.Right:
                    writer.WriteStringValue("Right");
                    break;
                case DoorOpeningSide.Left:
                    writer.WriteStringValue("Left");
                    break;
                case DoorOpeningSide.Both:
                    writer.WriteStringValue("Both");
                    break;
                default:
                    writer.WriteNullValue();
                    break;
            }
        }
    }
}
