

using ERDM;
using ERDM;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace ERDM.Tier_1
{
	public class TrackEdge : Tier1
	{
        [XmlIgnore]
        [JsonIgnore]
        private double? _length;
        public double? length { get => _length.HasValue ? (double)Math.Truncate((decimal)_length * 1000) / 1000 : null; set => _length = value; }
        [JsonConverter(typeof(TrackEdgeGaugeJsonListConverter))]
		public List<TrackEdgeGauge?>? gauge{get;set;}
		public string? hasStartTrackNode { get;set;}
		public string? hasEndTrackNode { get;set;}
	}

}