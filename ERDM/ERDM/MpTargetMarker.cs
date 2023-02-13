
using ERDM.Tier_2;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ERDM.Tier_3
{
	public class MpTargetMarker : Tier3
	{
		public string? appliesToTrackEdgePoint{get;set;}
		[JsonConverter(typeof(MarkerTypeJsonConverter))]
		public MarkerType? markerType{get;set;}
		public List<string>? riskBufferConfiguration{get;set;}
	}

}