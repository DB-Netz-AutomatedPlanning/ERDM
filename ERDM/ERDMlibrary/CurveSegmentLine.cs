
using ERDM.Tier_3;
using ERDM;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace ERDM.Tier_3
{
    public class CurveSegmentLine : CurveSegment
    {
        [XmlIgnore]
        [JsonIgnore]
        private double? _azimuthAngle;
        public double? azimuthAngle { get => _azimuthAngle.HasValue ? (double)Math.Truncate((decimal)_azimuthAngle * 1000) / 1000 : null; set => _azimuthAngle = value; }

    }
}