
using ERDM.Tier_0;
using ERDM.Tier_1;
using ERDM;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace ERDM.Tier_2
{
	public class TrackEdgePoint : Base2
	{
        [XmlIgnore]
        [JsonIgnore]
        private double? _offset, _lateralOffset, _verticalOffset;

        public string? isPositionedOnTrackEdge { get;set;}
        public double? offset { get => _offset.HasValue ? (double)Math.Truncate((decimal)_offset * 1000) / 1000 : null; set => _offset = value; }
        public string? isLocatedAtGeoCoordinates { get;set;}
        public double? lateralOffset { get => _lateralOffset.HasValue ? (double)Math.Truncate((decimal)_lateralOffset * 1000) / 1000 : null; set => _lateralOffset = value; }
        public double? verticalOffset { get => _verticalOffset.HasValue ? (double)Math.Truncate((decimal)_verticalOffset * 1000) / 1000 : null; set => _verticalOffset = value; }
        public string? hasOperationalPoint { get;set;}
		public List<string>? lineReference{get;set;}
	}

}