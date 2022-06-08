using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO; //Add additional directive for functionality

namespace U20654172_HW03.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        //code to post the file names while mapping them to a specific path
        [HttpPost]
        public ActionResult Index(HttpPostedFileBase Files)
        {
            var fileName = Path.GetFileName(Files.FileName);

            var path = Path.Combine(Server.MapPath("~/Media"), fileName);
            Files.SaveAs(path);

            return RedirectToAction("Index");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult File()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

    }
}