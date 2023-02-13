
using ERDM.Tier_3;
using ERDM;
using System.Text.Json.Serialization;

namespace ERDM.Tier_3
{
	public class CurveSegmentLine : CurveSegment
	{
        [JsonConverter(typeof(DoubleThreeDecimalsConverter))]
        public double? azimuthAngle{get;set;}
	}

}