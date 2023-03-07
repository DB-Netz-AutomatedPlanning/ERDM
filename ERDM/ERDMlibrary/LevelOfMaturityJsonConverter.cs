using Newtonsoft.Json;
using ERDM.Tier_0;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ERDM
{
    public class LevelOfMaturityJsonConverter : System.Text.Json.Serialization.JsonConverter<LevelOfMaturity?>
    {
        public override LevelOfMaturity? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Null)
                return null;
            else if (reader.TokenType != JsonTokenType.String)
                throw new JsonSerializationException(string.Format("Unexpected token {0}", reader.TokenType));
            var s = reader.GetString();
            switch (s)
            {
                case "engineered":
                    return LevelOfMaturity.engineered;
                case "validated":
                    return LevelOfMaturity.validated;
                case "ready for test":
                    return LevelOfMaturity.readyForTest;
                case "ready for operation":
                    return LevelOfMaturity.readyForOperation;
                case "preloaded":
                    return LevelOfMaturity.preloaded;
                case "activated":
                    return LevelOfMaturity.activated;
                default:
                    return null;
            }
        }

        public override void Write(Utf8JsonWriter writer, LevelOfMaturity? value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case LevelOfMaturity.engineered:
                    writer.WriteStringValue("engineered");
                    break;
                case LevelOfMaturity.validated:
                    writer.WriteStringValue("validated");
                    break;
                case LevelOfMaturity.readyForTest:
                    writer.WriteStringValue("ready for test");
                    break;
                case LevelOfMaturity.readyForOperation:
                    writer.WriteStringValue("ready for operation");
                    break;
                case LevelOfMaturity.preloaded:
                    writer.WriteStringValue("preloaded");
                    break;
                case LevelOfMaturity.activated:
                    writer.WriteStringValue("activated");
                    break;
                default:
                    writer.WriteNullValue();
                    break;

            }
            
        }
    }
}
