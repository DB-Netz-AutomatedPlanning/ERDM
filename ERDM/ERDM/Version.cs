
using Newtonsoft.Json.Converters;
using ERDM;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ERDM.Tier_0
{
	public class Version : Tier0
	{
		public int? version{get;set;}
		public DateTimeOffset? created{get;set;}
		public DateTimeOffset? modified{get;set;}
		public DateTimeOffset? deleted{get;set;}
		[JsonConverter(typeof(LevelOfMaturityJsonConverter))]
        public LevelOfMaturity? status{get;set;}
		public List<string>? successor{get;set;}
		public string? hashValue{get;set;}
	}

}