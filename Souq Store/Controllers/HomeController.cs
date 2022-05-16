using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Souq_Store.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Souq_Store.Controllers
{
    public class HomeController : Controller
    {
        SouqStoreContext db = new SouqStoreContext();
        public IActionResult Index()
        {
            
            var Cats = db.Categories.ToList();
            ViewBag.Products = db.Products.ToList();
            return View(Cats);
        }

        public IActionResult Category()
        {
           
            var Cats = db.Categories.ToList();
            return View(Cats);
        }
        public IActionResult Products(int Id)
        {
            var Products = db.Products.Where( x => x.CatId == Id).ToList();
            return View(Products);
        }
        public IActionResult Cart()
        {

            return View();
        }
        public IActionResult ContactUs ()
        {

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
