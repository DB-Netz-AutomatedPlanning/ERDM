

using System.Text.Json.Serialization;

namespace ERDM.Tier_2
{
	public class DirectedTrackEdgePoint : TrackEdgePoint
	{
		[JsonConverter(typeof(DirectionJsonConverter))]
		public Direction? direction{get;set;}
	}

}