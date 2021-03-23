using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TKB.Common;

namespace TKB.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            var session = (UserLogin)Session["USER_SESSION"];
            ViewBag.UserName = session.UserName;
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