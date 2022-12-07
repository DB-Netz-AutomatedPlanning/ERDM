using RCA_Model.Tier_1;
using RCA_Model.Tier_2;
using RCA_Model.Tier_3;
namespace RCA_Model.Tier_0
{
	public class MapData : Tier0
	{
		public string id;
		public string name;
		public Version version;
		public AreaOfControl belongsToAreaOfControl;
		public List<Tier0> consistsOfTier0Objects;
		public List<Tier1> consistsOfTier1Objects;
		public List<Tier2> consistsOfTier2Objects;
		public List<Tier3> consistsOfTier3Objects;
		public Release containsReleaseInformation;
	}

}
