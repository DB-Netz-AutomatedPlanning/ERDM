
using Newtonsoft.Json.Converters;
using ERDM;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace ERDM.Tier_0
{
	public class Version : Tier0
	{
        public int? version{get;set;}
        [XmlElement("created")]
        [JsonConverter(typeof(CustomDateTime))]
        public CustomDateTime? created{get;set;}
        [XmlElement("modified")]
        [JsonConverter(typeof(CustomDateTime))]
        public CustomDateTime? modified{get;set;}
        [XmlElement("deleted")]
        [JsonConverter(typeof(CustomDateTime))]
        public CustomDateTime? deleted{get;set;}

        [JsonConverter(typeof(LevelOfMaturityJsonConverter))]
        public LevelOfMaturity? status{get;set;}
    
        public List<string>? successor{get;set;}
  
        public string? hashValue{get;set;}
	}

}