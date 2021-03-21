using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TKB.Common;
using TKB.Dao;
using TKB.Models;

namespace TKB.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login(Account account)
        {
            if(ModelState.IsValid)
            {
                var dao = new AccountDao();
                var result = dao.Login(account.UserName, Encryptor.MD5Hash(account.PassWord));
                if (result)
                {
                    var user = dao.GetAccountByUserName(account.UserName);
                    var userSession = new UserLogin();
                    userSession.UserName = user.UserName;
                    userSession.UserID = user.ID;

                    Session.Add("USER_SESSION", userSession);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Tài khoản hoặc mật khẩu không chính xác.");
                }
            }
            return View("Index");
        }
    }
}