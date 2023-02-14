
using ERDM.Tier_1;
using ERDM;
using System.Text.Json.Serialization;

namespace ERDM.Tier_2
{
	public class TrackEdgeSection : Base2
	{
		public string? hasStartTrackEdgePoint { get;set;}
		public string? hasEndTrackEdgePoint { get;set;}
        [JsonConverter(typeof(DoubleThreeDecimalsConverter))]
        public double? length{get;set;}
        [JsonConverter(typeof(DoubleThreeDecimalsConverter))]
        public double? lateralOffset{get;set;}
        [JsonConverter(typeof(DoubleThreeDecimalsConverter))]
        public double? verticalOffset{get;set;}

		public string? isPartOfTrackEdge { get;set;}
	}

}