using QuanLyDaiLi.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace QuanLyDaiLi.ViewModel
{
    public class BaoCaoDoanhSoViewModel:BaseViewModel
    {
        private ObservableCollection<Model.BaoCaoDoanhSo> _List;
        public ObservableCollection<Model.BaoCaoDoanhSo> List { get => _List; set { _List = value; OnPropertyChanged(); } }

        private DateTime _Thang;
        public DateTime Thang { get => _Thang; set { _Thang = value; OnPropertyChanged(); } }

        private ObservableCollection<Model.HoSoDaiLi1> _HoSoDaiLy;
        public ObservableCollection<Model.HoSoDaiLi1> HoSoDaiLy { get => _HoSoDaiLy; set { _HoSoDaiLy = value; OnPropertyChanged(); } }

        public ICommand LoadCommand { get; set; }

        public BaoCaoDoanhSoViewModel()
        {
            LoadCommand = new RelayCommand<object>((p) =>
            {
                return true;

            }, (p) =>
            {
                List = new ObservableCollection<Model.BaoCaoDoanhSo>();
                var thangg = DataProvider.Ins.DB.PhieuXuatHang1;
                int i = 1;
                foreach (var items in thangg)
                {
                    if (Thang == items.NgayLapPhieu)
                    {
                        var danhSachdanhli = DataProvider.Ins.DB.HoSoDaiLi1.Where(x=>x.Id == items.IdTenDaiLy);

                        
                        foreach (var item in danhSachdanhli)
                        {

                            var sophieuxuat = DataProvider.Ins.DB.PhieuXuatHang1.Where(x => x.IdTenDaiLy == item.Id);
                            var phieuxuat = DataProvider.Ins.DB.PhieuXuatHang1;
                            int tonggiatri = 0;
                            int sophieu = 0;
                            float tyle = 0;
                            tonggiatri = (int)sophieuxuat.Sum(x => x.ThanhTien);
                            sophieu = sophieuxuat.Count();
                            tyle = (int)phieuxuat.Sum(x => x.ThanhTien);
                            BaoCaoDoanhSo baocaodoanhso = new BaoCaoDoanhSo();
                            baocaodoanhso.STT = i;
                            baocaodoanhso.HoSoDaiLi1 = item;
                            baocaodoanhso.SoPhieuXuat = sophieu;
                            baocaodoanhso.TongGiaTri = tonggiatri;
                            baocaodoanhso.TyLe = tonggiatri / tyle;
                            i++;
                            List.Add(baocaodoanhso);

                        }


                    }
                }
            });
        }

    }
}
