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

namespace LSD_CORP.View
{
    /// <summary>
    /// Логика взаимодействия для ClientAddForm.xaml
    /// </summary>
    public partial class ClientAddForm : Window
    {
        private Client selectedClient;

        public ClientAddForm()
        {
            InitializeComponent();
        }

        public ClientAddForm(Client selectedClient)
        {
            InitializeComponent();
        }

        private void SaveClick(object sender, RoutedEventArgs e)
        {

        }

        private void BackClick(object sender, RoutedEventArgs e)
        {

        }
    }
}
