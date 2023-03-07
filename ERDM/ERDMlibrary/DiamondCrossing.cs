
using ERDM.Tier_2;
using ERDM.Tier_3;
using ERDM;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace ERDM.Tier_3
{
	public class DiamondCrossing : Tier3
	{
        [XmlIgnore]
        [JsonIgnore]
        private double? _reversalTime;
        public string? appliesToTrackArea{ get;set;}
		public string? appliesToAllocationSection{ get;set;}
		public string? appliesToDpsGroup{get;set;}
		public List<string>? appliesToDpsRight{get;set;}
		public List<string>? appliesToDpsLeft{get;set;}

        public double? reversalTime { get => _reversalTime.HasValue ? (double)Math.Truncate((decimal)_reversalTime * 10) / 10 : null; set => _reversalTime = value; }
    }

}