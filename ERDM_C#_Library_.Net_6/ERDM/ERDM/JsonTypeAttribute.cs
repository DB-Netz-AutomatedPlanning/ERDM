using System;

namespace ERDM.Tier_0
{
    internal class JsonTypeAttribute : Attribute
    {
        public string TypeName { get; set; }
        public JsonTypeAttribute(string typeName)
        {
            TypeName = typeName;
        }
    }
}