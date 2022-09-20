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
using System.Windows.Shapes;

namespace firstProgramm.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        public AdminWindow()
        {
            InitializeComponent();
        }
        private void btnLoadUsers_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new UsersPage());
        }

        private void btnLoadSomePage_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new SomePage());
        }
    }
}
