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
using System.Windows.Shapes;

namespace MATINFO.ModifierFichier
{
    /// <summary>
    /// Logique d'interaction pour ModifierAttribution.xaml
    /// </summary>
    public partial class ModifierAttribution : Window
    {
        public ModifierAttribution(Window owner)
        {
            this.Owner = owner;
            InitializeComponent();
        }

        private void BTModi_Click(object sender, RoutedEventArgs e)
        {
                this.Visibility= Visibility.Hidden;
                ModifierAttributionFinal modifierAttributionFinal = new ModifierAttributionFinal(lvDateAttribution.SelectedItem as Attribution, this.Owner);
                modifierAttributionFinal.Show();
        }
    }
}
