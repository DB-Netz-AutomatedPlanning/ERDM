using Microsoft.VisualBasic;
using RCA_Model.Tier_1;
using RCA_Model.Tier_2;
namespace RCA_Model.Tier_3
{
	public class SegmentProfile : Base, Tier3
	{
		public string segmentProfileIdentifier;
		public int countryIdentifier;
		public DirectedTrackEdgeSection appliesToTrackEdgeSection;
		public double distanceToEoAOffset;
		public DateAndTime utcTimeOffset;
		public AreaOfControl isWithinAreaOfControl;
		public int adjacentAtoTsCountryIdentifier;
		public string adjacentAtoTsIdentifier;
		public string adjacentSegmentProfileIdentifier;
		public int adjacentSegmentProfileCountryIdent;
		public List<SpeedProfile> hasSpeedProfile;
		public List<GradientSegment> hasGradientSegment;
		public List<CurveSegment> hasCurveSegment;
		public List<TimingPoint> hasTimingPoint;
		public List<BaliseGroup> hasBaliseGroup;
		public List<Balise> hasBalise;
		public AdjacentAtoTsContactInfoDirection adjacentAtoTsContactInfoDirection;
		public List<PermittedBrakingDistance> hasPermittedBrakingDistance;
		public List<CurrentLimitation> hasCurrentLimitaion;
		public List<TractionSystem> hasTractionSystem;
		public List<TrackCondition> hasTrackCondition;
		public List<LevelCrossing> hasLevelCrossing;
		public List<Tunnel> hasTunnel;
		public List<PlatformEdge> hasPlatformEdge;
	}

}
