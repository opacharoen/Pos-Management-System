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
    
    public partial class CNWarehouse
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CNWarehouse()
        {
            this.CNWarehouseDetails = new HashSet<CNWarehouseDetails>();
        }
    
        public string Code { get; set; }
        public int FKWasteReason { get; set; }
        public bool Enable { get; set; }
        public string Description { get; set; }
        public System.DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public System.DateTime UpdateDate { get; set; }
        public string UpdateBy { get; set; }
        public decimal TotalQty { get; set; }
        public decimal TotalQtyUnit { get; set; }
        public int FKVendor { get; set; }
        public System.DateTime DocDate { get; set; }
        public string DocRefer { get; set; }
        public decimal TotalUnVat { get; set; }
        public decimal TotalBeforeVat { get; set; }
        public decimal TotalVat { get; set; }
        public decimal TotalBalance { get; set; }
        public Nullable<System.DateTime> ConfirmCNDate { get; set; }
        public string ConfirmCNBy { get; set; }
    
        public virtual Vendor Vendor { get; set; }
        public virtual WasteReason WasteReason { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CNWarehouseDetails> CNWarehouseDetails { get; set; }
    }
}