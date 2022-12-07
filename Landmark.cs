using RCA_Model.Tier_1;
using RCA_Model.Tier_2;
namespace RCA_Model.Tier_3
{
	public class Landmark : Base, Tier3
	{
		public TrackEdgePoint appliesToTrackEdgePoint;
		public LandmarkType type;
		public List<string> label;
	}

}
