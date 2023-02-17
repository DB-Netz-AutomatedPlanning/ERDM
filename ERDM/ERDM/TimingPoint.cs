
using ERDM.Tier_2;
using ERDM;
using System.Text.Json.Serialization;

namespace ERDM.Tier_3
{
	public class TimingPoint : Tier3
	{
		public string? timingPointIdentifier{get;set;}
		public string? appliesToTrackEdgePoint{get;set;}
		[JsonConverter(typeof(StopLocationToleranceJsonConverter))]
		public StopLocationTolerance? stopLocationTolerance{get;set;}
        [JsonConverter(typeof(StoppingPointReachDistanceJsonConverter))]
        public StoppingPointReachDistance? stoppingPointReachDistance{get;set;}
        [JsonConverter(typeof(DoorOpeningSideJsonConverter))]
        public DoorOpeningSide? doorOpeningSide{get;set;}
		public string? refersToSignal{get;set;}
	}

}