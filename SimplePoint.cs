using RCA_Model.Tier_3;
namespace RCA_Model.Tier_3
{
	public class SimplePoint : Point
	{
		public DriveProtectionSectionGroup appliesToDpsGroup;
		public DriveProtectionSection appliesToDpsRight;
		public DriveProtectionSection appliesToDpsLeft;
		public int speedRightRoute;
		public int speedLeftRoute;
		public bool hasTrailDetection;
	}

}
