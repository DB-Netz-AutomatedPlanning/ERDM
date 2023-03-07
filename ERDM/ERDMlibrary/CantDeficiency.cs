

using System.Xml.Serialization;

namespace ERDM.Tier_3
{
	public enum CantDeficiency
	{
		[XmlEnum("80mm")]
		_80,
        [XmlEnum("100mm")]
        _100,
        [XmlEnum("130mm")]
        _130,
        [XmlEnum("150mm")]
        _150,
        [XmlEnum("165mm")]
        _165,
        [XmlEnum("180mm")]
        _180,
        [XmlEnum("210mm")]
        _210,
        [XmlEnum("225mm")]
        _225,
        [XmlEnum("245mm")]
        _245,
        [XmlEnum("275mm")]
        _275,
        [XmlEnum("300mm")]
        _300,
	}
}