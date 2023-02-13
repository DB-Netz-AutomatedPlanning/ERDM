
using ERDM.Tier_3;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ERDM.Tier_3
{
	public class SlipCrossing : Point
	{
		[JsonConverter(typeof(SlipCrossingTypeJsonConverter))]
		public SlipCrossingType? type{get;set;}
		public string? appliesToDpsGroupA{get;set;}
		public List<string>? appliesToDpsRightA{get;set;}
		public List<string>? appliesToDpsLeftA{get;set;}
		public string? appliesToDpsGroupB{get;set;}
		public List<string>? appliesToDpsRightB{get;set;}
		public List<string>? appliesToDpsLeftB{get;set;}
		public int? speedBranchRoute{get;set;}
	}

}