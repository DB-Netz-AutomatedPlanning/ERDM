using RCA_Model.Tier_0;
using RCA_Model.Tier_1;
namespace RCA_Model.Tier_2
{
	public class TrackEdgePoint : Base, Tier2
	{
		public TrackEdge isPositionedOnTrackEdge;
		public double offset;
		public GeoCoordinates isLocatedAtGeoCoordinates;
		public double lateralOffset;
		public double verticalOffset;
		public OperationalPoint hasOperationalPoint;
		public List<LineReference> lineReference;
	}

}
