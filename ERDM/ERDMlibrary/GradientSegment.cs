
using ERDM.Tier_2;
using ERDM.Tier_3;
using ERDM;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace ERDM.Tier_3
{
    [JsonDerivedType(typeof(GradientSegmentLine), typeDiscriminator: "GradientSegmentLine")]
    [JsonDerivedType(typeof(GradientSegmentArc), typeDiscriminator: "GradientSegmentArc")]
    public abstract class GradientSegment : Tier3
	{
        [XmlIgnore]
        [JsonIgnore]
        public double? _startAltitude;

        public double? startAltitude { get => _startAltitude.HasValue ? (double)Math.Truncate((decimal)_startAltitude * 1000) / 1000 : null; set => _startAltitude = value; }
        public List<string>? appliesToTrackEdgeSection{get;set;}
	}

}