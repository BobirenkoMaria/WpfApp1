using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    static class Data
    {
        static public ObservableCollection<CustomersData> Customers = new ObservableCollection<CustomersData>();
        static public ObservableCollection<Orders> Orders = new ObservableCollection<Orders>();
    }
}
