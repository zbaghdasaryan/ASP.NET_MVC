using _03_ModelMetadata.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _03_ModelMetadata.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Customer customer = new Customer()
            {
                Id = 1,
                FirstName = "Poghos",
                LastName = "Poghosyan",
                IsApproved = true,
                Description = "text....text...text",
                RegistrationDate = DateTime.Now,
                Foo = 123
            };
            return View(customer);
        }
    }
}