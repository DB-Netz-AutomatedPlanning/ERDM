

using System.Xml.Serialization;

namespace ERDM.Tier_3
{
	public enum AdjacentAtoTsContactInfoDirection
	{
		[XmlEnum("No Contact info follows")]
		NoContactInfoFollows,
        [XmlEnum("ATO-TS contact info for nominal direction follows")]
        Nominal,
        [XmlEnum("ATO-TS contact info for reverse direction follow")]
        Reverse,
	}
}