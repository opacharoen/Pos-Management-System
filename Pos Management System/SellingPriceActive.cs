//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Pos_Management_System
{
    using System;
    using System.Collections.Generic;
    
    public partial class SellingPriceActive
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int FKPriceSchedule { get; set; }
        public int FKProduct { get; set; }
        public decimal GetCurrentPrice { get; set; }
        public decimal SpecialPrice { get; set; }
        public int FKProductDtl { get; set; }
        public decimal GetCurrentPriceDtl { get; set; }
        public decimal SpecialPriceDtl { get; set; }
        public string Code { get; set; }
        public string ProName { get; set; }
        public bool IsStop { get; set; }
    }
}