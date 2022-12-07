using RCA_Model.Tier_1;
using RCA_Model.Tier_3;
namespace RCA_Model.Tier_3
{
	public class AreaOfControl : Base, Tier3
	{
		public string areaOfControlIdentifier;
		public List<AdjacentAreaOfControl> adjacentAreaOfControl;
	}

}
