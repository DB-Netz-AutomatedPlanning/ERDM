

using System.Xml.Serialization;

namespace ERDM.Tier_1
{
	public enum TrackNodeType
	{
		Point,
		[XmlEnum("System Border")]
		SystemBorder,
        [XmlEnum("End of Track")]
        EndOfTrack,
	}
}