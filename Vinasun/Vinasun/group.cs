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
    
    public partial class group
    {
        public group()
        {
            this.Collections = new HashSet<Collection>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
    
        public virtual leader leader { get; set; }
        public virtual ICollection<Collection> Collections { get; set; }
    }
}
