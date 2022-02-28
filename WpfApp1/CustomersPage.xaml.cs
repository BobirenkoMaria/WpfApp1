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
    /// Логика взаимодействия для CustomersPage.xaml
    /// </summary>
    public partial class CustomersPage : Page, INotifyPropertyChanged
    {
        public CustomersPage()
        {
            InitializeComponent();
            DataContext = this;
        }

        public CustomersPage(CustomersData selectedCustomer)
        {
            InitializeComponent();
            DataContext = this;
            SelectedCustomer = selectedCustomer;
        }

        private CustomersData selectedCustomer;

        public ObservableCollection<CustomersData> Customers
        {
            get => Data.Customers;
        }

        public CustomersData SelectedCustomer
        {
            get => selectedCustomer;
            set
            {
                selectedCustomer = value;
                Signal();
            }
        }

        void Signal([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this,
                      new PropertyChangedEventArgs(name));
        }
        public event PropertyChangedEventHandler PropertyChanged;

        private void ToCustomersList(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CustumersListPage());
        }
    }
}
