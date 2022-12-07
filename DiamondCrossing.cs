using RCA_Model.Tier_1;
using RCA_Model.Tier_2;
using RCA_Model.Tier_3;
namespace RCA_Model.Tier_3
{
	public class DiamondCrossing : Base, Tier3
	{
		public TrackArea appliesToTrackArea;
		public AllocationSection appliesToAllocationSection;
		public DriveProtectionSectionGroup appliesToDpsGroup;
		public List<DriveProtectionSection> appliesToDpsRight;
		public List<DriveProtectionSection> appliesToDpsLeft;
		public double reversalTime;
	}

}
