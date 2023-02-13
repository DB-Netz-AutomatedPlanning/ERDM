

using ERDM.Tier_0;
using ERDM.Tier_3;
using ERDM;
using ERDM;
using System.Text.Json.Serialization;

namespace ERDM.Tier_3
{
	public class CurveSegmentArc : CurveSegment
	{
        [JsonConverter(typeof(DoubleThreeDecimalsConverter))]
        public double? radius{get;set;}
        [JsonConverter(typeof(DoubleThreeDecimalsConverter))]
        public double? initialArcLength{get;set;}
		public string? hasCenterAtGeoCoordinates { get;set;}
	}

}