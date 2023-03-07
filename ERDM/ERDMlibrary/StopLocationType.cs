

using System.Xml.Serialization;

namespace ERDM.Tier_3
{
	public enum StopLocationType
	{
		[XmlEnum("Generic stop location (valid for all type of trains)")]
		Generic,
        [XmlEnum("Stop location based on train length (200m, 300m, ...)")]
        BasedOnNumberOfWagons,
        [XmlEnum("Stop location based on the number of wagons (1, 2, 3, ...)")]
        BasedOnNumberOfAxles,
        [XmlEnum("Stop location based on number of axles")]
        BasedOnConfigurationOfTrainUnits,
        [XmlEnum("Stop location based on the configuration of train units (short train, half train, full train)")]
        BasedOnTrainLength,
	}
}