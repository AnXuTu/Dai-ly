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
    public class DanhSachDaiLiViewModel:BaseViewModel
    {
        private ObservableCollection<Model.DanhSachDaiLy> _List;
        public ObservableCollection<Model.DanhSachDaiLy> List { get => _List; set { _List = value; OnPropertyChanged(); } }

        //private ObservableCollection<Model.HoSoDaiLi> _HoSoDaiLy;        
        //public ObservableCollection<Model.HoSoDaiLi> HoSoDaiLy { get => _HoSoDaiLy; set { _HoSoDaiLy = value; OnPropertyChanged(); } }

        public ICommand LoadCommand { get; set; }
        public DanhSachDaiLiViewModel()
        {
            
            LoadCommand = new RelayCommand<object>((p) =>
            {               
                return true;
                
            }, (p) =>
            {
                List = new ObservableCollection<Model.DanhSachDaiLy>();
                var danhSachdanhli = DataProvider.Ins.DB.HoSoDaiLi1 ;
                
                int i = 1;
                foreach (var item in danhSachdanhli)
                {
                    var thutienlist = DataProvider.Ins.DB.PhieuThuTien1.Where(x => x.IdTenDaiLy == item.Id);
                    var xuathanglist = DataProvider.Ins.DB.PhieuXuatHang1.Where(x => x.IdTenDaiLy == item.Id);
                    var quydinhs = DataProvider.Ins.DB.QuyDinh1.Where(x => x.Id == item.IdLoaiDaiLy);
                    var quan = DataProvider.Ins.DB.Quans.Where(x => x.id == item.IdQuan);
                    int sumthutien = 0;
                    int sumxuathang = 0;
                    if (thutienlist.Sum(x => x.SoTienThu) == null)
                    {
                        sumthutien = 0;
                    }
                    else
                    {
                        sumthutien = (int)thutienlist.Sum(x => x.SoTienThu);
                    }
                    if (xuathanglist.Sum(x => x.ThanhTien) == null)
                    {
                        sumxuathang = 0;
                    }
                    else
                    {
                        sumxuathang = (int)xuathanglist.Sum(x => x.ThanhTien);
                    }

                    foreach (var items in quydinhs)
                    {

                        foreach (var itemss in quan)
                        {
                            DanhSachDaiLy danhsachdaili = new DanhSachDaiLy();
                            danhsachdaili.STT = i;
                            danhsachdaili.HoSoDaiLi = item;
                            danhsachdaili.QuyDinh = items;
                            danhsachdaili.Quan = itemss;
                            danhsachdaili.TienNo = sumxuathang - sumthutien;
                            i++;
                            List.Add(danhsachdaili);
                        }
                    }
                    
                }
            });
        }
    }
}
