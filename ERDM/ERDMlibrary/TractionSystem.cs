
using ERDM.Tier_2;
using ERDM;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ERDM.Tier_3
{
	public class TractionSystem : Tier3
	{
		[JsonConverter(typeof(TractionSystemTypeJsonConverter))]
		public TractionSystemType? voltageCategory{get;set;}
		public List<string>? appliesToTrackEdgeSection{get;set;}
		public int? countryIdentifier{get;set;}
	}

}