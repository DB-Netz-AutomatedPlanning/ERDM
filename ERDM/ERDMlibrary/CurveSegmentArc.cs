

using ERDM.Tier_0;
using ERDM.Tier_3;
using ERDM;
using ERDM;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace ERDM.Tier_3
{
	public class CurveSegmentArc : CurveSegment
	{
        [XmlIgnore]
        [JsonIgnore]
        private double? _radius, _initialArcLength;
        public double? radius { get => _radius.HasValue ? (double)Math.Truncate((decimal)_radius * 1000) / 1000 : null; set => _radius = value; }
        public double? initialArcLength { get => _initialArcLength.HasValue ? (double)Math.Truncate((decimal)_initialArcLength * 1000) / 1000 : null; set => _initialArcLength = value; }
        public string? hasCenterAtGeoCoordinates { get;set;}
	}

}