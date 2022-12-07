using RCA_Model.Tier_1;
using RCA_Model.Tier_3;
namespace RCA_Model.Tier_3
{
	public class BaliseGroup : Base, Tier3
	{
		public int countryIdentifier;
		public int baliseGroupIdentifier;
		public List<Balise> consistsOfBalise;
		public int locationAccuracy;
	}

}
