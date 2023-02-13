

using System.Text.Json.Serialization;

namespace ERDM.Tier_2
{
	public class DirectedTrackEdgeSection : TrackEdgeSection
	{
        [JsonConverter(typeof(DirectionJsonConverter))]
        public Direction? direction{get;set;}
	}

}