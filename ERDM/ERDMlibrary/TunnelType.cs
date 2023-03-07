

using System.Xml.Serialization;

namespace ERDM.Tier_3
{
	public enum TunnelType
	{
		[XmlEnum("Single Track Tunnel")]
		SingleTrackTunnel,
        [XmlEnum("Double Track Tunnel")]
        DoubleTrackTunnel,
        [XmlEnum("Wide-cross Section Tunnel")]
        Wide_crossSectionTunnel,
	}
}