
namespace RCA_Model.Tier_1
{
	public class TrackNavigability : Base, Tier1
	{
		public TrackEdge fromTrackEdge;
		public TrackEdgeSide fromTrackEdgeSide;
		public TrackEdge toTrackEdge;
		public TrackEdgeSide toTrackEdgeSide;
		public TrackNode appliesToTrackNode;
	}

}
