//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Vinasun
{
    using System;
    using System.Collections.Generic;
    
    public partial class taxi_type
    {
        public taxi_type()
        {
            this.taxis = new HashSet<taxi>();
            this.driver_percentanges = new HashSet<driver_percentange>();
        }
    
        public short id { get; set; }
        public string description { get; set; }
        public string symbol { get; set; }
    
        public virtual ICollection<taxi> taxis { get; set; }
        public virtual ICollection<driver_percentange> driver_percentanges { get; set; }
    }
}
