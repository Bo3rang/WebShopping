using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebShopping.Models;

namespace WebShopping.Controllers
{
    public class ProductDetailController : Controller
    {
        // GET: ProductDetail
        public ActionResult Index(string maSP)
        {
            WebshoppingConnect wb = new WebshoppingConnect();
            sanPham a = wb.sanPhams.Where(x => x.maSP.Equals(maSP)).First<sanPham>();           
            ViewData["Xem"] = a;
            return View();
        }
    }
}