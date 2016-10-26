using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Socandra.Models;
using Socandra.ViewModel;

namespace Socandra.Controllers
{
    public class ProductController : Controller
    {

        private ApplicationDbContext _context;

        public ProductController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: ProductType
        public ActionResult CreateProduct()
        {
            var viewModel = new AddProductViewModel()
            {
                ProductTypes = _context.ProductTypes.ToList()
            };
            return View(viewModel);
        }
    }
}