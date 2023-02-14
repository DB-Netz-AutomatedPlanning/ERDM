



using System.Text.Json.Serialization;

namespace ERDM.Tier_0
{
    [JsonDerivedType(typeof(Version), typeDiscriminator: "Version")]
    [JsonDerivedType(typeof(MapData), typeDiscriminator: "MapData")]
    [JsonDerivedType(typeof(Release), typeDiscriminator: "Release")]
    [JsonDerivedType(typeof(GeoCoordinates), typeDiscriminator: "GeoCoordinates")]
    [JsonDerivedType(typeof(LineReference), typeDiscriminator: "LineReference")]
    [JsonDerivedType(typeof(OperationalPoint), typeDiscriminator: "OperationalPoint")]
    public abstract class Base0 : MapDataObject
	{
        public string? id { get; set; }
    }

}