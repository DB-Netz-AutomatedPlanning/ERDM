
using ERDM.Tier_3;
using System.Text.Json.Serialization;

namespace ERDM.Tier_3
{
	public class AxleLoadSpeedProfile : SpeedProfile
	{
		public AxleLoadCategory? axleLoadCategory{get;set;}
	}

}