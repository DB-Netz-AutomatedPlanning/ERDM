using ERDM.Tier_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERDM
{
    public class Tier1
    {
        public List<TrackNode>? TrackNode { get; set; }
        public List<TrackEdge>? TrackEdge { get; set; }
        public List<TrackNavigability>? TrackNavigability { get; set; }
    }
}
