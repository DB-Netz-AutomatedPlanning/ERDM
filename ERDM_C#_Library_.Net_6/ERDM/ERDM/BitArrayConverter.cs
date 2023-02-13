
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ERDM
{
    public class BitArrayConverter : System.Text.Json.Serialization.JsonConverter<BitArray>
    {
        public override BitArray? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Null)
                return null;
            else if (reader.TokenType != JsonTokenType.String)
                throw new JsonSerializationException(string.Format("Unexpected token {0}", reader.TokenType));
            var s = reader.GetString();
            var bitArray = new BitArray(s.Length);
            for (int i = 0; i < s.Length; i++)
                bitArray[i] = s[i] == '0' ? false : s[i] == '1' ? true : throw new JsonSerializationException(string.Format("Unknown bit value {0}", s[i]));
            return bitArray;
        }



        public override void Write(Utf8JsonWriter writer, BitArray value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.Cast<bool>().Aggregate(new StringBuilder(value.Length), (sb, b) => sb.Append(b ? "1" : "0")).ToString());
        }
    }
}
