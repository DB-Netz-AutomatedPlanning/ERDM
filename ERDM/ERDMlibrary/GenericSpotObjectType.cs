

using System.Xml.Serialization;

namespace ERDM.Tier_3
{
	public enum GenericSpotObjectType
	{
		[XmlEnum("Catenary Post")]
		CatenaryPost,
        [XmlEnum("Sign Post")]
        SignPost,
        [XmlEnum("Signal Post")]
        SignalPost,
        [XmlEnum("Radio Post")]
        RadioPost,
        [XmlEnum("Mileage Stone")]
        MileageStone,
        [XmlEnum("Communication")]
        HectometreSign,
        [XmlEnum("Camera Post")]
        CameraPost,
        [XmlEnum("Communication")]
        Communication,
        [XmlEnum("Post")]
        Post,
        [XmlEnum("End of Track")]
        EndOfTrack,
        [XmlEnum("Other Post")]
        OtherPost,
	}
}