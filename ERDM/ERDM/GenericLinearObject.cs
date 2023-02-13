
using ERDM.Tier_2;
using ERDM.Tier_3;
using System.Text.Json.Serialization;

namespace ERDM.Tier_3
{
	public class GenericLinearObject : GenericSpatialObject
	{
		public string? appliesToTrackArea { get;set;}
	
        public GenericLinearObjectType? type{get;set;}
	}

}