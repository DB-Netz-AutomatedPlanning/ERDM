
using ERDM.Tier_2;
using ERDM.Tier_3;
using ERDM;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ERDM.Tier_3
{
	public class DiamondCrossing : Tier3
	{
		public string? appliesToTrackArea{ get;set;}
		public string? appliesToAllocationSection{ get;set;}
		public string? appliesToDpsGroup{get;set;}
		public List<string>? appliesToDpsRight{get;set;}
		public List<string>? appliesToDpsLeft{get;set;}
		[JsonConverter(typeof(DoubleOneDecimalConverter))]
		public double? reversalTime{get;set;}
	}

}