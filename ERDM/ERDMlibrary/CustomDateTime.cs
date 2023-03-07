using System.Xml.Schema;
using System.Xml.Serialization;
using System.Xml;
using System.Runtime.Serialization;
using ERDM.Tier_3;
using System.Text.Json;

namespace ERDM {
public class CustomDateTime : System.Text.Json.Serialization.JsonConverter<CustomDateTime?>, IXmlSerializable
{
        public DateTimeOffset value { get; set; }

        //XML section
        public CustomDateTime()
        {
        }
        public CustomDateTime(DateTimeOffset value)
        {
            this.value = value;
        }

        public XmlSchema GetSchema()
        {
            return null;
        }

        public void ReadXml(XmlReader reader)
        {
            string dateString = reader.ReadElementContentAsString();
            if (!DateTimeOffset.TryParse(dateString, out DateTimeOffset value))
            {
                //throw new ArgumentException("Invalid date format");
            }
        }

        public void WriteXml(XmlWriter writer)
        {
            writer.WriteString(value.ToString("yyyy-MM-ddTHH:mm:ss.fffzzz").Replace("Z", "+00:00"));
        }

        //JSON section

        public override CustomDateTime? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Null)
                return null;
            DateTimeOffset.TryParse(reader.GetString(), out DateTimeOffset value);
            return new CustomDateTime(value);
        }

        public override void Write(Utf8JsonWriter writer, CustomDateTime? outputValue, JsonSerializerOptions options)
        {
            var stringOutput = outputValue != null ? outputValue.value.ToString("yyyy-MM-ddTHH:mm:ss.fffzzz"):null;
            if (stringOutput != null)
                writer.WriteStringValue(stringOutput);

        }



    }
}
