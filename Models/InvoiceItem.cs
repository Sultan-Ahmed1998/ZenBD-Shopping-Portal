//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ZenBD_API.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class InvoiceItem
    {
        public int InvoiceNumber { get; set; }
        public int ProductId { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public double TotalPrice { get; set; }
        public int ItemId { get; set; }
    
        public Invoice Invoice { get; set; }
        public Product Product { get; set; }
    }
}
