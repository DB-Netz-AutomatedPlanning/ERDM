
using ERDM.Tier_3;
using ERDM;
using System.Text.Json.Serialization;

namespace ERDM.Tier_3
{
	public class GradientSegmentLine : GradientSegment
	{
        [JsonConverter(typeof(DoubleThreeDecimalsConverter))]
        public double? gradient{get;set;}
	}

}