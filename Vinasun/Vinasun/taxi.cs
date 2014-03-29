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
    
    public partial class Taxi
    {
        public Taxi()
        {
            this.SumaryNumbers = new HashSet<SumaryNumber>();
            this.DayIncomes = new HashSet<DayIncome>();
            this.ProvineIncomes = new HashSet<ProvineIncome>();
            this.SubtractionIncomes = new HashSet<SubtractionIncome>();
            this.RepairCosts = new HashSet<RepairCost>();
            this.TripChecks = new HashSet<TripCheck>();
            this.ReasonNoIncomes = new HashSet<ReasonNoIncome>();
        }
    
        public int id { get; set; }
        public string taxiNo { get; set; }
        public Nullable<System.DateTime> dateJoin { get; set; }
        public string model { get; set; }
    
        public virtual TaxiType TaxiType { get; set; }
        public virtual ICollection<SumaryNumber> SumaryNumbers { get; set; }
        public virtual ICollection<DayIncome> DayIncomes { get; set; }
        public virtual ICollection<ProvineIncome> ProvineIncomes { get; set; }
        public virtual ICollection<SubtractionIncome> SubtractionIncomes { get; set; }
        public virtual ICollection<RepairCost> RepairCosts { get; set; }
        public virtual ICollection<TripCheck> TripChecks { get; set; }
        public virtual ICollection<ReasonNoIncome> ReasonNoIncomes { get; set; }
        public virtual Entity Entity { get; set; }
        public virtual Group Group { get; set; }
    }
}
