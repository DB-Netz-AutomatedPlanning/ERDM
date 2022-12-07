using RCA_Model.Tier_1;
using RCA_Model.Tier_2;
using RCA_Model.Tier_3;
namespace RCA_Model.Tier_3
{
	public abstract class Signal : Base, Tier3
	{
		public List<DirectedTrackEdgePoint> appliesToTrackEdgePoint;
	}

}
