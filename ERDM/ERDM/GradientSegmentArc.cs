
using ERDM.Tier_3;
using ERDM;
using System.Text.Json.Serialization;

namespace ERDM.Tier_3
{
	public class GradientSegmentArc : GradientSegment
	{
        [JsonConverter(typeof(DoubleThreeDecimalsConverter))]
        public double? radius{get;set;}
        [JsonConverter(typeof(DoubleThreeDecimalsConverter))]
        public double? initialGradientAngle{get;set;}
	}

}