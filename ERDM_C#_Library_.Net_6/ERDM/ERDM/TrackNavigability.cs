

namespace ERDM.Tier_1
{
	public class TrackNavigability : Tier1
	{
		public string? fromTrackEdge { get;set;}
		public TrackEdgeSide? fromTrackEdgeSide{get;set;}
		public string? toTrackEdge { get;set;}
		public TrackEdgeSide? toTrackEdgeSide{get;set;}
		public string? appliesToTrackNode { get;set;}
	}

}