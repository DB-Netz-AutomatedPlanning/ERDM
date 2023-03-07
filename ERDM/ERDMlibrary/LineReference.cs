

using ERDM;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace ERDM.Tier_0
{
	public class LineReference : Tier0
	{
        [XmlIgnore]
        [JsonIgnore]
        private double? _lineKilometre;
        public double? lineKilometre { get => _lineKilometre.HasValue ? (double)Math.Truncate((decimal)_lineKilometre * 1000) / 1000 : null; set => _lineKilometre = value; }

        public string? lineNumber{get;set;}
       
        public string? trackNumber{get;set;}
	}

}