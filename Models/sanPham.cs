//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebShopping.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class sanPham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public sanPham()
        {
            this.chiTietDHs = new HashSet<chiTietDH>();
        }
    
        public string maSP { get; set; }
        public int maLoai { get; set; }
        public string tenSP { get; set; }
        public string ndTomTat { get; set; }
        public System.DateTime ngayDangSP { get; set; }
        public string tkThanhVien { get; set; }
        public int giaBan { get; set; }
        public string dvt { get; set; }
        public string khuyenMai { get; set; }
        public int soLuong { get; set; }
        public string hinhDD { get; set; }
        public string ndSanPham { get; set; }
        public bool duocHT { get; set; }
        public Nullable<int> soLanQT { get; set; }
        public Nullable<int> soLanGD { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<chiTietDH> chiTietDHs { get; set; }
        public virtual loaiSP loaiSP { get; set; }
        public virtual taiKhoan taiKhoan { get; set; }
    }
}
