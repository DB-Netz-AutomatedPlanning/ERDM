
using ERDM.Tier_3;
using System.Collections.Generic;

namespace ERDM.Tier_3
{
	public class BaliseGroup : Tier3
	{
		public int? countryIdentifier{get;set;}
		public int? baliseGroupIdentifier{get;set;}
		public List<string>? consistsOfBalise{get;set;}
		public int? locationAccuracy{get;set;}
	}

}