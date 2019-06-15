using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FullMVCProject.Controllers
{
    public class ShopController : Controller
    {
        // GET: Shop
        public string Index()
        {
            return "Shop Index";
        }

        public string Product()
        {
            return "Product page";
            //return "Product Id = " + id.ToString();
        }
    }
}