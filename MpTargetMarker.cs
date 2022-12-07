using RCA_Model.Tier_1;
using RCA_Model.Tier_2;
namespace RCA_Model.Tier_3
{
	public class MpTargetMarker : Base, Tier3
	{
		public DirectedTrackEdgePoint appliesToTrackEdgePoint;
		public MarkerType markerType;
		public List<RiskBufferConfiguration> riskBufferConfiguration;
	}

}
