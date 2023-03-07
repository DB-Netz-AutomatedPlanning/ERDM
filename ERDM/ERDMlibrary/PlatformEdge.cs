
using ERDM.Tier_2;
using ERDM;
using ERDM;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace ERDM.Tier_3
{
	public class PlatformEdge : Tier3
	{
        [XmlIgnore]
        [JsonIgnore]
        private double? _length;
        public string? appliesToLinearContiguousTrackArea { get;set;}
        public PassengersBoardAndAlign? situatedSide{get;set;}
        public double? length { get => _length.HasValue ? (double)Math.Truncate((decimal)_length * 1000) / 1000 : null; set => _length = value; }
        public List<string>? hasStopLocation{get;set;}
		public string? hasAccessViaTracks{get;set;}
	}

}