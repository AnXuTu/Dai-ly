using QuanLyDaiLi.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDaiLi.Model
{
    public class CongNoDaiLy:BaseViewModel
    {
        public int STT { get; set; }
        private HoSoDaiLi1 _HoSoDaiLi1;
        public HoSoDaiLi1 HoSoDaiLi1 { get => _HoSoDaiLi1; set { _HoSoDaiLi1 = value; OnPropertyChanged(); } }
        public int NoDau { get; set; }
        public int PhatSinh { get; set; }
        public int NoCuoi { get; set; }
    }
}
