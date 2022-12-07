
namespace RCA_Model.Tier_1
{
	public class TrackEdge : Base, Tier1
	{
		public double length;
		public List<TrackEdgeGauge> gauge;
		public TrackNode hasStartTrackNode;
		public TrackNode hasEndTrackNode;
	}

}
