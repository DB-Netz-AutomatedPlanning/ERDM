using ERDM.Tier_2;
using ERDM.Tier_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERDM
{
    public class Tier2
    {
        public List<AreaOfControl>? AreaOfControl { get; set; }
        public List<TrackEdgePoint>? TrackEdgePoint { get; set; }
        public List<DirectedTrackEdgePoint>? DirectedTrackEdgePoint { get; set; }
        public List<TrackEdgeSection>? TrackEdgeSection { get; set; }
        public List<DirectedTrackEdgeSection>? DirectedTrackEdgeSection { get; set; }
        public List<TrackArea>? TrackArea { get; set; }
        public List<ContiguousTrackArea>? ContiguousTrackArea { get; set; }
        public List<LinearContiguousTrackArea>? LinearContiguousTrackArea { get; set; }
    }
}
