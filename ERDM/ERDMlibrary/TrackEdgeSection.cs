
using ERDM.Tier_1;
using ERDM;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace ERDM.Tier_2
{
	public class TrackEdgeSection : Base2
	{
        [XmlIgnore]
        [JsonIgnore]
        private double? _length, _lateralOffset, _verticalOffset;
        public string? hasStartTrackEdgePoint { get;set;}
		public string? hasEndTrackEdgePoint { get;set;}
        public double? length { get => _length.HasValue ? (double)Math.Truncate((decimal)_length * 1000) / 1000 : null; set => _length = value; }
        public double? lateralOffset { get => _lateralOffset.HasValue ? (double)Math.Truncate((decimal)_lateralOffset * 1000) / 1000 : null; set => _lateralOffset = value; }
        public double? verticalOffset { get => _verticalOffset.HasValue ? (double)Math.Truncate((decimal)_verticalOffset * 1000) / 1000 : null; set => _verticalOffset = value; }

        public string? isPartOfTrackEdge { get;set;}
	}

}