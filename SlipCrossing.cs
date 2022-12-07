using RCA_Model.Tier_3;
namespace RCA_Model.Tier_3
{
	public class SlipCrossing : Point
	{
		public SlipCrossingType type;
		public DriveProtectionSectionGroup appliesToDpsGroupA;
		public List<DriveProtectionSection> appliesToDpsRightA;
		public List<DriveProtectionSection> appliesToDpsLeftA;
		public DriveProtectionSectionGroup appliesToDpsGroupB;
		public List<DriveProtectionSection> appliesToDpsRightB;
		public List<DriveProtectionSection> appliesToDpsLeftB;
		public int speedBranchRoute;
	}

}
