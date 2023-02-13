
using ERDM.Tier_3;
namespace ERDM.Tier_3
{
	public class SimplePoint : Point
	{
		public string? appliesToDpsGroup{get;set;}
		public string? appliesToDpsRight{get;set;}
		public string? appliesToDpsLeft{get;set;}
		public int? speedRightRoute{get;set;}
		public int? speedLeftRoute{get;set;}
		public bool? hasTrailDetection{get;set;}
	}

}