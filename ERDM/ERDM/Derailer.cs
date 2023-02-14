
using ERDM.Tier_2;
using ERDM.Tier_3;
using ERDM;
using System.Text.Json.Serialization;

namespace ERDM.Tier_3
{
	public class Derailer : Base3
	{
		public string? appliesToTrackEdgePoint { get;set;}
		public string? appliesToDpsGroup{get;set;}
		public string? appliesToDps{get;set;}
        [JsonConverter(typeof(DoubleOneDecimalConverter))]
        public double? reversalTime{get;set;}
	}

}