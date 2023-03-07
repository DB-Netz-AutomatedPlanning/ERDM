

using System.Xml.Serialization;

namespace ERDM.Tier_3
{
	public enum LightSignalType
	{
		[XmlEnum("Main signal")]
		MainSignal,
        [XmlEnum("Shunting signal")]
        ShuntingSignal,
	}
}