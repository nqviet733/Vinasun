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
    
    public partial class province_income
    {
        public long id { get; set; }
        public System.DateTime created { get; set; }
        public int trip_income { get; set; }
        public int over_income { get; set; }
        public int price_income { get; set; }
    
        public virtual taxi taxi { get; set; }
    }
}
