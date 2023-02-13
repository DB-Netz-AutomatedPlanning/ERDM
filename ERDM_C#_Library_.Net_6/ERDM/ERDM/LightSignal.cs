
using ERDM.Tier_3;
using ERDM;
using System.Text.Json.Serialization;

namespace ERDM.Tier_3
{
	public class LightSignal : Signal
	{
        [JsonConverter(typeof(LightSignalTypeJsonConverter))]
        public LightSignalType? type{get;set;}
	}

}