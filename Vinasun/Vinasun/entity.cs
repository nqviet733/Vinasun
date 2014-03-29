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
    
    public partial class Entity
    {
        public Entity()
        {
            this.Checkers = new HashSet<Entity>();
            this.Taxis = new HashSet<Taxi>();
        }
    
        public int id { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public Nullable<System.DateTime> birthday { get; set; }
        public bool gender { get; set; }
        public string email { get; set; }
        public string businessPhone { get; set; }
        public Nullable<System.DateTime> dateJoin { get; set; }
    
        public virtual UserRole UserRole { get; set; }
        public virtual ICollection<Entity> Checkers { get; set; }
        public virtual Entity Leader { get; set; }
        public virtual Group Group { get; set; }
        public virtual ICollection<Taxi> Taxis { get; set; }
    }
}
