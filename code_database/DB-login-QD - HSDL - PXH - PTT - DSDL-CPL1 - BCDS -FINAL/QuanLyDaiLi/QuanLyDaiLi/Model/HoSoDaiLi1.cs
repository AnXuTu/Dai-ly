//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyDaiLi.Model
{
    using QuanLyDaiLi.ViewModel;
    using System;
    using System.Collections.Generic;
    
    public partial class HoSoDaiLi1:BaseViewModel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HoSoDaiLi1()
        {
            this.PhieuThuTien1 = new HashSet<PhieuThuTien1>();
            this.PhieuXuatHang1 = new HashSet<PhieuXuatHang1>();
        }

        public string Id { get; set; }
        private string _TenDaiLy;
        public string TenDaiLy { get => _TenDaiLy; set { _TenDaiLy = value; OnPropertyChanged(); } }
        private int _IdLoaiDaiLy;
        public int IdLoaiDaiLy { get => _IdLoaiDaiLy; set { _IdLoaiDaiLy = value; OnPropertyChanged(); } }
        private string _Phone;
        public string Phone { get => _Phone; set { _Phone = value; OnPropertyChanged(); } }
        private string _Address;
        public string Address { get => _Address; set { _Address = value; OnPropertyChanged(); } }
        private int _IdQuan;
        public int IdQuan { get => _IdQuan; set { _IdQuan = value; OnPropertyChanged(); } }
        private System.DateTime _NgayTiepNhan;
        public System.DateTime NgayTiepNhan { get => _NgayTiepNhan; set { _NgayTiepNhan = value; OnPropertyChanged(); } }

        private QuyDinh1 _QuyDinh1;
        public virtual QuyDinh1 QuyDinh1 { get=>_QuyDinh1; set { _QuyDinh1 = value;OnPropertyChanged(); } }
        private Quan _Quan;
        public virtual Quan Quan { get=>_Quan; set { _Quan = value;OnPropertyChanged(); } }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuThuTien1> PhieuThuTien1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuXuatHang1> PhieuXuatHang1 { get; set; }
    }
}
