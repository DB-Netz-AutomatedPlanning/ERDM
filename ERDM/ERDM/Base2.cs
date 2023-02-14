
using ERDM.Tier_0;
using ERDM.Tier_3;
using System.Text.Json.Serialization;

namespace ERDM.Tier_2
{
    [JsonDerivedType(typeof(AreaOfControl), typeDiscriminator: "AreaOfControl")]
    [JsonDerivedType(typeof(TrackEdgePoint), typeDiscriminator: "TrackEdgePoint")]
    [JsonDerivedType(typeof(DirectedTrackEdgePoint), typeDiscriminator: "DirectedTrackEdgePoint")]
    [JsonDerivedType(typeof(TrackEdgeSection), typeDiscriminator: "TrackEdgeSection")]
    [JsonDerivedType(typeof(DirectedTrackEdgeSection), typeDiscriminator: "DirectedTrackEdgeSection")]
    [JsonDerivedType(typeof(TrackArea), typeDiscriminator: "TrackArea")]
    [JsonDerivedType(typeof(ContiguousTrackArea), typeDiscriminator: "ContiguousTrackArea")]
    [JsonDerivedType(typeof(LinearContiguousTrackArea), typeDiscriminator: "LinearContiguousTrackArea")]
    public class Base2 : MapDataObject
	{
        public string? id { get; set; }
        public string? name{get;set;}
		public string? version{get;set;}
	}

}