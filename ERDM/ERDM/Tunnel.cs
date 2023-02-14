
using ERDM.Tier_3;
using ERDM;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ERDM.Tier_3
{
	public class Tunnel : Base3
	{
		public List<string>? consistsOfTunnelTube{get;set;}
		[JsonConverter(typeof(TunnelTypeJsonConverter))]
		public TunnelType? tunnelType{get;set;}
	}

}