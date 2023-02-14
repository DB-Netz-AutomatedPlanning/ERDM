
using ERDM.Tier_0;
using System.Text.Json.Serialization;

namespace ERDM.Tier_1
{
    [JsonDerivedType(typeof(TrackNode), typeDiscriminator: "TrackNode")]
    [JsonDerivedType(typeof(TrackEdge), typeDiscriminator: "TrackEdge")]
    [JsonDerivedType(typeof(TrackNavigability), typeDiscriminator: "TrackNavigability")]
    public abstract class Base1 : MapDataObject
	{
        public string? id { get; set; }
        public string? name{get;set;}
		public string? version{get;set;}
	}

}