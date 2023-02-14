
using ERDM.Tier_2;
using ERDM.Tier_3;
using ERDM;
using System.Text.Json.Serialization;

namespace ERDM.Tier_3
{
    [JsonDerivedType(typeof(TrackZone), typeDiscriminator: "TrackZone")]
    [JsonDerivedType(typeof(ProtectionZone), typeDiscriminator: "ProtectionZone")]
    public class Zone : Base3
	{
		public string? appliesToTrackArea { get;set;}
		[JsonConverter(typeof(DoubleThreeDecimalsConverter))]
		public double? length{get;set;}
        [JsonConverter(typeof(DoubleThreeDecimalsConverter))]
        public double? width{get;set;}
        [JsonConverter(typeof(DoubleThreeDecimalsConverter))]
        public double? height{get;set;}
	}

}