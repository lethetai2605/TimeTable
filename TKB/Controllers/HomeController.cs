using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TKB.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Nhóm 12";

            return View();
        }
        public ActionResult Logout()
        {
            Session["USER_SESSION"] = null;
            return RedirectToAction("Index");
        }

    }
}