

using System.Xml.Serialization;

namespace ERDM.Tier_3
{
	public enum TrainEndApplicability
	{
		[XmlEnum("Train length delay on validity end point of profile element.")]
		TrainLengthDelay,
        [XmlEnum("No Train length delay on validity end point of profile element.")]
        NoTrainLengthDelay,
	}
}