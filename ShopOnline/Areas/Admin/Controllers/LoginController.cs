using Models;
using ShopOnline.Areas.Admin.Code;
using ShopOnline.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace ShopOnline.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Admin/Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(LoginModel mode)
        {
            var result = new AccountModel().Login(mode.UserName, mode.Password);
            if(result && ModelState.IsValid)
            {
                SessionHelper.SetSession(new UserSesstion() { UserName = mode.UserName });
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("", "Tên đăng nhập hoặc mật khẩu không đúng.");
            }
            return View(mode);
        }
    }
}