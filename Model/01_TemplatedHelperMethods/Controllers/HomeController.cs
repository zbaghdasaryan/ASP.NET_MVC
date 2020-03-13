using _01_TemplatedHelperMethods.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _01_TemplatedHelperMethods.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Product product = new Product()
            { 
            Id=1,
            Name="Test Product",
            IsTangible=false,
            };
            
            return View(product);
        }

       
    }
}