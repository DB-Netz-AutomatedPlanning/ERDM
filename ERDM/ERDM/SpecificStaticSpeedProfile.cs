
using ERDM.Tier_3;
using System.Text.Json.Serialization;

namespace ERDM.Tier_3
{
	public class SpecificStaticSpeedProfile : SpeedProfile
	{
        [JsonConverter(typeof(SpecificStaticSpeedProfileTypeJsonConverter))]
        public SpecificStaticSpeedProfileType? specificStaticSpeedProfileType{get;set;}
        [JsonConverter(typeof(OtherSpecificSSPJsonConverter))]
        public OtherSpecificSSP? otherSpecificStaticSpeedProfileCategory{get;set;}
        [JsonConverter(typeof(CantDeficiencyJsonConverter))]
        public CantDeficiency? cantDeficiencyCategory{get;set;}
	}

}