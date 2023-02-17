
using ERDM.Tier_2;
using ERDM.Tier_3;
using ERDM;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ERDM.Tier_3
{
	public class TunnelTube : Tier3
	{
		public List<string>? appliesToTrackArea{get;set;}
		public string? hasStartTunnelPortal { get;set;}
		public string? hasEndTunnelPortal { get;set;}
        [JsonConverter(typeof(DoubleThreeDecimalsConverter))]
        public double? length{get;set;}
	}

}