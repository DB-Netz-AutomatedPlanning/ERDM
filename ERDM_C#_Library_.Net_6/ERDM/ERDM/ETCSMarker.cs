
using ERDM.Tier_3;
using System.Text.Json.Serialization;

namespace ERDM.Tier_3
{
	public class ETCSMarker : Sign
	{
        [JsonConverter(typeof(ETCSmarkerFunctionJsonConverter))]
        public ETCSmarkerFunction? function{get;set;}
	}

}