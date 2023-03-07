

using System.Xml.Serialization;

namespace ERDM.Tier_0
{
	public enum TypeOfTheOperationalPoint
	{
		station,
        [XmlEnum("station")]
        smallStation,
        [XmlEnum("small station")]
        passengerTerminal,
        [XmlEnum("passenger terminal")]
        passengerStop,
        [XmlEnum("freight terminal")]
        freightTerminal,
        depot,
        [XmlEnum("train technical services")]
        trainTechnicalServices,
        junction,
        point,
        [XmlEnum("shunting yard")]
        shuntingYard,
        [XmlEnum("technical change")]
        technicalChange,
        [XmlEnum("private siding")]
        privateSiding,
        [XmlEnum("border point")]
        borderPoint,
        [XmlEnum("domestic border point")]
        domesticBorderPoint,
	}
}