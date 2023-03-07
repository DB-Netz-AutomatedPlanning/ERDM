
using ERDM.Tier_3;
using ERDM.Tier_2;
using System.Collections.Generic;

namespace ERDM.Tier_3
{
    public class AreaOfControl : TrackArea
    {
        public string? areaOfControlIdentifier{get;set;}
	    public List<string>? adjacentAreaOfControl{get;set;}
    }
}