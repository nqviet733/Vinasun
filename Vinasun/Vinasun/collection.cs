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
    
    public partial class collection
    {
        public long id { get; set; }
        public string taxi_type { get; set; }
        public int sum_money { get; set; }
        public string driver { get; set; }
        public int sum_km { get; set; }
        public int sum_cuoc { get; set; }
        public System.DateTime created { get; set; }
    
        public virtual group group { get; set; }
    }
}
