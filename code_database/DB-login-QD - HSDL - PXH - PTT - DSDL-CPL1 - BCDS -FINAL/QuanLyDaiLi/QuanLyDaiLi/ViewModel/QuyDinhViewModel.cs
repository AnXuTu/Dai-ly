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
    public class QuyDinhViewModel:BaseViewModel
    {
        private ObservableCollection<QuyDinh1> _List;
        public ObservableCollection<QuyDinh1> List { get => _List; set { _List = value; OnPropertyChanged(); } }

        private QuyDinh1 _SelectedItem;
        public QuyDinh1 SelectedItem
        {
            get => _SelectedItem; set
            {
                _SelectedItem = value; OnPropertyChanged();
                if (SelectedItem != null)
                {
                    LoaiDaiLy = SelectedItem.LoaiDaiLy;
                    SoLuong = SelectedItem.SoLuong;
                }
            }
        }

        private string _LoaiDaiLy;
        public string LoaiDaiLy { get => _LoaiDaiLy; set { _LoaiDaiLy = value; OnPropertyChanged(); } }
        private int _SoLuong;
        public int SoLuong { get => _SoLuong; set { _SoLuong = value; OnPropertyChanged(); } }

        public ICommand AddCommand { get; set; }
        public ICommand EditCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        public QuyDinhViewModel()
        {
            List = new ObservableCollection<QuyDinh1>(DataProvider.Ins.DB.QuyDinh1);
            AddCommand = new RelayCommand<object>((p) =>
            {
                if (string.IsNullOrEmpty(LoaiDaiLy))
                    return false;
                var displayList = DataProvider.Ins.DB.QuyDinh1.Where(x => x.LoaiDaiLy == LoaiDaiLy);
                if (displayList == null || displayList.Count() != 0)
                    return false;
                return true;
            }, (p) =>
            {
                var quydinh = new QuyDinh1() { LoaiDaiLy = LoaiDaiLy };

                DataProvider.Ins.DB.QuyDinh1.Add(quydinh);
                DataProvider.Ins.DB.SaveChanges();
                List.Add(quydinh);
            });
            EditCommand = new RelayCommand<object>((p) =>
            {
                if (string.IsNullOrEmpty(LoaiDaiLy) || SelectedItem == null)
                    return false;
            var displayList = DataProvider.Ins.DB.QuyDinh1.Where(x => x.LoaiDaiLy == LoaiDaiLy);
                var dis = DataProvider.Ins.DB.QuyDinh1.Where(x => x.SoLuong == SoLuong);
            if (displayList == null || dis == null)
                    return false;
                return true;
            }, (p) =>
            {
                var quydinh = DataProvider.Ins.DB.QuyDinh1.Where(x => x.Id == SelectedItem.Id).SingleOrDefault();
                quydinh.LoaiDaiLy = LoaiDaiLy;
                quydinh.SoLuong = SoLuong;
                DataProvider.Ins.DB.SaveChanges();
                
            });
            DeleteCommand = new RelayCommand<object>((p) =>
            {
                if (string.IsNullOrEmpty(LoaiDaiLy) || SelectedItem == null)
                    return false;
                var displayList = DataProvider.Ins.DB.QuyDinh1.Where(x => x.LoaiDaiLy == LoaiDaiLy);
                if (null != displayList)
                    return true;
                return false;
            }, (p) =>
            {

                var unit = DataProvider.Ins.DB.QuyDinh1.Where(x => x.Id == SelectedItem.Id).SingleOrDefault();
                DataProvider.Ins.DB.QuyDinh1.Remove(unit);
                List.Remove(unit);

                DataProvider.Ins.DB.SaveChanges();
            });
        }
    }
}
