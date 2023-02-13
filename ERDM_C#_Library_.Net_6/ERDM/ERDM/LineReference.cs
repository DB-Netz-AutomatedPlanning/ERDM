

using ERDM;
using System.Text.Json.Serialization;

namespace ERDM.Tier_0
{
	public class LineReference : Tier0
	{
        [JsonConverter(typeof(DoubleThreeDecimalsConverter))]
        public double? lineKilometre{get;set;}
		public string? lineNumber{get;set;}
		public string? trackNumber{get;set;}
	}

}