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
    public class MainViewModel : BaseViewModel
    {
        private int _SoLuong;
        public int SoLuong { get => _SoLuong; set { _SoLuong = value; OnPropertyChanged(); } }

        private Double _DonGia;
        public Double DonGia { get => _DonGia; set { _DonGia = value; OnPropertyChanged(); } }
        public bool Isloaded = false;
        public ICommand LoadedWindowCommand { get; set; }
        public ICommand QuyDinhCommand { get;set;}
        public ICommand BaoCaoDoanhSoCommand { get; set; }
        public ICommand CongNoDaiLyCommand { get; set; }
        public ICommand PhieuThuTienCommand { get; set; }
        public ICommand DanhSachDaiLyCommand { get; set; }
        public ICommand HoSoDaiLyCommand { get; set; }
        public ICommand PhieuXuatHangCommand { get; set; }
        public ICommand QuyDinh1Command { get; set; }
        // mọi thứ xử lý sẽ nằm trong này
        public MainViewModel()
        {
            LoadedWindowCommand = new RelayCommand<Window>((p) => { return true; }, (p) => {
                Isloaded = true;
                if (p == null)
                    return;
                p.Hide();
                LoginWindow loginWindow = new LoginWindow();
                loginWindow.ShowDialog();

                if (loginWindow.DataContext == null)
                    return;
                var loginVM = loginWindow.DataContext as LoginViewModel;
                if (loginVM.IsLogin)
                {
                    p.Show();                    
                }
                else
                {
                    p.Close();
                }
            }
              );
            QuyDinhCommand = new RelayCommand<object>((p) => { return true; }, (p) => {
                QuyDinhWindow Wd = new QuyDinhWindow();
                Wd.ShowDialog();
            });
            QuyDinh1Command = new RelayCommand<object>((p) => { return true; }, (p) => {
                QuyDinh1WinDow Wd = new QuyDinh1WinDow();
                Wd.ShowDialog();
            });
            BaoCaoDoanhSoCommand = new RelayCommand<object>((p) => { return true; }, (p) => {
                BaoCaoDanhSoWindow Wd = new BaoCaoDanhSoWindow();
                Wd.ShowDialog();
            });
            CongNoDaiLyCommand = new RelayCommand<object>((p) => { return true; }, (p) => {
                CongNoDaiLyWindow Wd = new CongNoDaiLyWindow();
                Wd.ShowDialog();
            });
            PhieuThuTienCommand = new RelayCommand<object>((p) => { return true; }, (p) => {
                PhieuThuTienWindow Wd = new PhieuThuTienWindow();
                Wd.ShowDialog();
            });
            DanhSachDaiLyCommand = new RelayCommand<object>((p) => { return true; }, (p) => {
                DanhSachDaiLyWindow Wd = new DanhSachDaiLyWindow();
                Wd.ShowDialog();                
            });            
            PhieuXuatHangCommand = new RelayCommand<object>((p) => { return true; }, (p) => {
                PhieuXuatHangWindow Wd = new PhieuXuatHangWindow();                
                Wd.ShowDialog();
            });
            HoSoDaiLyCommand = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                HoSoDaiLyWindow Wd = new HoSoDaiLyWindow();
                Wd.ShowDialog();
            });
        }                
    }

}
    