using Headset.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Headset.Controllers
{
    public class HomeController : Controller
    {
        public readonly Test _t;

        public HomeController()
        {
            _t = new Test();
        }
        public ActionResult Index()
        {
            //var x = _t.getPorduct();

            return View(/*x*/);
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
    }
}