using QuanLyDaiLi.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDaiLi.Model
{
    public class BaoCaoDoanhSo:BaseViewModel
    {
        public int STT { get; set; }
        private HoSoDaiLi1 _HoSoDaiLi1;
        public HoSoDaiLi1 HoSoDaiLi1 { get => _HoSoDaiLi1; set { _HoSoDaiLi1 = value; OnPropertyChanged(); } }
        private int _SoPhieuXuat;
        public int SoPhieuXuat { get=>_SoPhieuXuat; set { _SoPhieuXuat = value;OnPropertyChanged(); } }
        private int _TongGiaTri;
        public int TongGiaTri { get=>_TongGiaTri; set { _TongGiaTri = value;OnPropertyChanged(); } }
        private float _TyLe;
        public float TyLe { get => _TyLe; set { _TyLe = value; OnPropertyChanged(); } }
        

    }
}
