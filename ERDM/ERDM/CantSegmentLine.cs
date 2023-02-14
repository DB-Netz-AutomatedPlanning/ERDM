
using ERDM.Tier_2;
using ERDM.Tier_3;
using System.Collections.Generic;

namespace ERDM.Tier_3
{
	public class CantSegmentLine : Base3
	{
		public List<string>? appliesToTrackEdgeSection{get;set;}
		public int? startCant{get;set;}
		public int? endCant{get;set;}
	}

}