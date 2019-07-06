using QuanLyDaiLi.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDaiLi.Model
{
    public class DanhSachDaiLy:BaseViewModel
    {
        public int STT { get; set; }
        private HoSoDaiLi1 _HoSoDaiLi;
        public HoSoDaiLi1 HoSoDaiLi { get=>_HoSoDaiLi; set { _HoSoDaiLi = value;OnPropertyChanged(); } }
        private QuyDinh1 _QuyDinh;
        public QuyDinh1 QuyDinh { get=> _QuyDinh; set { _QuyDinh = value;OnPropertyChanged(); } }
        private Quan _Quan;
        public Quan Quan { get => _Quan; set { _Quan = value;OnPropertyChanged(); } }
        private int _TienNo;
        public int TienNo { get=>_TienNo; set { _TienNo = value;OnPropertyChanged(); } }
    }
}
