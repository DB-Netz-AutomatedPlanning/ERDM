

using System.Xml.Serialization;

namespace ERDM.Tier_3
{
	public enum ETCSmarkerFunction
	{
		[XmlEnum("ETCS Stop Marker")]
		ETCSstopMarker,
        [XmlEnum("ETCS Location Marker")]
        ETCSlocationMarker,
	}
}