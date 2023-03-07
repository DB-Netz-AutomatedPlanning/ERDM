
using ERDM.Tier_2;
using ERDM.Tier_3;
using ERDM;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace ERDM.Tier_3
{
    [JsonDerivedType(typeof(TrackZone), typeDiscriminator: "TrackZone")]
    [JsonDerivedType(typeof(ProtectionZone), typeDiscriminator: "ProtectionZone")]
    public class Zone : Tier3
	{
        [XmlIgnore]
        [JsonIgnore]
        private double? _length, _width, _height;
        public string? appliesToTrackArea { get;set;}
		[JsonConverter(typeof(DoubleThreeDecimalsConverter))]
		public double? length { get => _length.HasValue ? (double)Math.Truncate((decimal)_length * 1000) / 1000 : null; set => _length = value; }
        [JsonConverter(typeof(DoubleThreeDecimalsConverter))]
        public double? width { get => _width.HasValue ? (double)Math.Truncate((decimal)_width * 1000) / 1000 : null; set => _width = value; }
        [JsonConverter(typeof(DoubleThreeDecimalsConverter))]
        public double? height { get => _height.HasValue ? (double)Math.Truncate((decimal)_height * 1000) / 1000 : null; set => _height = value; }
    }

}