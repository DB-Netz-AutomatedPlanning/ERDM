
using System.Xml.Serialization;

namespace ERDM.Tier_0
{
    public enum LevelOfMaturity
	{
		
		engineered,
		validated,
        [XmlEnum("ready for test")]
        readyForTest,
        [XmlEnum("ready for operation")]
        readyForOperation,
        preloaded,
        activated,
	}
}