

using System.Xml.Serialization;

namespace ERDM.Tier_3
{
	public enum TractionSystemType
	{
		[XmlEnum("Line not fitted with any traction system")]
		LineNotFittedWithAnyTractionSystem,
        [XmlEnum("DC 600V")]
        DC600V,
        [XmlEnum("DC 600V")]
        DC650V,
        [XmlEnum("DC 750V")]
        DC750V,
        [XmlEnum("DC 850V")]
        DC850V,
        [XmlEnum("DC 1.5kV")]
        DC1_5kV,
        [XmlEnum("DC 3kV")]
        DC3kV,
        [XmlEnum("AC 25kV 50Hz")]
        AC15kV16_7Hz,
        [XmlEnum("other")]
        AC25kV_50Hz,
        other,
	}
}