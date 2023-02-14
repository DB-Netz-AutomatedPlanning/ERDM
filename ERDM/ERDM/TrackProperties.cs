
using ERDM.Tier_2;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ERDM.Tier_3
{
	public class TrackProperties : Base3
	{
		public LineCategoryClassification? lineCategory{get;set;}
		[JsonConverter(typeof(LoadingGaugeClassificationJsonConverter))]
		public LoadingGaugeClassification? loadingGauge{get;set;}
		public List<string>? appliesToTrackEdgeSection{get;set;}
	}

}