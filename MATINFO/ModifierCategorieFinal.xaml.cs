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

namespace MATINFO
{
    /// <summary>
    /// Logique d'interaction pour ModifierCategorieFinal.xaml
    /// </summary>
    public partial class ModifierCategorieFinal : Window
    {
        public ModifierCategorieFinal()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            (Categorie)modifierCategorie.categorieSelectionnee.Update(tbModifierCategorieFinal.Text);
        }

        
    }
}
