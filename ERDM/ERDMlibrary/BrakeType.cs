

using System.Xml.Serialization;

namespace ERDM.Tier_3
{
	public enum BrakeType
	{
		[XmlEnum("service brake")]
		ServiceBrake,
        [XmlEnum("emergency brake")]
        EmergencyBrake,
	}
}