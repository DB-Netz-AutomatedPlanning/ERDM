
using ERDM.Tier_1;
using ERDM.Tier_2;
using ERDM.Tier_3;
using ERDM;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ERDM.Tier_3
{
    [JsonDerivedType(typeof(SimplePoint), typeDiscriminator: "SimplePoint")]
    [JsonDerivedType(typeof(SlipCrossing), typeDiscriminator: "SlipCrossing")]
    public abstract class Point : Base3
	{
		public List<string>? appliesToTrackNode{get;set;}
		public string? appliesToTrackArea{get;set;}
		public string? appliesToAllocationSection { get;set;}
        [JsonConverter(typeof(DoubleOneDecimalConverter))]
        public double? reversalTime{get;set;}
	}

}