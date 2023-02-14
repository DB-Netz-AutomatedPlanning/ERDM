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
        [JsonPropertyName("$type")]
        public string? type { get; } = "ERDM";
        public List<Base0>? Tier0 { get; set; }
        public List<Base1>? Tier1 { get; set; }
        public List<Base2>? Tier2 { get; set; }
        public List<Base3>? Tier3 { get; set; }
    }
}
