
using ERDM.Tier_2;
using ERDM.Tier_3;
using System.Text.Json.Serialization;

namespace ERDM.Tier_3
{
	public class DriveProtectionSection : Base3
	{
		public string? appliesToTrackEdgeSection{ get;set;}
        [JsonConverter(typeof(StaticDirectionConfigurationJsonConverter))]
        public StaticDirectionConfiguration? flankProtectionDirection{get;set;}
        public MinimalDefaultDrivabilityState? minimalDrivability{get;set;}
	}

}