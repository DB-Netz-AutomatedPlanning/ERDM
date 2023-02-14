
using ERDM.Tier_0;
using ERDM.Tier_2;
using ERDM.Tier_3;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ERDM.Tier_3
{
    [JsonDerivedType(typeof(CurveSegmentLine), typeDiscriminator: "CurveSegmentLine")]
    [JsonDerivedType(typeof(CurveSegmentArc), typeDiscriminator: "CurveSegmentArc")]
    [JsonDerivedType(typeof(CurveSegmentTransition), typeDiscriminator: "CurveSegmentTransition")]
    public abstract class CurveSegment : Base3
	{
		public List<string>? appliesToTrackEdgeSection{get;set;}
	}

}