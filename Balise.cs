using RCA_Model.Tier_1;
using RCA_Model.Tier_2;
using RCA_Model.Tier_3;
using System.Collections;
namespace RCA_Model.Tier_3
{
	public class Balise : Base, Tier3
	{
		public TrackEdgePoint appliesToTrackEdgePoint;
		public int positionInGroup;
		public BitArray baliseTelegram;
	}

}
