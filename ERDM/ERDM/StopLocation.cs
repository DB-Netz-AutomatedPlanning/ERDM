
using ERDM.Tier_3;
using System.Text.Json.Serialization;

namespace ERDM.Tier_3
{
	public class StopLocation : Sign
	{
		[JsonConverter(typeof(StopLocationTypeJsonConverter))]
		public StopLocationType? function{get;set;}
		public string? value{get;set;}
	}

}