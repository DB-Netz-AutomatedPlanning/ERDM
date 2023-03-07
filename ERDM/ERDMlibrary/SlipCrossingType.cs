

using System.Xml.Serialization;

namespace ERDM.Tier_3
{
	public enum SlipCrossingType
	{
		[XmlEnum("Single Slip")]
		SingleSlip,
        [XmlEnum("Double Slip")]
        DoubleSlip,
	}
}