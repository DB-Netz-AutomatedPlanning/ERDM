using System;
namespace RCA_Model.Tier_0
{
	public class Version : Tier0
	{
		public int version;
		public DateTime created;
		public DateTime modified;
		public DateTime deleted;
		public LevelOfMaturity status;
		public List<string> successor;
		public List<string> hashValue;
	}

}
