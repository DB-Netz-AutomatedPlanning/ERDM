
namespace RCA_Model.Tier_0
{
	public class Release : Tier0
	{
		public string id;
		public string name;
		public Version refersToMapDataVersion;
		public List<MapDataObject> insertsMapDataObjects;
		public List<MapDataObject> modifiesMapDataObjects;
		public List<MapDataObject> deletesMapDataObjects;
	}

}
