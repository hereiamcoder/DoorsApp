//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MordenDoors.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrderItems
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OrderItems()
        {
            this.OrderSubItems = new HashSet<OrderSubItems>();
        }
    
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public decimal Price { get; set; }
        public Nullable<decimal> Height { get; set; }
        public Nullable<decimal> Width { get; set; }
        public decimal Quantity { get; set; }
        public string Comments { get; set; }
        public Nullable<int> CurrentStageId { get; set; }
        public string AssigedTo { get; set; }
        public int ItemStatus { get; set; }
        public Nullable<decimal> TotalPrice { get; set; }
        public Nullable<decimal> TotalWeight { get; set; }
        public string UnitType { get; set; }
        public string Unit { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderSubItems> OrderSubItems { get; set; }
    }
}
