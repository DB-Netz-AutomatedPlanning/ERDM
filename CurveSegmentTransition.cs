using RCA_Model.Tier_0;
using RCA_Model.Tier_3;
namespace RCA_Model.Tier_3
{
	public class CurveSegmentTransition : CurveSegment
	{
		public GeoCoordinates hasCenterAtGeoCoordinate;
		public double clothoidParameter;
		public double initialArcLength;
		public double azimuthAngle;
	}

}
