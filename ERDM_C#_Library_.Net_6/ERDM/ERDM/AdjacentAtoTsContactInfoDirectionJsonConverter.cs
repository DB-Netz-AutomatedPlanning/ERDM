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
    public class AdjacentAtoTsContactInfoDirectionJsonConverter : System.Text.Json.Serialization.JsonConverter<AdjacentAtoTsContactInfoDirection?>
    {
        public override AdjacentAtoTsContactInfoDirection? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Null)
                return null;
            else if (reader.TokenType != JsonTokenType.String)
                throw new JsonSerializationException(string.Format("Unexpected token {0}", reader.TokenType));
            var s = reader.GetString();
            switch (s)
            {
                case "No Contact info follows":
                    return AdjacentAtoTsContactInfoDirection.NoContactInfoFollows;
                case "ATO-TS contact info for nominal direction follows":
                    return AdjacentAtoTsContactInfoDirection.Nominal;
                case "ATO-TS contact info for reverse direction follow":
                    return AdjacentAtoTsContactInfoDirection.Reverse;
                default:
                    return null;
            }
        }
        public override void Write(Utf8JsonWriter writer, AdjacentAtoTsContactInfoDirection? value, JsonSerializerOptions options)
        {

            switch (value)
            {
                case AdjacentAtoTsContactInfoDirection.NoContactInfoFollows:
                    writer.WriteStringValue("No Contact info follows");
                    break;
                case AdjacentAtoTsContactInfoDirection.Nominal:
                    writer.WriteStringValue("ATO-TS contact info for nominal direction follows");
                    break;
                case AdjacentAtoTsContactInfoDirection.Reverse:
                    writer.WriteStringValue("ATO-TS contact info for reverse direction follow");
                    break;
                default:
                    writer.WriteNullValue();
                    break;
            }
        }
    }
}
