
using ERDM.Tier_2;
using ERDM;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ERDM.Tier_3
{
	public class TrackCondition : Tier3
	{
        [JsonConverter(typeof(TrackConditionTypeJsonConverter))]
        public TrackConditionType? condition{get;set;}
		public List<string>? appliesToTrackEdgeSection{get;set;}
	}

}