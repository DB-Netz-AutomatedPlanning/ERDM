

using System.Xml.Serialization;

namespace ERDM.Tier_3
{
	public enum TrackConditionType
	{
		[XmlEnum("Powerless Section, lower pantograph")]
		PowerlessSection_LowerPantograph,
        [XmlEnum("Powerless Section, switch off Main power switch")]
        PowerlessSection_SwitchOffMainPowerSwitch,
        [XmlEnum("Air tightness")]
        AirTightness,
        [XmlEnum("Switch off eddy current brake for service brake")]
        SoundHorn,
        [XmlEnum("Switch off eddy current brake for emergency brake")]
        NonStoppingArea,
        [XmlEnum("Switch off magnetic shoe brake")]
        TunnelStoppingArea,
        [XmlEnum("Sound horn")]
        BigMetalMasses__,
        [XmlEnum("Non stopping area")]
        RadioHole__,
        [XmlEnum("Tunnel stopping area")]
        SwitchOffRegenerativeBrake,
        [XmlEnum("Big metal masses, ignore onboard integrity check alarms of balise transmission")]
        SwitchOffEddyCurrentBrake_serviceBrake,
        [XmlEnum("Radio hole, Stop supervision of the loss of safe Radio connection")]
        SwitchOffEddyCurrentBrake_emergencyBrake,
        [XmlEnum("Switch off regenerative brake")]
        SwitchOffEddyMagneticShoeBrake,
	}
}