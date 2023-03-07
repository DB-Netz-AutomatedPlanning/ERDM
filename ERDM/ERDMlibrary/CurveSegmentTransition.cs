
using ERDM.Tier_0;
using ERDM.Tier_3;
using ERDM;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace ERDM.Tier_3
{
	public class CurveSegmentTransition : CurveSegment
	{
        [XmlIgnore]
        [JsonIgnore]
        private double? _clothoidParameter, _initialArcLength, _azimuthAngle;
        public string? hasCenterAtGeoCoordinates { get;set;}
        [JsonConverter(typeof(DoubleThreeDecimalsConverter))]
        public double? clothoidParameter { get => _clothoidParameter.HasValue ? (double)Math.Truncate((decimal)_clothoidParameter * 1000) / 1000 : null; set => _clothoidParameter = value; }
        [JsonConverter(typeof(DoubleThreeDecimalsConverter))]
        public double? initialArcLength { get => _initialArcLength.HasValue ? (double)Math.Truncate((decimal)_initialArcLength * 1000) / 1000 : null; set => _initialArcLength = value; }
        [JsonConverter(typeof(DoubleThreeDecimalsConverter))]
        public double? azimuthAngle { get => _azimuthAngle.HasValue ? (double)Math.Truncate((decimal)_azimuthAngle * 1000) / 1000 : null; set => _azimuthAngle = value; }
    }

}