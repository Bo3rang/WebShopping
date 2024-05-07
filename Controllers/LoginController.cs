using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebShopping.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(string acc, string pass)
        {
            bool isAuthentic = (acc != null && pass != null && acc.Equals("admin") && pass.Equals("1"));
            if (isAuthentic)
                return RedirectToAction("Index", "DashBoard", new { Area = "Admin" });
            return View();
        }
    }
}