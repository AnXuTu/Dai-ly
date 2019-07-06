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
    public class BaoCaoCongNoDaiLyViewModel:BaseViewModel
    {
        private ObservableCollection<Model.CongNoDaiLy> _List;
        public ObservableCollection<Model.CongNoDaiLy> List { get => _List; set { _List = value; OnPropertyChanged(); } }

        private DateTime _Thang;
        public DateTime Thang { get => _Thang; set { _Thang = value; OnPropertyChanged(); } }

        //private ObservableCollection<Model.HoSoDaiLi1> _HoSoDaiLy;
        //public ObservableCollection<Model.HoSoDaiLi1> HoSoDaiLy { get => _HoSoDaiLy; set { _HoSoDaiLy = value; OnPropertyChanged(); } }

        public ICommand LoadCommand { get; set; }
        
        public BaoCaoCongNoDaiLyViewModel()
        {
            LoadCommand = new RelayCommand<object>((p) =>
            {
                return true;

            }, (p) =>
            {
                List = new ObservableCollection<Model.CongNoDaiLy>();
                var thangg = DataProvider.Ins.DB.PhieuThuTien1;
                int i = 1;
                foreach ( var items in thangg )
                {
                    if (Thang == items.NgayThuTien)
                    {
                        var danhSachdanhli = DataProvider.Ins.DB.HoSoDaiLi1.Where(x=>x.Id == items.IdTenDaiLy);
                        
                        foreach (var item in danhSachdanhli)
                        {
                            var phieuxuat = DataProvider.Ins.DB.PhieuXuatHang1.Where(x => x.IdTenDaiLy == item.Id);
                            var sophieuxuat = DataProvider.Ins.DB.PhieuXuatHang1.Where(x => x.IdTenDaiLy == item.Id).First();
                            var phieuthu = DataProvider.Ins.DB.PhieuThuTien1.Where(x => x.IdTenDaiLy == item.Id);
                            var sophieuthu = DataProvider.Ins.DB.PhieuThuTien1.Where(x => x.IdTenDaiLy == item.Id).First();
                            int nodau = 0;
                            int nocuoi = 0;
                            nodau = (int)sophieuxuat.ThanhTien - (int)sophieuthu.SoTienThu;
                            nocuoi = (int)phieuxuat.Sum(x => x.ThanhTien) - (int)phieuthu.Sum(x => x.SoTienThu);

                            CongNoDaiLy congnodaili = new CongNoDaiLy();
                            congnodaili.STT = i;
                            congnodaili.HoSoDaiLi1 = item;
                            congnodaili.NoDau = nodau;
                            congnodaili.PhatSinh = nocuoi - nodau;
                            congnodaili.NoCuoi = nocuoi;
                            i++;
                            List.Add(congnodaili);
                            //}
                        }
                    }
                }
            });
        }
    }
}
