
using ERDM.Tier_0;
using ERDM.Tier_1;
using ERDM;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ERDM.Tier_2
{
	public class TrackEdgePoint : Base2
	{
		public string? isPositionedOnTrackEdge { get;set;}
        [JsonConverter(typeof(DoubleThreeDecimalsConverter))]
        public double? offset{get;set;}
		public string? isLocatedAtGeoCoordinates { get;set;}
        [JsonConverter(typeof(DoubleThreeDecimalsConverter))]
        public double? lateralOffset{get;set;}
        [JsonConverter(typeof(DoubleThreeDecimalsConverter))]
        public double? verticalOffset{get;set;}
		public string? hasOperationalPoint { get;set;}
		public List<string>? lineReference{get;set;}
	}

}