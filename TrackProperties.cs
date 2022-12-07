using RCA_Model.Tier_1;
using RCA_Model.Tier_2;
namespace RCA_Model.Tier_3
{
	public class TrackProperties : Base, Tier3
	{
		public LineCategoryClassification lineCategory;
		public LoadingGaugeClassification loadingGauge;
		public List<TrackEdgeSection> appliesToTrackEdgeSection;
	}

}
