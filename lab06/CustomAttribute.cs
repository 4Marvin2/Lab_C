using System;

namespace lab06
{
    [AttributeUsage(AttributeTargets.Property,
    AllowMultiple = false,
    Inherited = false)
    ]
    public class CustomAttribute : Attribute
    {
        public CustomAttribute() { }
        public CustomAttribute(string mDescription)
        {
            Description = mDescription;
        }
        public string Description { get; set; }
    }
}
