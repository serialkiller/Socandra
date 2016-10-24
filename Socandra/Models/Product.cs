using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Socandra.Models
{
    public class Product
    {
        [Required]
        public int ProductId { get; set;}

        [Required]
        [StringLength(255)]
        public String ProductName { get; set;}

        [Required]
        public ProductType ProductType { get; set; }

        
        public DateTime ChangedAt { get; set; }


    }

    public class ProductType
    {
        public int ProductTypeId { get; set; }
        [Required]
        public String ProductTypeName { get; set; }

    }

}