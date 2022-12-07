using RCA_Model.Tier_0;
namespace RCA_Model.Tier_1
{
	public class TrackNode : Base, Tier1
	{
		public TrackNodeType nodeType;
		public GeoCoordinates isLocatedAtGeoCoordinate;
		public OperationalPoint hasOperationalPoin;
		public List<LineReference> lineReference;
	}

}
