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
    
    public partial class PORcvDetails
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool Enable { get; set; }
        public System.DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public System.DateTime UpdateDate { get; set; }
        public string UpdateBy { get; set; }
        public int FKPORcv { get; set; }
        public int FKProductDtl { get; set; }
        public int SequenceNumber { get; set; }
        public decimal RcvQuantity { get; set; }
        public decimal CurrentCost { get; set; }
        public decimal NewCost { get; set; }
        public string DiscountKey { get; set; }
        public decimal DiscountBath { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal GiftQty { get; set; }
        public decimal GiftOnPo { get; set; }
        public decimal QtyOnPO { get; set; }
        public int FKPoDetails { get; set; }
        public bool IsComplete { get; set; }
        public int FKPOHeader { get; set; }
        public decimal RcvComplete { get; set; }
    
        public virtual PORcv PORcv { get; set; }
        public virtual ProductDetails ProductDetails { get; set; }
    }
}