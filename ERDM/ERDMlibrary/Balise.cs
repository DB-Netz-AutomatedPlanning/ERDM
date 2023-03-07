using System.Collections;
using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Serialization;

namespace ERDM.Tier_3
{
	public class Balise : Tier3
	{
        public string? appliesToTrackEdgePoint { get;set;}
		public int? positionInGroup{get;set;}
		
		[XmlElement("baliseTelegram")]
        [JsonConverter(typeof(CustomBitArray))]
        public CustomBitArray? baliseTelegram { get; set; }

	}

}