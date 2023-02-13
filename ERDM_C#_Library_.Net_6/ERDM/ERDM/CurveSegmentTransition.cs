
using ERDM.Tier_0;
using ERDM.Tier_3;
using ERDM;
using System.Text.Json.Serialization;

namespace ERDM.Tier_3
{
	public class CurveSegmentTransition : CurveSegment
	{
		public string? hasCenterAtGeoCoordinates { get;set;}
        [JsonConverter(typeof(DoubleThreeDecimalsConverter))]
        public double? clothoidParameter{get;set;}
        [JsonConverter(typeof(DoubleThreeDecimalsConverter))]
        public double? initialArcLength{get;set;}
        [JsonConverter(typeof(DoubleThreeDecimalsConverter))]
        public double? azimuthAngle{get;set;}
	}

}