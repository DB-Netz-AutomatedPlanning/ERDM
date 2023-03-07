

using System.Collections.Generic;

namespace ERDM.Tier_2
{
	public class LinearContiguousTrackArea : TrackArea
	{
		public string? startTrackEdgePoint { get;set;}
		public List<string>? viaTrackEdgePoint{get;set;}
		public string? endTrackEdgePoint { get;set;}
	}

}