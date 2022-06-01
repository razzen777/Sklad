﻿using MedicationAccounting.Pages;
using System;
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

namespace MedicationAccounting
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        AddMedicWindow medicWindow = new AddMedicWindow();
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new MedicListPage());
        }

        private void AddMedic_Click(object sender, RoutedEventArgs e)
        {
            medicWindow.Show();
        }
    }
}
