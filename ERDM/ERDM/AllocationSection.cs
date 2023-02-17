
using ERDM.Tier_2;
using System.Collections.Generic;

namespace ERDM.Tier_3
{
	public class AllocationSection : Tier3
	{
		public string? appliesToTrackArea{get;set;}
		public List<string>? isDependentOnAllocationSection{get;set;}
	}

}