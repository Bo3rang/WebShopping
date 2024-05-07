using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebShopping.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Admin/Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(string acc, string pass)
        {
            bool isAuthentic = (acc != null && pass != null && acc.Equals("admin") && pass.Equals ("1"));
            if (isAuthentic) return View("~/Areas/Admin/Views/DashBoard/Index.cshtml");
            return View();
        }
    }
}