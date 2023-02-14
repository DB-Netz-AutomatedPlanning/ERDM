
using ERDM.Tier_2;
using ERDM.Tier_3;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ERDM.Tier_3
{
    [JsonDerivedType(typeof(LightSignal), typeDiscriminator: "LightSignal")]
    [JsonDerivedType(typeof(ETCSMarker), typeDiscriminator: "ETCSMarker")]
    [JsonDerivedType(typeof(StopLocation), typeDiscriminator: "StopLocation")]
    public abstract class Signal : Base3
	{
		public List<string>? appliesToTrackEdgePoint{get;set;}
	}

}