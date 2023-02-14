

using ERDM;
using ERDM;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ERDM.Tier_1
{
	public class TrackEdge : Base1
	{
        [JsonConverter(typeof(DoubleThreeDecimalsConverter))]
        public double? length{get;set;}
		[JsonConverter(typeof(TrackEdgeGaugeJsonListConverter))]
		public List<TrackEdgeGauge?>? gauge{get;set;}
		public string? hasStartTrackNode { get;set;}
		public string? hasEndTrackNode { get;set;}
	}

}