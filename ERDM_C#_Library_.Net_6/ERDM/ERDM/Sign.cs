
using ERDM.Tier_3;
using System.Text.Json.Serialization;

namespace ERDM.Tier_3
{
    [JsonDerivedType(typeof(ETCSMarker), typeDiscriminator: "ETCSMarker")]
    [JsonDerivedType(typeof(StopLocation), typeDiscriminator: "StopLocation")]
    public abstract class Sign : Signal
	{
	}

}