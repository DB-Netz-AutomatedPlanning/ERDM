using ERDM.Tier_0;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERDM
{
    public class Tier0
    {
        public List<Tier_0.Version>? Version { get; set; }
        public List<MapData>? MapData { get; set; }
        public List<Release>? Release { get; set; }
        public List<GeoCoordinates>? GeoCoordinates { get; set; }
        public List<LineReference>? LineReference { get; set; }
        public List<OperationalPoint>? OperationalPoint { get; set; }
    }
}
