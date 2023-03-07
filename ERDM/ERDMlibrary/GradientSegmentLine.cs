
using ERDM.Tier_3;
using ERDM;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace ERDM.Tier_3
{
	public class GradientSegmentLine : GradientSegment
	{
        [XmlIgnore]
        [JsonIgnore]
        private double? _gradient;
        public double? gradient { get => _gradient.HasValue ? (double)Math.Truncate((decimal)_gradient * 1000) / 1000 : null; set => _gradient = value; }
    }

}