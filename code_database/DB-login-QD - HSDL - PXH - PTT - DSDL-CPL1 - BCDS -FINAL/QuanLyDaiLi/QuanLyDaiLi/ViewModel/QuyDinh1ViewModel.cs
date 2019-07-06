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
    public class QuyDinh1ViewModel:BaseViewModel
    {
        private ObservableCollection<Quan> _List;
        public ObservableCollection<Quan> List { get => _List; set { _List = value; OnPropertyChanged(); } }

        private Quan _SelectedItem;
        public Quan SelectedItem
        {
            get => _SelectedItem; set
            {
                _SelectedItem = value; OnPropertyChanged();
                if (SelectedItem != null)
                {
                    TenQuan = SelectedItem.TenQuan;
                    SoDaiLi = SelectedItem.SoDaiLi;
                }
            }
        }

        private string _TenQuan;
        public string TenQuan { get => _TenQuan; set { _TenQuan = value; OnPropertyChanged(); } }
        private int _SoDaiLi;
        public int SoDaiLi { get => _SoDaiLi; set { _SoDaiLi = value; OnPropertyChanged(); } }

        public ICommand AddCommand { get; set; }
        public ICommand EditCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        public QuyDinh1ViewModel()
        {
            List = new ObservableCollection<Quan>(DataProvider.Ins.DB.Quans);
            EditCommand = new RelayCommand<object>((p) =>
            {
                if (string.IsNullOrEmpty(TenQuan) || SelectedItem == null)
                    return false;
                var displayList = DataProvider.Ins.DB.Quans.Where(x => x.TenQuan == TenQuan);
                var dis = DataProvider.Ins.DB.Quans.Where(x => x.SoDaiLi == SoDaiLi);
                if (displayList == null || dis == null)
                    return false;
                return true;
            }, (p) =>
            {
                var Quan = DataProvider.Ins.DB.Quans.Where(x => x.id == SelectedItem.id).SingleOrDefault();
                Quan.TenQuan = TenQuan;
                Quan.SoDaiLi = SoDaiLi;
                DataProvider.Ins.DB.SaveChanges();

            });
        }
    }
}
