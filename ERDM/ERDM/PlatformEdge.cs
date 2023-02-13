
using ERDM.Tier_2;
using ERDM;
using ERDM;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ERDM.Tier_3
{
	public class PlatformEdge : Tier3
	{
		public string? appliesToLinearContiguousTrackArea { get;set;}
        public PassengersBoardAndAlign? situatedSide{get;set;}
        [JsonConverter(typeof(DoubleThreeDecimalsConverter))]
        public double? length{get;set;}
		public List<string>? hasStopLocation{get;set;}
		public string? hasAccessViaTracks{get;set;}
	}

}