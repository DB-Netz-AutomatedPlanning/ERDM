using RCA_Model.Tier_1;
namespace RCA_Model.Tier_2
{
	public class TrackEdgeSection : Base, Tier2
	{
		public TrackEdgePoint hasStartTrackEdgePoint;
		public TrackEdgePoint hasEndTrackEdgePoint;
		public double length;
		public double lateralOffset;
		public double verticalOffset;
		public TrackEdge isPartOfTrackEdge;
	}

}
