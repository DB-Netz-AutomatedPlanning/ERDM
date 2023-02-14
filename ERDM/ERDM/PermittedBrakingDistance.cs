
using ERDM.Tier_2;
using ERDM;
using ERDM;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ERDM.Tier_3
{
	public class PermittedBrakingDistance : Base3
	{
        [JsonConverter(typeof(DoubleThreeDecimalsConverter))]
        public double? permittedBrakingDistance{get;set;}
		public List<string>? appliesToTrackEdgeSection{get;set;}
        [JsonConverter(typeof(BrakeTypeJsonConverter))]
        public BrakeType? brakeType{get;set;}
	}

}