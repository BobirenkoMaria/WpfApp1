using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainPortraitParam.xaml
    /// </summary>
    public partial class MainPortraitParam : Page, INotifyPropertyChanged
    {
        public MainPortraitParam()
        {
            InitializeComponent();
            DataContext = this;
        }

        public MainPortraitParam(Orders selectedOrder)
        {
            InitializeComponent();
            DataContext = this;
            this.selectedOrder = selectedOrder;

        }

        private Orders selectedOrder;

        public Orders SelectedOrder
        {
            get => selectedOrder;
            set
            {
                selectedOrder = value;
                Signal();
            }
        }

        void Signal([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this,
                      new PropertyChangedEventArgs(name));
        }
        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<Orders> Orders
        {
            get => Data.Orders;
        }

        private void ToMainMenu(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new StartPage());
        }
    }
}
