
using ERDM.Tier_2;
using ERDM.Tier_3;
using ERDM;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ERDM.Tier_3
{
    [JsonDerivedType(typeof(GradientSegmentLine), typeDiscriminator: "GradientSegmentLine")]
    [JsonDerivedType(typeof(GradientSegmentArc), typeDiscriminator: "GradientSegmentArc")]
    public abstract class GradientSegment : Base3
	{
        [JsonConverter(typeof(DoubleThreeDecimalsConverter))]
        public double? startAltitude{get;set;}
		public List<string>? appliesToTrackEdgeSection{get;set;}
	}

}