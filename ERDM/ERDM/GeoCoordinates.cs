

using ERDM;
using System.Text.Json.Serialization;

namespace ERDM.Tier_0
{
	public class GeoCoordinates : Base0
	{
		
		public string? name{get;set;}
        [JsonConverter(typeof(DoubleSixDecimalsConverter))]
        public double? xCoordinate{get;set;}
        [JsonConverter(typeof(DoubleSixDecimalsConverter))]
        public double? yCoordinate{get;set;}
        [JsonConverter(typeof(DoubleSixDecimalsConverter))]
        public double? zCoordinate{get;set;}
	}

}