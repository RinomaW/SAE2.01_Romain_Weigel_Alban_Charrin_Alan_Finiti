﻿using MATINFO.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
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
using System.Windows.Media.Media3D;
using System.Windows.Shapes;

namespace MATINFO
{

    /// <summary>
    /// Logique d'interaction pour AjouterAttribution.xaml
    /// </summary>
    public partial class SupprimerAttribution : Window
    {
        string tbtexte;
        public SupprimerAttribution()
        {
            InitializeComponent();
        }

        private void TBComm_GotFocus(object sender, RoutedEventArgs e)
        {
            this.TBComm.Text = "";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            Attribution attributionSupprimee = lvDateAttribution.SelectedItem as Attribution;
            attributionSupprimee.Delete();
            
        }

        private void TBComm_TextChanged(object sender, TextChangedEventArgs e)
        {
            //string tbtexte = TBComm.Text;

        }
    }
}
