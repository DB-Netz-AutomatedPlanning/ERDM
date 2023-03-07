

using System.Xml.Serialization;

namespace ERDM.Tier_3
{
	public enum OtherSpecificSSP
	{
		[XmlEnum("Specific Freight Train P")]
		SpecificFreightTrainP,
        [XmlEnum("Specific Freight Train G")]
        SpecificFreightTrainG,
        [XmlEnum("Specific Passenger Train")]
        SpecificPassengerTrain,
	}
}