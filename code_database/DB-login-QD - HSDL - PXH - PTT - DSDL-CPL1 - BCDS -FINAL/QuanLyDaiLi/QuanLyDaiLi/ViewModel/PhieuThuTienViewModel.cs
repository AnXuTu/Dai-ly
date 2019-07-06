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
    public class PhieuThuTienViewModel : BaseViewModel
    {
        private ObservableCollection<Model.PhieuThuTien1> _List;
        public ObservableCollection<Model.PhieuThuTien1> List { get => _List;set { _List = value;OnPropertyChanged(); } }
        private ObservableCollection<HoSoDaiLi1> _HoSoDaiLy;
        public ObservableCollection<HoSoDaiLi1> HoSoDaiLy { get => _HoSoDaiLy; set { _HoSoDaiLy = value; OnPropertyChanged(); } }

        private Model.PhieuThuTien1 _SelectedItem;
        public Model.PhieuThuTien1 SelectedItem
        {
            get => _SelectedItem; set
            {
                _SelectedItem = value; OnPropertyChanged();
                if (SelectedItem != null)
                {
                    Address = SelectedItem.Address;
                    Phone = SelectedItem.Phone;
                    Email = SelectedItem.Email;
                    SoTienThu = SelectedItem.SoTienThu;
                    NgayThuTien = SelectedItem.NgayThuTien;
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
        private string _Address;
        public string Address { get => _Address; set { _Address = value; OnPropertyChanged(); } }

        private DateTime _NgayThuTien;
        public DateTime NgayThuTien { get => _NgayThuTien; set { _NgayThuTien = value; OnPropertyChanged(); } }

        private string _Phone;
        public string Phone { get => _Phone; set { _Phone = value; OnPropertyChanged(); } }

        private string _Email;
        public string Email { get => _Email; set { _Email = value; OnPropertyChanged(); } }

        private Double? _SoTienThu;
        public Double? SoTienThu { get => _SoTienThu; set { _SoTienThu = value; OnPropertyChanged(); } }



        public ICommand AddCommand { get; set; }
        public ICommand EditCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        public PhieuThuTienViewModel()
        {
            List = new ObservableCollection<Model.PhieuThuTien1>(DataProvider.Ins.DB.PhieuThuTien1);
            HoSoDaiLy = new ObservableCollection<HoSoDaiLi1>(DataProvider.Ins.DB.HoSoDaiLi1);


            AddCommand = new RelayCommand<object>((p) =>
            {
                if (SelectedTenDaiLy == null)
                    return false;
                return true;
            }, (p) =>
            {
                var PhieuThuTien = new PhieuThuTien1() { Phone = Phone, Email = Email, Address = Address, SoTienThu = SoTienThu, NgayThuTien = NgayThuTien, IdTenDaiLy = SelectedTenDaiLy.Id };          
                    DataProvider.Ins.DB.PhieuThuTien1.Add(PhieuThuTien);
                    DataProvider.Ins.DB.SaveChanges();
                    List.Add(PhieuThuTien);
                var danhSachdanhli = DataProvider.Ins.DB.PhieuThuTien1;

                foreach (var item in danhSachdanhli)
                {
                    var thutienlist = DataProvider.Ins.DB.PhieuThuTien1.Where(x => x.IdTenDaiLy == item.IdTenDaiLy);
                    var xuathanglist = DataProvider.Ins.DB.PhieuXuatHang1.Where(x => x.IdTenDaiLy == item.IdTenDaiLy);
                    var danhsach = DataProvider.Ins.DB.HoSoDaiLi1.Where(x => x.Id == item.IdTenDaiLy);
                    foreach (var i in danhsach)
                    {
                        var quydinhs = DataProvider.Ins.DB.QuyDinh1.Where(x => x.Id == i.IdLoaiDaiLy);
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
                            if ((sumxuathang - sumthutien) > items.SoLuong)
                            {
                                MessageBox.Show("Vi phạm quy định tiền nợ, nhập lại số tiền thu");
                                DataProvider.Ins.DB.PhieuThuTien1.Remove(PhieuThuTien);
                                List.Remove(PhieuThuTien);

                            }
                        }
                    }
                }
            });
            EditCommand = new RelayCommand<object>((p) =>
            {
                if (SelectedItem == null || SelectedTenDaiLy == null)
                    return false;
                var displayList = DataProvider.Ins.DB.PhieuThuTien1.Where(x => x.Id == SelectedItem.Id);
                if (displayList == null || displayList.Count() != 0)
                    return true;
                return false;
            }, (p) =>
            {
                var PhieuThuTien = DataProvider.Ins.DB.PhieuThuTien1.Where(x => x.Id == SelectedItem.Id).SingleOrDefault();
                PhieuThuTien.Phone = Phone;
                PhieuThuTien.Address = Address;
                PhieuThuTien.Email = Email;
                PhieuThuTien.SoTienThu = SoTienThu;
                PhieuThuTien.NgayThuTien = NgayThuTien;
                PhieuThuTien.IdTenDaiLy = SelectedTenDaiLy.Id;
                DataProvider.Ins.DB.SaveChanges();
                var danhSachdanhli = DataProvider.Ins.DB.PhieuThuTien1;

                foreach (var item in danhSachdanhli)
                {
                    var thutienlist = DataProvider.Ins.DB.PhieuThuTien1.Where(x => x.IdTenDaiLy == item.IdTenDaiLy);
                    var xuathanglist = DataProvider.Ins.DB.PhieuXuatHang1.Where(x => x.IdTenDaiLy == item.IdTenDaiLy);
                    var danhsach = DataProvider.Ins.DB.HoSoDaiLi1.Where(x => x.Id == item.IdTenDaiLy);
                    foreach (var i in danhsach)
                    {
                        var quydinhs = DataProvider.Ins.DB.QuyDinh1.Where(x => x.Id == i.IdLoaiDaiLy);
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
                            if ((sumxuathang - sumthutien) > items.SoLuong)
                            {
                                MessageBox.Show("Vi phạm quy định tiền nợ, nhập lại số tiền thu");
                                DataProvider.Ins.DB.PhieuThuTien1.Remove(PhieuThuTien);
                                List.Remove(PhieuThuTien);

                            }
                        }
                    }
                }
            });
            DeleteCommand = new RelayCommand<object>((p) =>
            {
                if ( SelectedItem == null)
                    return false;
                var displayList = DataProvider.Ins.DB.PhieuThuTien1.Where(x => x.Address == Address);
                if (null != displayList)
                    return true;
                return false;
            }, (p) =>
            {

                var PhieuThuTien = DataProvider.Ins.DB.PhieuThuTien1.Where(x => x.Id == SelectedItem.Id).SingleOrDefault();
                DataProvider.Ins.DB.PhieuThuTien1.Remove(PhieuThuTien);
                List.Remove(PhieuThuTien);

                DataProvider.Ins.DB.SaveChanges();
            });
        }
    }    
}
