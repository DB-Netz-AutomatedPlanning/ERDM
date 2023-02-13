
using ERDM.Tier_3;
using ERDM;
using System.Text.Json.Serialization;

namespace ERDM.Tier_3
{
	public class OverheadLineEquipmentZone : Zone
	{
        [JsonConverter(typeof(DoubleThreeDecimalsConverter))]
        public double? verticalTrackAreaOffset{get;set;}
	}

}