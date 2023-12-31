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
    /// Logique d'interaction pour ModifierPersonnelFinal.xaml
    /// </summary>
    public partial class ModifierPersonnelFinal : Window
    {
       
        public Personnel PersonnelSelectionne { get; set; }
        public ModifierPersonnelFinal( Personnel personnelSelectionne, Window owner)
        {
            this.Owner = owner;
            InitializeComponent();
            this.PersonnelSelectionne= personnelSelectionne;
        }

        private void BTModi_Click(object sender, RoutedEventArgs e)
        {
            this.PersonnelSelectionne.NomPersonnel = tbNomPersonnel.Text;
            this.PersonnelSelectionne.PrenomPersonnel = tbPrenomPersonnel.Text;
            this.PersonnelSelectionne.Email = tbEmailPersonnel.Text;
            this.PersonnelSelectionne.Update();
            this.Close();
        }

    }
}
