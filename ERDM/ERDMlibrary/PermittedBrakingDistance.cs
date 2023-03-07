
using ERDM.Tier_2;
using ERDM;
using ERDM;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace ERDM.Tier_3
{
	public class PermittedBrakingDistance : Tier3
	{
        [XmlIgnore]
        [JsonIgnore]
        private double? _permittedBrakingDistance;
        public double? permittedBrakingDistance { get => _permittedBrakingDistance.HasValue ? (double)Math.Truncate((decimal)_permittedBrakingDistance * 1000) / 1000 : null; set => _permittedBrakingDistance = value; }
        public List<string>? appliesToTrackEdgeSection{get;set;}
        [JsonConverter(typeof(BrakeTypeJsonConverter))]
        public BrakeType? brakeType{get;set;}
	}

}