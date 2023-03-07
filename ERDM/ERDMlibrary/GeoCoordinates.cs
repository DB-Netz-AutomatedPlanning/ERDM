

using ERDM;
using Newtonsoft.Json.Linq;
using System;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace ERDM.Tier_0
{
	public class GeoCoordinates : Tier0
	{
        [XmlIgnore]
        [JsonIgnore]
        private double? _xCoordinate;
        [XmlIgnore]
        [JsonIgnore]
        private double? _yCoordinate;
        [XmlIgnore]
        [JsonIgnore]
        private double? _zCoordinate;
        public string? name {get;set;}
        public double? xCoordinate { get => _xCoordinate.HasValue? (double)Math.Truncate((decimal)_xCoordinate * 1000000) / 1000000 : null; set => _xCoordinate = value; }
        public double? yCoordinate { get => _yCoordinate.HasValue ? (double)Math.Truncate((decimal)_yCoordinate * 1000000) / 1000000 : null; set => _yCoordinate = value; }
        public double? zCoordinate { get => _zCoordinate.HasValue ? (double)Math.Truncate((decimal)_zCoordinate * 1000000) / 1000000 : null; set => _zCoordinate = value; }
    }

}