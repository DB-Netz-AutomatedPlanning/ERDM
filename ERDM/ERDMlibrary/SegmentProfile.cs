
using ERDM.Tier_2;
using ERDM;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace ERDM.Tier_3
{
	public class SegmentProfile : Tier3
	{
        [XmlIgnore]
        [JsonIgnore]
        private double? _distanceToEoAOffset;
        public string? segmentProfileIdentifier{get;set;}
		public int? countryIdentifier{get;set;}
		public string? appliesToTrackEdgeSection{get;set;}
        public double? distanceToEoAOffset { get => _distanceToEoAOffset.HasValue ? (double)Math.Truncate((decimal)_distanceToEoAOffset * 1000) / 1000 : null; set => _distanceToEoAOffset = value; }
    

        [XmlElement("utcTimeOffset")]
        [JsonConverter(typeof(CustomTime))]
        public CustomTime? utcTimeOffset{get;set;}
        public string? isWithinAreaOfControl { get;set;}
		public int? adjacentAtoTsCountryIdentifier{get;set;}
		public string? adjacentAtoTsIdentifier{get;set;}
		public string? adjacentSegmentProfileIdentifier{get;set;}
		public int? adjacentSegmentProfileCountryIdentifier{ get;set;}
		public List<string>? hasSpeedProfile{get;set;}
		public List<string>? hasGradientSegment{get;set;}
		public List<string>? hasCurveSegment{get;set;}
		public List<string>? hasTimingPoint{get;set;}
		public List<string>? hasBaliseGroup{get;set;}
		public List<string>? hasBalise{get;set;}
		[JsonConverter(typeof(AdjacentAtoTsContactInfoDirectionJsonConverter))]
		public AdjacentAtoTsContactInfoDirection? adjacentAtoTsContactInfoDirection{get;set;}
		public List<string>? hasPermittedBrakingDistance{get;set;}
		public List<string>? hasCurrentLimitaion{get;set;}
		public List<string>? hasTractionSystem{get;set;}
		public List<string>? hasTrackCondition{get;set;}
		public List<string>? hasLevelCrossing{get;set;}
		public List<string>? hasTunnel{get;set;}
		public List<string>? hasPlatformEdge{get;set;}
	}

}