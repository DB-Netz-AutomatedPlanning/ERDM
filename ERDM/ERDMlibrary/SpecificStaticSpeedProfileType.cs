

using System.Xml.Serialization;

namespace ERDM.Tier_3
{
	public enum SpecificStaticSpeedProfileType
	{
		[XmlEnum("Cant Deficiency")]
		CantDeficiency,
        [XmlEnum("Other Specific SSP")]
        OtherSpecificSSP,
	}
}