
using ERDM.Tier_2;
using ERDM.Tier_3;
using ERDM;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace ERDM.Tier_3
{
	public class TunnelTube : Tier3
	{
        [XmlIgnore]
        [JsonIgnore]
        private double? _length;

        public List<string>? appliesToTrackArea{get;set;}
		public string? hasStartTunnelPortal { get;set;}
		public string? hasEndTunnelPortal { get;set;}
        public double? length { get => _length.HasValue ? (double)Math.Truncate((decimal)_length * 1000) / 1000 : null; set => _length = value; }
    }

}