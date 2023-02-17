
using ERDM.Tier_2;
using System.Collections.Generic;

namespace ERDM.Tier_3
{
	public class CurrentLimitation : Tier3
	{
		public int? maximumCurrent{get;set;}
		public List<string>? appliesToTrackEdgeSection{get;set;}
	}

}