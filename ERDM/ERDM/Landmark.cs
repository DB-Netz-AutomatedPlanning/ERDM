
using ERDM.Tier_2;
using ERDM;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ERDM.Tier_3
{
	public class Landmark : Tier3
	{
		public string? appliesToTrackEdgePoint { get;set;}
        [JsonConverter(typeof(LandmarkTypeJsonConverter))]
        public LandmarkType? type{get;set;}
		public List<string>? label{get;set;}
	}

}