using RCA_Model.Tier_1;
using RCA_Model.Tier_2;
namespace RCA_Model.Tier_3
{
	public class TrackCondition : Base, Tier3
	{
		public TrackConditionType condition;
		public List<TrackEdgeSection> appliesToTrackEdgeSection;
	}

}
