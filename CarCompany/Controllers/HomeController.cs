using CarCompany.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarCompany.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to CarCompany";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact us for more information.";

            return View();
        }

        public ActionResult Cars()
        {
            ViewBag.Message = "View our cars";
            List<Car> cars = null;
            using (var context = new DataContext.DataContext())
            {
                cars = context.Cars.ToList();
            }

            return View(cars);
        }
    }
}
