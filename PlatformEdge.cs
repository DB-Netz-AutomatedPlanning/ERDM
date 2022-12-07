using RCA_Model.Tier_1;
using RCA_Model.Tier_2;
namespace RCA_Model.Tier_3
{
	public class PlatformEdge : Base, Tier3
	{
		public LinearContiguousTrackArea appliesToLinearContiguousTrackArea;
		public PassengersBoardAndAlign situatedSide;
		public double length;
		public List<StopLocation> hasStopLocation;
		public TrackArea hasAccessViaTracks;
	}

}
