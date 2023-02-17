using ERDM.Tier_0;
using ERDM.Tier_1;
using ERDM.Tier_2;
using ERDM.Tier_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ERDM
{
    public class ERDMmodel
    {
        [JsonPropertyName("Tier0")]
        public Tier0Container Tier0 { get; set; }
        [JsonPropertyName("Tier1")]
        public Tier1Container Tier1 { get; set; }
        [JsonPropertyName("Tier2")]
        public Tier2Container Tier2 { get; set; }
        [JsonPropertyName("Tier3")]
        public Tier3Container Tier3 { get; set; }

        public ERDMmodel()
        {
            Tier0 = new Tier0Container();
            Tier1 = new Tier1Container();
            Tier2 = new Tier2Container();
            Tier3 = new Tier3Container();
        }
    }
}
