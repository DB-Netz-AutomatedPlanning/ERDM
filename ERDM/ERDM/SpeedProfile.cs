
using ERDM.Tier_2;
using ERDM.Tier_3;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ERDM.Tier_3
{
    [JsonDerivedType(typeof(StaticSpeedProfile), typeDiscriminator: "StaticSpeedProfile")]
    [JsonDerivedType(typeof(SpecificStaticSpeedProfile), typeDiscriminator: "SpecificStaticSpeedProfile")]
    [JsonDerivedType(typeof(AxleLoadSpeedProfile), typeDiscriminator: "AxleLoadSpeedProfile")]
    public abstract class SpeedProfile : Tier3
	{
		public List<string>? appliesToTrackEdgeSection{get;set;}
		public int? speed{get;set;}
        [JsonConverter(typeof(TrainEndApplicabilityJsonConverter))]
        public TrainEndApplicability? trainEndApplicability{get;set;}
	}

}