using QuanLyDaiLi.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace QuanLyDaiLi.ViewModel
{
    public class HoSoDaiLyViewModel:BaseViewModel
    {
        private ObservableCollection<Model.HoSoDaiLi1> _List;
        public ObservableCollection<Model.HoSoDaiLi1> List { get => _List; set { _List = value; OnPropertyChanged(); } }
        private ObservableCollection<QuyDinh1> _QuyDinh;
        public ObservableCollection<QuyDinh1> QuyDinh { get => _QuyDinh; set { _QuyDinh = value; OnPropertyChanged(); } }

        private ObservableCollection<Quan> _TenQuan1;
        public ObservableCollection<Quan> TenQuan1 { get => _TenQuan1; set { _TenQuan1 = value; OnPropertyChanged(); } }
        private Model.HoSoDaiLi1 _SelectedItem;
        public Model.HoSoDaiLi1 SelectedItem
        {
            get => _SelectedItem; set
            {
                _SelectedItem = value; OnPropertyChanged();
                if (SelectedItem != null)
                {
                    TenDaiLy = SelectedItem.TenDaiLy;
                    Phone = SelectedItem.Phone;
                    Address = SelectedItem.Address;
                    
                    NgayTiepNhan = SelectedItem.NgayTiepNhan;
                    SelectedLoaiDaiLy = SelectedItem.QuyDinh1;
                    SelectedQuan = SelectedItem.Quan;
                }
            }
        }

        private Model.QuyDinh1 _SelectedLoaiDaiLy;
        public Model.QuyDinh1 SelectedLoaiDaiLy
        {
            get => _SelectedLoaiDaiLy; set
            {
                _SelectedLoaiDaiLy = value; OnPropertyChanged();
            }
        }
        private Model.Quan _SelectedQuan;
        public Model.Quan SelectedQuan
        {
            get => _SelectedQuan; set
            {
                _SelectedQuan = value; OnPropertyChanged();
            }
        }
        private string _TenDaiLy;
        public string TenDaiLy { get => _TenDaiLy; set { _TenDaiLy = value; OnPropertyChanged(); } }
        private DateTime _NgayTiepNhan;
        public DateTime NgayTiepNhan { get => _NgayTiepNhan; set { _NgayTiepNhan = value; OnPropertyChanged(); } }
        private string _Phone;
        public string Phone { get => _Phone; set { _Phone = value; OnPropertyChanged(); } }
        private string _Address;
        public string Address { get => _Address; set { _Address = value; OnPropertyChanged(); } }
        //private string _Quan;
        //public string Quan { get => _Quan; set { _Quan = value; OnPropertyChanged(); } }

        public ICommand AddCommand { get; set; }
        public ICommand EditCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        public HoSoDaiLyViewModel()
        {
            List = new ObservableCollection<Model.HoSoDaiLi1>(DataProvider.Ins.DB.HoSoDaiLi1);
            QuyDinh = new ObservableCollection<QuyDinh1>(DataProvider.Ins.DB.QuyDinh1);
            TenQuan1 = new ObservableCollection<Quan>(DataProvider.Ins.DB.Quans);
            AddCommand = new RelayCommand<object>((p) =>
            {
                if (SelectedLoaiDaiLy == null)
                    return false;
                return true;
            }, (p) =>
            {
                var Hosodaili = new HoSoDaiLi1() { TenDaiLy = TenDaiLy, Phone = Phone, Address = Address, IdQuan = SelectedQuan.id, NgayTiepNhan = NgayTiepNhan, IdLoaiDaiLy = SelectedLoaiDaiLy.Id, Id = Guid.NewGuid().ToString() };

                DataProvider.Ins.DB.HoSoDaiLi1.Add(Hosodaili);
                DataProvider.Ins.DB.SaveChanges();
                List.Add(Hosodaili);
                var ss = DataProvider.Ins.DB.Quans;
                foreach(var item in ss)
                {
                    var soquan = DataProvider.Ins.DB.HoSoDaiLi1.Where(x => x.IdQuan == item.id);
                    int so = 0;
                    so = soquan.Count();
                    if(so > item.SoDaiLi)
                    {
                        MessageBox.Show("Vi phạm quy định số lượng đại lý!");
                        DataProvider.Ins.DB.HoSoDaiLi1.Remove(Hosodaili);
                        List.Remove(Hosodaili);
                    }
                }
            });
            EditCommand = new RelayCommand<object>((p) =>
            {
            if (SelectedItem == null || SelectedLoaiDaiLy == null)
                return false;
                var displayList = DataProvider.Ins.DB.HoSoDaiLi1.Where(x => x.Id == SelectedItem.Id);
                if (displayList == null || displayList.Count() != 0)
                    return true;
                return false;
            }, (p) =>
            {
                var ss = DataProvider.Ins.DB.Quans;
                foreach (var item in ss)
                {
                    var soquan = DataProvider.Ins.DB.HoSoDaiLi1.Where(x => x.IdQuan == item.id);
                    int so = 0;
                    so = soquan.Count();
                    if (so == item.SoDaiLi)
                    {
                        MessageBox.Show("Số đại lý trong quận đã tối đa!");
                       return;
                    }
                    else
                    {
                        var HoSo = DataProvider.Ins.DB.HoSoDaiLi1.Where(x => x.Id == SelectedItem.Id).SingleOrDefault();
                        HoSo.TenDaiLy = TenDaiLy;
                        HoSo.Phone = Phone;
                        HoSo.Address = Address;
                        HoSo.IdQuan = SelectedQuan.id;
                        HoSo.NgayTiepNhan = NgayTiepNhan;
                        HoSo.IdLoaiDaiLy = SelectedLoaiDaiLy.Id;
                        SelectedItem.TenDaiLy = TenDaiLy;
                        //DataProvider.Ins.DB.SaveChanges();
                    }
                }
                //var HoSo = DataProvider.Ins.DB.HoSoDaiLi1.Where(x => x.Id == SelectedItem.Id).SingleOrDefault();
                //HoSo.TenDaiLy = TenDaiLy;
                //HoSo.Phone = Phone;
                //HoSo.Address = Address;
                //HoSo.IdQuan = SelectedQuan.id;
                //HoSo.NgayTiepNhan = NgayTiepNhan;
                //HoSo.IdLoaiDaiLy = SelectedLoaiDaiLy.Id;
                //SelectedItem.TenDaiLy = TenDaiLy;
                DataProvider.Ins.DB.SaveChanges();

                //var ss = DataProvider.Ins.DB.Quans;
                //foreach (var item in ss)
                //{
                //    var soquan = DataProvider.Ins.DB.HoSoDaiLi1.Where(x => x.IdQuan == item.id);
                //    int so = 0;
                //    so = soquan.Count();
                //    if (so > item.SoDaiLi)
                //    {
                //        MessageBox.Show("Vi phạm quy định số lượng đại lý!");
                //        DataProvider.Ins.DB.HoSoDaiLi1.Remove(HoSo);
                //        List.Remove(HoSo);
                //    }
                //}

            });
            DeleteCommand = new RelayCommand<object>((p) =>
            {
                if (string.IsNullOrEmpty(TenDaiLy) || SelectedItem == null)
                    return false;
                var displayList = DataProvider.Ins.DB.HoSoDaiLi1.Where(x => x.TenDaiLy == TenDaiLy);
                if (null != displayList)
                    return true;
                return false;
            }, (p) =>
            {

                var DaiLy = DataProvider.Ins.DB.HoSoDaiLi1.Where(x => x.Id == SelectedItem.Id).SingleOrDefault();
                var phieuxuathang = DataProvider.Ins.DB.PhieuXuatHang1.Where(x => x.IdTenDaiLy == SelectedItem.Id).SingleOrDefault();
                var phieuthutien = DataProvider.Ins.DB.PhieuThuTien1.Where(x => x.IdTenDaiLy == SelectedItem.Id).SingleOrDefault();
                if (phieuxuathang != null)
                {
                    DataProvider.Ins.DB.PhieuXuatHang1.Remove(phieuxuathang);
                }
                if (phieuthutien != null)
                {
                    DataProvider.Ins.DB.PhieuThuTien1.Remove(phieuthutien);
                }

                DataProvider.Ins.DB.HoSoDaiLi1.Remove(DaiLy);
                List.Remove(DaiLy);
               
                DataProvider.Ins.DB.SaveChanges();
            });
        }   
    }
}
