
using ERDM.Tier_1;
using ERDM.Tier_2;
using ERDM.Tier_3;
using ERDM;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace ERDM.Tier_3
{
    [JsonDerivedType(typeof(SimplePoint), typeDiscriminator: "SimplePoint")]
    [JsonDerivedType(typeof(SlipCrossing), typeDiscriminator: "SlipCrossing")]
    public abstract class Point : Tier3
	{
        [XmlIgnore]
        [JsonIgnore]
        private double? _reversalTime;
        public List<string>? appliesToTrackNode{get;set;}
		public string? appliesToTrackArea{get;set;}
		public string? appliesToAllocationSection { get;set;}
        [JsonConverter(typeof(DoubleOneDecimalConverter))]
        public double? reversalTime { get => _reversalTime.HasValue ? (double)Math.Truncate((decimal)_reversalTime * 10) / 10 : null; set => _reversalTime = value; }
    }

}