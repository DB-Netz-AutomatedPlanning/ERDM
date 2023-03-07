

using ERDM.Tier_3;
using ERDM;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace ERDM.Tier_0
{
	public class OperationalPoint : Tier0
	{
   
        public string? name{get;set;}
       
        public string? identifier{get;set;}
      
        [JsonConverter(typeof(TypeOfTheOperationalPointJsonConverter))]
		public TypeOfTheOperationalPoint? type{get;set;}
       
        public List<string>? lineReference{get;set;}
    
        public string? isLocatedAtGeoCoordinates { get;set;}
       
        public List<string>? isWithinAreaOfControl{get;set;}
	}

}