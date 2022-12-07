using RCA_Model.Tier_1;
using RCA_Model.Tier_2;
using RCA_Model.Tier_3;
namespace RCA_Model.Tier_3
{
	public class Derailer : Base, Tier3
	{
		public TrackEdgePoint appliesToTrackEdgePoint;
		public DriveProtectionSectionGroup appliesToDpsGroup;
		public DriveProtectionSection appliesToDps;
		public double reversalTime;
	}

}
