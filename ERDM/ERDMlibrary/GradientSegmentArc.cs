
using ERDM.Tier_3;
using ERDM;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace ERDM.Tier_3
{
	public class GradientSegmentArc : GradientSegment
	{
        [XmlIgnore]
        [JsonIgnore]
        private double? _radius, _initialGradientAngle;
        public double? radius { get => _radius.HasValue ? (double)Math.Truncate((decimal)_radius * 1000) / 1000 : null; set => _radius = value; }
        public double? initialGradientAngle { get => _initialGradientAngle.HasValue ? (double)Math.Truncate((decimal)_initialGradientAngle * 1000) / 1000 : null; set => _initialGradientAngle = value; }
    }

}