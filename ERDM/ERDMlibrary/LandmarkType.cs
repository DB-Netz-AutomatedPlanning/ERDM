using System.Xml.Serialization;

namespace ERDM.Tier_3
{

	public enum LandmarkType
	{
		[XmlEnum("Catenary Post")]
		CatenaryPost,
		Building,
        [XmlEnum("Sign Post")]
        SignPost,
        [XmlEnum("Signal Post")]
        SignalPost,
        [XmlEnum("Radio Post")]
        RadioPost,
        [XmlEnum("Mileage Stone")]
        MileageStone,
        [XmlEnum("Hectometre Sign")]
        HectometreSign,
        [XmlEnum("Other Post")]
        OtherPost,
	}
}