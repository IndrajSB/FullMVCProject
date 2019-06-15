using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FullMVCProject_FilmStation.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }




        public string FilmReview(string Type, string Colour)
        {
            //return "Film Review Page: Id = " + id.ToString();
            return String.Format("Film Review Page = {0}, Colour={1}", Type, Colour);
        }
    }
}