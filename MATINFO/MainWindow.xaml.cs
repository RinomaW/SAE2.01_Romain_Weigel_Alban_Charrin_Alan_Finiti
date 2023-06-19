﻿using MATINFO.Model;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MATINFO
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {//feur
            InitializeComponent();
            DataContext = applicationData;
        }

        private void BTAjout(object sender, RoutedEventArgs e)
        {
            CAPM CAPM = new CAPM();
            
            CAPM.Show();
        }

        private void BTModi(object sender, RoutedEventArgs e)
        {
            ActionModifier Modifier = new ActionModifier();
            Modifier.P = lvAttribution.SelectedItem as Personnel;
            Modifier.Show();

        }

        private void lvCategorie_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void BTSuppr(object sender, RoutedEventArgs e)
        {
            CAPMSuppr CAPMS = new CAPMSuppr();

            CAPMS.Show();
        }
    }
}
