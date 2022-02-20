﻿using System;
using System.Collections.Generic;
using System.Linq;
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
    public partial class MainPortraitParam : Page
    {
        public MainPortraitParam()
        {
            InitializeComponent();
        }

        private void ToMainMenu(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PortraitParamPage());
        }
    }
}
