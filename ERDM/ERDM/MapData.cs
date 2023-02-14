
using ERDM.Tier_1;
using ERDM.Tier_2;
using ERDM.Tier_3;
using ERDM;
using System.Text.Json.Serialization;
using ERDM;
using System.Collections.Generic;

namespace ERDM.Tier_0
{

	public class MapData : Base0
	{

		public string? name{get;set;}
		public string? version{get;set;}
		public string? belongsToAreaOfControl { get;set;}
		public List<string>? consistsOfTier0Objects{get;set;}
		public List<string>? consistsOfTier1Objects{get;set;}
		public List<string>? consistsOfTier2Objects{get;set;}
		public List<string>? consistsOfTier3Objects{get;set;}
		public string? containsReleaseInformation{get;set;}
	}

}