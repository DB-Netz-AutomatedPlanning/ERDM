using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace ERDM
{
    public class CustomTime : System.Text.Json.Serialization.JsonConverter<CustomTime?>, IXmlSerializable
    {
        public TimeSpan value { get; set; }
        public CustomTime()
        {
        }
        public CustomTime(TimeSpan value)
        {
            this.value = value;
        }
        //xml section
        public XmlSchema? GetSchema()
        {
            return null;
        }
        public void ReadXml(XmlReader reader)
        {
            TimeSpan.TryParse(reader.ReadElementContentAsString(), out TimeSpan value);
            value= value;
        }
        public void WriteXml(XmlWriter writer)
        {
            string sign = value < TimeSpan.Zero ? "-" : "+";
            var stringOutput = value != TimeSpan.Zero ? sign + value.ToString(@"mm\:ss") : null;
            if (stringOutput != null)
                writer.WriteString(stringOutput);
        }


        //JSON section

        public override CustomTime? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Null)
                return null;
            TimeSpan.TryParse(reader.GetString(), out TimeSpan value);
            return new CustomTime(value);
        }
        public override void Write(Utf8JsonWriter writer, CustomTime? outputValue, JsonSerializerOptions options)
        {
            string sign = outputValue!=null && outputValue.value < TimeSpan.Zero ? "-" : "+";
            var stringOutput= outputValue!=null? sign+outputValue.value.ToString(@"mm\:ss"):null;
            if (stringOutput != null)
                writer.WriteStringValue(stringOutput);
        }


    }
}
