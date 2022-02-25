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
    /// Логика взаимодействия для StartPage.xaml
    /// </summary>
    public partial class StartPage : Page, INotifyPropertyChanged
    {
        public StartPage()
        {
            InitializeComponent();
            DataContext = this;
        }

        public ObservableCollection<Orders> Orders
        {
            get => Data.Orders;
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

        public

        void Signal([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this,
                      new PropertyChangedEventArgs(name));
        }
        public event PropertyChangedEventHandler PropertyChanged;

        private void OpenOrder(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new MainPortraitParam(SelectedOrder));
        }

        private void AddOrder(object sender, RoutedEventArgs e)
        {
            Orders.Add(new Orders
            {
                Title = "Новый заказ"
            });
        }

        private void DeleteOrder(object sender, RoutedEventArgs e)
        {
            if (SelectedOrder == null)
                return;
            if (MessageBox.Show("Действительно удалить выбраный заказ?",
                "Предупреждение", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                Orders.Remove(SelectedOrder);
                SelectedOrder = null;
            }
        }

        private void ToCustomersPage(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CustomersPage());
        }
    }
}
