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
    
    public partial class taiKhoan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public taiKhoan()
        {
            this.baiViets = new HashSet<baiViet>();
            this.sanPhams = new HashSet<sanPham>();
        }
    
        public string tkThanhVien { get; set; }
        public string matKhau { get; set; }
        public System.DateTime ngayCap { get; set; }
        public string hoTV { get; set; }
        public string tenTV { get; set; }
        public bool gioiTinh { get; set; }
        public System.DateTime ngaySinh { get; set; }
        public string noiSinh { get; set; }
        public string soDT { get; set; }
        public string eMail { get; set; }
        public string dcLienLac { get; set; }
        public bool duocSD { get; set; }
        public string ghiChu { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<baiViet> baiViets { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sanPham> sanPhams { get; set; }
    }
}
