

using ERDM.Tier_1;
using ERDM.Tier_2;
using ERDM.Tier_3;
using System.Text.Json.Serialization;

namespace ERDM.Tier_0
{
    [JsonDerivedType(typeof(Version), typeDiscriminator: "Version")]
    [JsonDerivedType(typeof(MapData), typeDiscriminator: "MapData")]
    [JsonDerivedType(typeof(Release), typeDiscriminator: "Release")]
    [JsonDerivedType(typeof(GeoCoordinates), typeDiscriminator: "GeoCoordinates")]
    [JsonDerivedType(typeof(LineReference), typeDiscriminator: "LineReference")]
    [JsonDerivedType(typeof(OperationalPoint), typeDiscriminator: "OperationalPoint")]
    [JsonDerivedType(typeof(TrackNode), typeDiscriminator: "TrackNode")]
    [JsonDerivedType(typeof(TrackEdge), typeDiscriminator: "TrackEdge")]
    [JsonDerivedType(typeof(TrackNavigability), typeDiscriminator: "TrackNavigability")]
    [JsonDerivedType(typeof(TrackEdgePoint), typeDiscriminator: "TrackEdgePoint")]
    [JsonDerivedType(typeof(DirectedTrackEdgePoint), typeDiscriminator: "DirectedTrackEdgePoint")]
    [JsonDerivedType(typeof(TrackEdgeSection), typeDiscriminator: "TrackEdgeSection")]
    [JsonDerivedType(typeof(DirectedTrackEdgeSection), typeDiscriminator: "DirectedTrackEdgeSection")]
    [JsonDerivedType(typeof(TrackArea), typeDiscriminator: "TrackArea")]
    [JsonDerivedType(typeof(ContiguousTrackArea), typeDiscriminator: "ContiguousTrackArea")]
    [JsonDerivedType(typeof(LinearContiguousTrackArea), typeDiscriminator: "LinearContiguousTrackArea")]
    [JsonDerivedType(typeof(AreaOfControl), typeDiscriminator: "AreaOfControl")]
    [JsonDerivedType(typeof(AdjacentAreaOfControl), typeDiscriminator: "AdjacentAreaOfControl")]
    [JsonDerivedType(typeof(StaticSpeedProfile), typeDiscriminator: "StaticSpeedProfile")]
    [JsonDerivedType(typeof(AxleLoadSpeedProfile), typeDiscriminator: "AxleLoadSpeedProfile")]
    [JsonDerivedType(typeof(GradientSegmentLine), typeDiscriminator: "GradientSegmentLine")]
    [JsonDerivedType(typeof(GradientSegmentArc), typeDiscriminator: "GradientSegmentArc")]
    [JsonDerivedType(typeof(CurveSegmentLine), typeDiscriminator: "CurveSegmentLine")]
    [JsonDerivedType(typeof(CurveSegmentArc), typeDiscriminator: "CurveSegmentArc")]
    [JsonDerivedType(typeof(CurveSegmentTransition), typeDiscriminator: "CurveSegmentTransition")]
    [JsonDerivedType(typeof(CantSegmentLine), typeDiscriminator: "CantSegmentLine")]
    [JsonDerivedType(typeof(AllocationSection), typeDiscriminator: "AllocationSection")]
    [JsonDerivedType(typeof(DriveProtectionSection), typeDiscriminator: "DriveProtectionSection")]
    [JsonDerivedType(typeof(DriveProtectionSectionGroup), typeDiscriminator: "DriveProtectionSectionGroup")]
    [JsonDerivedType(typeof(Balise), typeDiscriminator: "Balise")]
    [JsonDerivedType(typeof(BaliseGroup), typeDiscriminator: "BaliseGroup")]
    [JsonDerivedType(typeof(SegmentProfile), typeDiscriminator: "SegmentProfile")]
    [JsonDerivedType(typeof(Landmark), typeDiscriminator: "Landmark")]
    [JsonDerivedType(typeof(LightSignal), typeDiscriminator: "LightSignal")]
    [JsonDerivedType(typeof(ETCSMarker), typeDiscriminator: "ETCSMarker")]
    [JsonDerivedType(typeof(StopLocation), typeDiscriminator: "StopLocation")]
    [JsonDerivedType(typeof(PlatformEdge), typeDiscriminator: "PlatformEdge")]
    [JsonDerivedType(typeof(TunnelPortal), typeDiscriminator: "TunnelPortal")]
    [JsonDerivedType(typeof(TunnelTube), typeDiscriminator: "TunnelTube")]
    [JsonDerivedType(typeof(Tunnel), typeDiscriminator: "Tunnel")]
    [JsonDerivedType(typeof(SimplePoint), typeDiscriminator: "SimplePoint")]
    [JsonDerivedType(typeof(SlipCrossing), typeDiscriminator: "SlipCrossing")]
    [JsonDerivedType(typeof(Derailer), typeDiscriminator: "Derailer")]
    [JsonDerivedType(typeof(DiamondCrossing), typeDiscriminator: "DiamondCrossing")]
    [JsonDerivedType(typeof(LevelCrossing), typeDiscriminator: "LevelCrossing")]
    [JsonDerivedType(typeof(TrackCondition), typeDiscriminator: "TrackCondition")]
    [JsonDerivedType(typeof(TractionSystem), typeDiscriminator: "TractionSystem")]
    [JsonDerivedType(typeof(CurrentLimitation), typeDiscriminator: "CurrentLimitation")]
    [JsonDerivedType(typeof(PermittedBrakingDistance), typeDiscriminator: "PermittedBrakingDistance")]
    [JsonDerivedType(typeof(TrackProperties), typeDiscriminator: "TrackProperties")]
    [JsonDerivedType(typeof(TracksideTrainDetectionArea), typeDiscriminator: "TracksideTrainDetectionArea")]
    [JsonDerivedType(typeof(MpTargetMarker), typeDiscriminator: "MpTargetMarker")]
    [JsonDerivedType(typeof(RiskBufferConfiguration), typeDiscriminator: "RiskBufferConfiguration")]
    [JsonDerivedType(typeof(Zone), typeDiscriminator: "Zone")]
    [JsonDerivedType(typeof(TrackZone), typeDiscriminator: "TrackZone")]
    [JsonDerivedType(typeof(NearTrackZone), typeDiscriminator: "NearTrackZone")]
    [JsonDerivedType(typeof(ProtectionZone), typeDiscriminator: "ProtectionZone")]
    [JsonDerivedType(typeof(OverheadLineEquipmentZone), typeDiscriminator: "OverheadLineEquipmentZone")]
    [JsonDerivedType(typeof(GenericSpatialObject), typeDiscriminator: "GenericSpatialObject")]
    [JsonDerivedType(typeof(GenericLinearObject), typeDiscriminator: "GenericLinearObject")]
    [JsonDerivedType(typeof(GenericSpotObject), typeDiscriminator: "GenericSpotObject")]
    [JsonDerivedType(typeof(SpecificStaticSpeedProfile), typeDiscriminator: "SpecificStaticSpeedProfile")]
    public class MapDataObject
	{
        
    }

}