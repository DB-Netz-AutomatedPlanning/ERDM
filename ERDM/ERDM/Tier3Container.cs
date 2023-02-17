using ERDM.Tier_2;
using ERDM.Tier_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERDM
{
    public class Tier3Container
    {
        public List<AdjacentAreaOfControl>? AdjacentAreaOfControl { get; set; }
        public List<StaticSpeedProfile>? StaticSpeedProfile { get; set; }
        public List<SpecificStaticSpeedProfile>? SpecificStaticSpeedProfile { get; set; }
        public List<AxleLoadSpeedProfile>? AxleLoadSpeedProfile { get; set; }
        public List<GradientSegmentLine>? GradientSegmentLine { get; set; }
        public List<GradientSegmentArc>? GradientSegmentArc { get; set; }
        public List<CurveSegmentLine>? CurveSegmentLine { get; set; }
        public List<CurveSegmentArc>? CurveSegmentArc { get; set; }
        public List<CurveSegmentTransition>? CurveSegmentTransition { get; set; }
        public List<CantSegmentLine>? CantSegmentLine { get; set; }
        public List<AllocationSection>? AllocationSection { get; set; }
        public List<DriveProtectionSection>? DriveProtectionSection { get; set; }
        public List<DriveProtectionSectionGroup>? DriveProtectionSectionGroup { get; set; }
        public List<Balise>? Balise { get; set; }
        public List<BaliseGroup>? BaliseGroup { get; set; }
        public List<SegmentProfile>? SegmentProfile { get; set; }
        public List<Landmark>? Landmark { get; set; }
        public List<LightSignal>? LightSignal { get; set; }
        public List<ETCSMarker>? ETCSMarker { get; set; }
        public List<StopLocation>? StopLocation { get; set; }
        public List<PlatformEdge>? PlatformEdge { get; set; }
        public List<TunnelPortal>? TunnelPortal { get; set; }
        public List<TunnelTube>? TunnelTube { get; set; }
        public List<Tunnel>? Tunnel { get; set; }
        public List<SimplePoint>? SimplePoint { get; set; }
        public List<SlipCrossing>? SlipCrossing { get; set; }
        public List<Derailer>? Derailer { get; set; }
        public List<DiamondCrossing>? DiamondCrossing { get; set; }
        public List<LevelCrossing>? LevelCrossing { get; set; }
        public List<TrackCondition>? TrackCondition { get; set; }
        public List<TractionSystem>? TractionSystem { get; set; }
        public List<CurrentLimitation>? CurrentLimitation { get; set; }
        public List<PermittedBrakingDistance>? PermittedBrakingDistance { get; set; }
        public List<TrackProperties>? TrackProperties { get; set; }
        public List<TracksideTrainDetectionArea>? TracksideTrainDetectionArea { get; set; }
        public List<MpTargetMarker>? MpTargetMarker { get; set; }
        public List<RiskBufferConfiguration>? RiskBufferConfiguration { get; set; }
        public List<Zone>? Zone { get; set; }
        public List<TrackZone>? TrackZone { get; set; }
        public List<NearTrackZone>? NearTrackZone { get; set; }
        public List<ProtectionZone>? ProtectionZone { get; set; }
        public List<OverheadLineEquipmentZone>? OverheadLineEquipmentZone { get; set; }
        public List<GenericSpatialObject>? GenericSpatialObject { get; set; }
        public List<GenericLinearObject>? GenericLinearObject { get; set; }
        public List<GenericSpotObject>? GenericSpotObject { get; set; }


        public Tier3Container()
        {
            AdjacentAreaOfControl = new List<AdjacentAreaOfControl>();
            StaticSpeedProfile = new List<StaticSpeedProfile>();
            SpecificStaticSpeedProfile = new List<SpecificStaticSpeedProfile>();
            AxleLoadSpeedProfile = new List<AxleLoadSpeedProfile>();
            GradientSegmentLine = new List<GradientSegmentLine>();
            GradientSegmentArc = new List<GradientSegmentArc>();
            CurveSegmentLine = new List<CurveSegmentLine>();
            CurveSegmentArc = new List<CurveSegmentArc>();
            CurveSegmentTransition = new List<CurveSegmentTransition>();
            CantSegmentLine = new List<CantSegmentLine>();
            AllocationSection = new List<AllocationSection>();
            DriveProtectionSection = new List<DriveProtectionSection>();
            DriveProtectionSectionGroup = new List<DriveProtectionSectionGroup>();
            Balise = new List<Balise>();
            BaliseGroup = new List<BaliseGroup>();
            SegmentProfile = new List<SegmentProfile>();
            Landmark = new List<Landmark>();
            LightSignal = new List<LightSignal>();
            ETCSMarker = new List<ETCSMarker>();
            StopLocation = new List<StopLocation>();
            PlatformEdge = new List<PlatformEdge>();
            TunnelPortal = new List<TunnelPortal>();
            TunnelTube = new List<TunnelTube>();
            Tunnel = new List<Tunnel>();
            SimplePoint = new List<SimplePoint>();
            SlipCrossing = new List<SlipCrossing>();
            Derailer = new List<Derailer>();
            DiamondCrossing = new List<DiamondCrossing>();
            LevelCrossing = new List<LevelCrossing>();
            TrackCondition = new List<TrackCondition>();
            TractionSystem = new List<TractionSystem>();
            CurrentLimitation = new List<CurrentLimitation>();
            PermittedBrakingDistance = new List<PermittedBrakingDistance>();
            TrackProperties = new List<TrackProperties>();
            TracksideTrainDetectionArea = new List<TracksideTrainDetectionArea>();
            MpTargetMarker = new List<MpTargetMarker>();
            RiskBufferConfiguration = new List<RiskBufferConfiguration>();
            Zone = new List<Zone>();
            TrackZone = new List<TrackZone>();
            NearTrackZone = new List<NearTrackZone>();
            ProtectionZone = new List<ProtectionZone>();
            OverheadLineEquipmentZone = new List<OverheadLineEquipmentZone>();
            GenericSpatialObject = new List<GenericSpatialObject>();
            GenericLinearObject = new List<GenericLinearObject>();
            GenericSpotObject = new List<GenericSpotObject>();
        }
    }
}
