
using ERDM.Tier_2;
using ERDM.Tier_3;
using ERDM;
using System.Text.Json.Serialization;

namespace ERDM.Tier_3
{
	public class GenericSpotObject : GenericSpatialObject
	{
		public string? appliesToTrackEdgePoint { get;set;}
		[JsonConverter(typeof(GenericSpotObjectTypeJsonConverter))]
		public GenericSpotObjectType? type{get;set;}
	}

}