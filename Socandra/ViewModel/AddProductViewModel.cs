using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Socandra.Models;

namespace Socandra.ViewModel
{
    public class AddProductViewModel
    {
         public String ProductName { get; set;}

        public int ProductType { get; set; }

        public IEnumerable<ProductType> ProductTypes { get; set; }
    }
}