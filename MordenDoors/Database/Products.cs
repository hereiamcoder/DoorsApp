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
    
    public partial class Products
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public Nullable<int> UnitsOfMeasureID { get; set; }
        public decimal Rate { get; set; }
        public bool IsActive { get; set; }
        public string QbId { get; set; }
        public string SKU { get; set; }
        public string productImage { get; set; }
        public Nullable<bool> Resync { get; set; }
        public Nullable<decimal> Weight { get; set; }
        public Nullable<decimal> MinimumSquareFeet { get; set; }
    
        public virtual Categories Categories { get; set; }
        public virtual UnitsOfMeasure UnitsOfMeasure { get; set; }
        public virtual UnitsOfMeasure UnitsOfMeasure1 { get; set; }
    }
}
