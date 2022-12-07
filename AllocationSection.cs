using RCA_Model.Tier_1;
using RCA_Model.Tier_2;
namespace RCA_Model.Tier_3
{
	public class AllocationSection : Base, Tier3
	{
		public LinearContiguousTrackArea appliesToTrackArea;
		public List<AllocationSection> isDependentOnAllocationSection;
	}

}
