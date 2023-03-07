
using ERDM.Tier_0;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ERDM.Tier_1
{
	public class TrackNode : Tier1
	{
		[JsonConverter(typeof(TrackNodeTypeJsonConverter))]
		public TrackNodeType? nodeType{get;set;}
		public string? isLocatedAtGeoCoordinates { get;set;}
		public string? hasOperationalPoint { get;set;}
		public List<string>? lineReference{get;set;}
	}

}