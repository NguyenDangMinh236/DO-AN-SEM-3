//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SaleECS.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Web;

    public partial class Product
    {
        public int Id { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public string Code { get; set; }
        [Required]
        public string Image { get; set; }
        public decimal Price { get; set; }
        public System.DateTime CreateDate { get; set; } = DateTime.Now;
        [Required]
        public string Description { get; set; }
        public bool Status { get; set; }
        public int ClientId { get; set; }
    
        public virtual Client Client { get; set; }
        //public HttpPostedFileBase ImageFile { get; set; }
    }
}