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
    public class PhieuXuatHangViewModel : BaseViewModel
    {
        private ObservableCollection<Model.PhieuXuatHang1> _List;
        public ObservableCollection<Model.PhieuXuatHang1> List { get => _List; set { _List = value; OnPropertyChanged(); } }
        private ObservableCollection<HoSoDaiLi1> _HoSoDaiLy;
        public ObservableCollection<HoSoDaiLi1> HoSoDaiLy { get => _HoSoDaiLy; set { _HoSoDaiLy = value; OnPropertyChanged(); } }

        private Model.PhieuXuatHang1 _SelectedItem;
        public Model.PhieuXuatHang1 SelectedItem
        {
            get => _SelectedItem; set
            {
                _SelectedItem = value; OnPropertyChanged();
                if (SelectedItem != null)
                {

                    MatHang = SelectedItem.MatHang;
                    DonViTinh = SelectedItem.DonViTinh;
                    DonGia = SelectedItem.DonGia;
                    SoLuong = SelectedItem.SoLuong;
                    NgayLapPhieu = SelectedItem.NgayLapPhieu;
                    SelectedTenDaiLy = SelectedItem.HoSoDaiLi1;
                }
            }
        }


        private Model.HoSoDaiLi1 _SelectedTenDaiLy;
        public Model.HoSoDaiLi1 SelectedTenDaiLy
        {
            get => _SelectedTenDaiLy; set
            {
                _SelectedTenDaiLy = value; OnPropertyChanged();
            }
        }
        private string _MatHang;
        public string MatHang { get => _MatHang; set { _MatHang = value; OnPropertyChanged(); } }

        private DateTime _NgayLapPhieu;
        public DateTime NgayLapPhieu { get => _NgayLapPhieu; set { _NgayLapPhieu = value; OnPropertyChanged(); } }

        private string _DonViTinh;
        public string DonViTinh { get => _DonViTinh; set { _DonViTinh = value; OnPropertyChanged(); } }

        private int _SoLuong;
        public int SoLuong { get => _SoLuong; set { _SoLuong = value; OnPropertyChanged(); } }

        private Double _DonGia;
        public Double DonGia { get => _DonGia; set { _DonGia = value; OnPropertyChanged(); } }


        public ICommand AddCommand { get; set; }
        public ICommand EditCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        public PhieuXuatHangViewModel()
        {
            List = new ObservableCollection<Model.PhieuXuatHang1>(DataProvider.Ins.DB.PhieuXuatHang1);
            
            HoSoDaiLy = new ObservableCollection<HoSoDaiLi1>(DataProvider.Ins.DB.HoSoDaiLi1);

            AddCommand = new RelayCommand<object>((p) =>
            {
                if (SelectedTenDaiLy == null)
                    return false;
                return true;
            }, (p) =>
            {
                var PhieuXuatHang = new PhieuXuatHang1()
                {
                    MatHang = MatHang,
                    DonViTinh = DonViTinh,
                    DonGia = DonGia,
                    SoLuong = SoLuong,
                    NgayLapPhieu = NgayLapPhieu,
                    IdTenDaiLy = SelectedTenDaiLy.Id,
                    ThanhTien = (int)DonGia * SoLuong
                };

                DataProvider.Ins.DB.PhieuXuatHang1.Add(PhieuXuatHang);
                
                List.Add(PhieuXuatHang);
                DataProvider.Ins.DB.SaveChanges();
            });
            EditCommand = new RelayCommand<object>((p) =>
            {
                if (SelectedItem == null || SelectedTenDaiLy == null)
                    return false;
                var displayList = DataProvider.Ins.DB.PhieuXuatHang1.Where(x => x.Id == SelectedItem.Id);
                if (displayList == null || displayList.Count() != 0)
                    return true;
                return false;
            }, (p) =>
            {
                var PhieuXuat = DataProvider.Ins.DB.PhieuXuatHang1.Where(x => x.Id == SelectedItem.Id).SingleOrDefault();
                PhieuXuat.MatHang = MatHang;
                PhieuXuat.DonViTinh = DonViTinh;
                PhieuXuat.DonGia = DonGia;
                PhieuXuat.SoLuong = SoLuong;
                PhieuXuat.NgayLapPhieu = NgayLapPhieu;
                PhieuXuat.IdTenDaiLy = SelectedTenDaiLy.Id;
                PhieuXuat.ThanhTien = (int)DonGia * SoLuong;
                DataProvider.Ins.DB.SaveChanges();                
            });
            DeleteCommand = new RelayCommand<object>((p) =>
            {
                if (SelectedItem == null)
                    return false;
                var displayList = DataProvider.Ins.DB.PhieuXuatHang1.Where(x => x.MatHang == MatHang);
                if (null != displayList)
                    return true;
                return false;
            }, (p) =>
            {

                var Phieuxuathang = DataProvider.Ins.DB.PhieuXuatHang1.Where(x => x.Id == SelectedItem.Id).SingleOrDefault();
                DataProvider.Ins.DB.PhieuXuatHang1.Remove(Phieuxuathang);
                List.Remove(Phieuxuathang);

                DataProvider.Ins.DB.SaveChanges();
            });
        }
    }
}
