using System.Collections;
using System.Text;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.Xml;
using System.Text.Json;
using Newtonsoft.Json;

namespace ERDM
{
    public class CustomBitArray : System.Text.Json.Serialization.JsonConverter<CustomBitArray?>, IXmlSerializable
    {
        private BitArray bitArray;

        public CustomBitArray()
        {
            this.bitArray = new BitArray(0);
        }

        public CustomBitArray(int length)
        {
            this.bitArray = new BitArray(length);
        }

        public CustomBitArray(bool[] values)
        {
            this.bitArray = new BitArray(values);
        }

        public bool this[int index]
        {
            get { return this.bitArray[index]; }
            set { this.bitArray[index] = value; }
        }

        public int Length
        {
            get { return this.bitArray.Length; }
            set { this.bitArray.Length = value; }
        }

        public XmlSchema GetSchema()
        {
            return null;
        }

        public void ReadXml(XmlReader reader)
        {
            string value = reader.ReadElementContentAsString();
            int length = value.Length;
            this.bitArray = new BitArray(length);
            for (int i = 0; i < length; i++)
            {
                this.bitArray[i] = (value[i] == '1');
            }
        }

        public void WriteXml(XmlWriter writer)
        {
            StringBuilder stringBuilder = new StringBuilder(this.bitArray.Length);
            for (int i = 0; i < this.bitArray.Length; i++)
            {
                stringBuilder.Append(this.bitArray[i] ? "1" : "0");
            }
            writer.WriteString(stringBuilder.ToString());
        }

        public void Add(bool value)
        {
            int newLength = this.bitArray.Length + 1;
            BitArray newBitArray = new BitArray(newLength);
            for (int i = 0; i < this.bitArray.Length; i++)
            {
                newBitArray[i] = this.bitArray[i];
            }
            newBitArray[newLength - 1] = value;
            this.bitArray = newBitArray;
        }


        public override CustomBitArray? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Null)
                return null;
            else if (reader.TokenType != JsonTokenType.String)
                throw new JsonSerializationException(string.Format("Unexpected token {0}", reader.TokenType));
            var s = reader.GetString();
            for (int i = 0; i < s.Length; i++)
                bitArray[i] = s[i] == '0' ? false : s[i] == '1' ? true : throw new JsonSerializationException(string.Format("Unknown bit value {0}", s[i]));
            return null;
        }



        public override void Write(Utf8JsonWriter writer, CustomBitArray? value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.bitArray.Cast<bool>().Aggregate(new StringBuilder(value.bitArray.Length), (sb, b) => sb.Append(b ? "1" : "0")).ToString());
        }
    }
}