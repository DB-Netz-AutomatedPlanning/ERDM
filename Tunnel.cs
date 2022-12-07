using RCA_Model.Tier_1;
using RCA_Model.Tier_3;
namespace RCA_Model.Tier_3
{
	public class Tunnel : Base, Tier3
	{
		public List<TunnelTube> consistsOfTunnelTube;
		public TunnelType tunnelType;
	}

}
