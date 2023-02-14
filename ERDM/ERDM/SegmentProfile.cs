
using ERDM.Tier_2;
using ERDM;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ERDM.Tier_3
{
	public class SegmentProfile : Base3
	{
		public string? segmentProfileIdentifier{get;set;}
		public int? countryIdentifier{get;set;}
		public string? appliesToTrackEdgeSection{get;set;}
        [JsonConverter(typeof(DoubleThreeDecimalsConverter))]
        public double? distanceToEoAOffset{get;set;}
        [JsonConverter(typeof(TimeConverter))]
        public TimeSpan? utcTimeOffset{get;set;}
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