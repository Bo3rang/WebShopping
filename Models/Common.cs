using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebShopping.Models
{
    public class Common
    {
        /// <summary>
        /// Hàm lấy ra danh sách tất cả các sản phẩm.
        /// </summary>
        /// <returns></returns>
        public static List<sanPham> getProduct()
        {
            List<sanPham> l = new List<sanPham>();
            DbContext a = new DbContext("name = WebshoppingConnect");
            l = a.Set<sanPham>().ToList<sanPham>();
            return l;
        }
        /// <summary>
        /// Hàm lấy ra danh sách các loại sản phẩm.
        /// </summary>
        /// <returns></returns>
        public static List<loaiSP> getCategory()
        {
            return new DbContext("name = WebShoppingConnect").Set<loaiSP>().ToList<loaiSP>();
        }
    }
}