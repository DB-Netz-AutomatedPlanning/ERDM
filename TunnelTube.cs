using RCA_Model.Tier_1;
using RCA_Model.Tier_2;
using RCA_Model.Tier_3;
namespace RCA_Model.Tier_3
{
	public class TunnelTube : Base, Tier3
	{
		public List<TrackArea> appliesToTrackArea;
		public TunnelPortal hasStartTunnelPortal;
		public TunnelPortal hasEndTunnelPortal;
		public double length;
	}

}
