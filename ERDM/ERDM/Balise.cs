

using ERDM.Tier_2;
using ERDM.Tier_3;
using ERDM;
using System.Collections;
using System.Text.Json.Serialization;

namespace ERDM.Tier_3
{
	public class Balise : Base3
	{
		public string? appliesToTrackEdgePoint { get;set;}
		public int? positionInGroup{get;set;}
        [JsonConverter(typeof(BitArrayConverter))]
        public BitArray? baliseTelegram{get;set;}
	}

}