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

namespace MATINFO.Supprimer
{
    /// <summary>
    /// Logique d'interaction pour DoubleClicSupprimer.xaml
    /// </summary>
    public partial class DoubleClicSupprimer : Window
    {
        public Categorie? DoubleClicCategorie { get; set; }
        public Materiel? DoubleClicMateriel { get; set; }
        public Attribution? DoubleClicAttribution { get; set; }
        public DoubleClicSupprimer(Object obj)
        {
            InitializeComponent();
            if (obj.GetType == new Categorie().GetType)
            {
                this.DoubleClicCategorie = obj as Categorie;
            }
            if (obj.GetType == new Materiel().GetType)
            {
                this.DoubleClicMateriel = obj as Materiel;
            }
            if (obj.GetType == new Attribution().GetType)
            {
                this.DoubleClicAttribution = obj as Attribution;
            }
        }

        private void BTOui_Click(object sender, RoutedEventArgs e)
        {

            if (this.DoubleClicCategorie!= null) 
            {
                this.DoubleClicCategorie.Delete();
            }
            if (this.DoubleClicAttribution != null)
            {
                this.DoubleClicAttribution.Delete();
            }
            if (this.DoubleClicMateriel != null)
            {
                this.DoubleClicMateriel.Delete();
            }
            this.Close();
        }

        private void BTNom_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
