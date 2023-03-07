using ERDM.Tier_1;
using ERDM.Tier_2;
using ERDM.Tier_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERDM
{
    public class Tier2Container
    {
        public List<AreaOfControl>? AreaOfControl { get; set; }
        public List<TrackEdgePoint>? TrackEdgePoint { get; set; }
        public List<DirectedTrackEdgePoint>? DirectedTrackEdgePoint { get; set; }
        public List<TrackEdgeSection>? TrackEdgeSection { get; set; }
        public List<DirectedTrackEdgeSection>? DirectedTrackEdgeSection { get; set; }
        public List<TrackArea>? TrackArea { get; set; }
        public List<ContiguousTrackArea>? ContiguousTrackArea { get; set; }
        public List<LinearContiguousTrackArea>? LinearContiguousTrackArea { get; set; }

        public Tier2Container()
        {
            AreaOfControl = new List<AreaOfControl>();
            TrackEdgePoint = new List<TrackEdgePoint>();
            DirectedTrackEdgePoint = new List<DirectedTrackEdgePoint>();
            TrackEdgeSection = new List<TrackEdgeSection>();
            DirectedTrackEdgeSection = new List<DirectedTrackEdgeSection>();
            TrackArea = new List<TrackArea>();
            ContiguousTrackArea = new List<ContiguousTrackArea>();
            LinearContiguousTrackArea = new List<LinearContiguousTrackArea>();
        }
    }
}
