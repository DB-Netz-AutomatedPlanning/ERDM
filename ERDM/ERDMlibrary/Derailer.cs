
using ERDM.Tier_2;
using ERDM.Tier_3;
using ERDM;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace ERDM.Tier_3
{
	public class Derailer : Tier3
	{
		[XmlIgnore]
		[JsonIgnore]
		private double? _reversalTime;

        public string? appliesToTrackEdgePoint { get;set;}
		public string? appliesToDpsGroup{get;set;}
		public string? appliesToDps{get;set;}
        public double? reversalTime { get => _reversalTime.HasValue ? (double)Math.Truncate((decimal)_reversalTime * 10) / 10 : null; set => _reversalTime = value; }
    }

}