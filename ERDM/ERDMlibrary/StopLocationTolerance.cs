

using System.Xml.Serialization;

namespace ERDM.Tier_3
{
	public enum StopLocationTolerance
	{
		[XmlEnum("10cm")]
		_10cm,
        [XmlEnum("20cm")]
        _20cm,
        [XmlEnum("30cm")]
        _30cm,
        [XmlEnum("40cm")]
        _40cm,
        [XmlEnum("50cm")]
        _50cm,
        [XmlEnum("1m")]
        _1m,
        [XmlEnum("1.5m")]
        _1_5m,
        [XmlEnum("2m")]
        _2m,
        [XmlEnum("2.5m")]
        _2_5m,
        [XmlEnum("3m")]
        _3m,
        [XmlEnum("5m")]
        _5m,
        [XmlEnum("7.5m")]
        _7_5m,
        [XmlEnum("10m")]
        _10m,
        [XmlEnum("15m")]
        _15m,
        [XmlEnum("20m")]
        _20m,
        [XmlEnum("25m")]
        _25m,
        [XmlEnum("30m")]
        _30m,
        [XmlEnum("50m")]
        _50m,
        [XmlEnum("75m")]
        _75m,
        [XmlEnum("100m")]
        _100m,
      

    }
}