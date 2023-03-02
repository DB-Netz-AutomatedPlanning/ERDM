using System.Collections;
using System.Text;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.Xml;


namespace ERDM
{
    public class SerializableBitArrayXML : IXmlSerializable
    {
        private BitArray bitArray;

        public SerializableBitArrayXML()
        {
            this.bitArray = new BitArray(0);
        }

        public SerializableBitArrayXML(int length)
        {
            this.bitArray = new BitArray(length);
        }

        public SerializableBitArrayXML(bool[] values)
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
    }
}