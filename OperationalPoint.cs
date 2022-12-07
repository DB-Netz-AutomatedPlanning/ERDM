using RCA_Model.Tier_3;
namespace RCA_Model.Tier_0
{
	public class OperationalPoint : Tier0
	{
		public string id;
		public string name;
		public string identifier;
		public TypeOfTheOperationalPoint type;
		public List<LineReference> lineReference;
		public GeoCoordinates isLocatedAtGeoCoordinate;
		public List<AreaOfControl> isWithinAreaOfControl;
	}

}
