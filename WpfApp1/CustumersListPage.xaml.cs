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
    /// Логика взаимодействия для CustumersListPage.xaml
    /// </summary>
    public partial class CustumersListPage : Page, INotifyPropertyChanged
    {
        public CustumersListPage()
        {
            InitializeComponent();
            DataContext = this;
        }

        public ObservableCollection<CustomersData> Customers
        {
            get => Data.Customers;
        }

        private CustomersData selectedCustomer;

        public CustomersData SelectedCustomer
        {
            get => selectedCustomer;
            set
            {
                selectedCustomer = value;
                Signal();
            }
        }

        public void Signal([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this,
                      new PropertyChangedEventArgs(name));
        }
        public event PropertyChangedEventHandler PropertyChanged;

        private void AddCustumer(object sender, RoutedEventArgs e)
        {
            Customers.Add(new CustomersData
            {
                FIO = "Ваше ФИО"
            });
        }

        private void DeleteCustumer(object sender, RoutedEventArgs e)
        {
            if (SelectedCustomer == null)
                return;
            if (MessageBox.Show("Действительно удалить выбраный заказ?",
                "Предупреждение", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                Customers.Remove(SelectedCustomer);
                SelectedCustomer = null;
            }
        }

        private void ToStartPage(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new StartPage());
        }
        private void ToCustomersPage(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CustomersPage(SelectedCustomer));
        }
    }
}
