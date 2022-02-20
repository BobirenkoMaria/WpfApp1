using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class CustomersViewModel : INotifyPropertyChanged
    {
        private CustomersData selectedCustomer;

        public ObservableCollection<CustomersData> Customers
        {
            get => Data.customers;
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
    }
}
