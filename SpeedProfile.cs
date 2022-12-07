using RCA_Model.Tier_1;
using RCA_Model.Tier_2;
using RCA_Model.Tier_3;
namespace RCA_Model.Tier_3
{
	public abstract class SpeedProfile : Base, Tier3
	{
		public List<DirectedTrackEdgeSection> appliesToTrackEdgeSection;
		public int speed;
		public TrainEndApplicability trainEndApplicability;
	}

}
