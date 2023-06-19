using MATINFO.Model;
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

    
    public partial class SupprimerMateriel : Window
    {
        public Materiel Materiel { get; set; }
        public SupprimerMateriel()
        {
            InitializeComponent();
        }
        public SupprimerMateriel(Materiel materiel)
        {
            InitializeComponent();
            this.Materiel = materiel;
            lvMaterielSelectionne.SelectedItem = materiel;
        }

        private void BTSuppr_Click(object sender, RoutedEventArgs e)
        {
            Materiel materielSupprimee = lvMaterielSelectionne.SelectedItem as Materiel;
            materielSupprimee.Delete();
            this.Close();
        }

        

       
    }
}
