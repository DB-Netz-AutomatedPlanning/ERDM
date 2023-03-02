

using ERDM.Tier_2;
using ERDM.Tier_3;
using ERDM;
using System.Collections;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace ERDM.Tier_3
{
	public class Balise : Tier3
	{
		public string? appliesToTrackEdgePoint { get;set;}
		public int? positionInGroup{get;set;}
        [JsonConverter(typeof(BitArrayConverter))]
        [XmlIgnore]
        public BitArray? baliseTelegram{get;set;}
        [JsonIgnore]
        [XmlElement("baliseTelegram")]
        public SerializableBitArrayXML? baliseTelegramXML { get; set; }
    }

}