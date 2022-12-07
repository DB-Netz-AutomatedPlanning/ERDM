using RCA_Model.Tier_1;
using RCA_Model.Tier_2;
using RCA_Model.Tier_3;
namespace RCA_Model.Tier_3
{
	public abstract class Point : Base, Tier3
	{
		public List<TrackNode> appliesToTrackNode;
		public ContiguousTrackArea appliesToTrackArea;
		public AllocationSection appliesToAllocationSection;
		public double reversalTime;
	}

}
