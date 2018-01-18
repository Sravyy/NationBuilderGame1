using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NationBuilderGame.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NationBuilderGame.Controllers
{
    public class HomeController : Controller
    {
        private NationBuilderContext db = new NationBuilderContext();

        // GET: /<controller>/
        public IActionResult Index()
        {
            Console.WriteLine("Hello we have entered index");
            return View();
        }

        [HttpPost]
        public IActionResult NewCountry(string countryName, int governmentId, int economyId)
        {
            Console.WriteLine("Hello we have reached New Country");
            Nation newNation = new Nation(countryName, governmentId, economyId);
            db.Nations.Add(newNation);
            db.SaveChanges();
            return Json(newNation);
        }

    }
}
