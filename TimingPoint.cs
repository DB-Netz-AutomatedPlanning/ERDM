using RCA_Model.Tier_1;
using RCA_Model.Tier_2;
namespace RCA_Model.Tier_3
{
	public class TimingPoint : Base, Tier3
	{
		public string timingPointIdentifier;
		public DirectedTrackEdgePoint appliesToTrackEdgePoint;
		public StopLocationTolerance stopLocationTolerance;
		public StoppingPointReachDistance stoppingPointReachDistance;
		public DoorOpeningSide doorOpeningSide;
		public Signal refersToSignal;
	}

}
