

using System.Collections.Generic;
using System.Xml.Serialization;

namespace ERDM.Tier_0
{
	public class Release : Tier0
	{
      
        public string? name{get;set;}
    
        public string? refersToMapDataVersion { get;set;}
      
        public List<string>? insertsMapDataObjects{get;set;}
       
        public List<string>? modifiesMapDataObjects{get;set;}
       
        public List<string>? deletesMapDataObjects{get;set;}
	}

}