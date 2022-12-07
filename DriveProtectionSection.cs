using RCA_Model.Tier_1;
using RCA_Model.Tier_2;
using RCA_Model.Tier_3;
namespace RCA_Model.Tier_3
{
	public class DriveProtectionSection : Base, Tier3
	{
		public TrackEdgeSection appliesToTrackEdgeSection;
		public StaticDirectionConfiguration flankProtectionDirection;
		public MinimalDefaultDrivabilityState minimalDrivability;
	}

}
