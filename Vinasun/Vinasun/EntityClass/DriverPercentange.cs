//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Vinasun.EntityClass
{
    using System;
    using System.Collections.Generic;
    
    public partial class DriverPercentange
    {
        public short id { get; set; }
        public int percent { get; set; }
    
        public virtual TaxiType TaxiType { get; set; }
        public virtual PriceRange PriceRange { get; set; }
    }
}
