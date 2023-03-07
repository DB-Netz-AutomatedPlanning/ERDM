
using ERDM.Tier_3;
using ERDM;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace ERDM.Tier_3
{
	public class OverheadLineEquipmentZone : Zone
	{
        [XmlIgnore]
        [JsonIgnore]
        private double? _verticalTrackAreaOffset;
        public double? verticalTrackAreaOffset { get => _verticalTrackAreaOffset.HasValue ? (double)Math.Truncate((decimal)_verticalTrackAreaOffset * 1000) / 1000 : null; set => _verticalTrackAreaOffset = value; }
    }

}