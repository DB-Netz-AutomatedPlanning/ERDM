

using System.Xml.Serialization;

namespace ERDM.Tier_3
{
	public enum StaticDirectionConfiguration
	{
		None,
		[XmlEnum("Start to End")]
		StartToEnd,
        [XmlEnum("End to Start")]
        EndToStart,
		Both,
	}
}