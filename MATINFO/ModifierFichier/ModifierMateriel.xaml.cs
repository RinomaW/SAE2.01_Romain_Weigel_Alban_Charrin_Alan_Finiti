using MATINFO.Model;
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

namespace MATINFO.Mofifier
{
    /// <summary>
    /// Logique d'interaction pour ModifierMateriel.xaml
    /// </summary>
    public partial class ModifierMateriel : Window
    {
        public Materiel materielSelectionne;
        public ModifierMateriel()
        {
            InitializeComponent();
        }

        private void BTModi_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility= Visibility.Hidden;
            materielSelectionne = lvMaterielSelectionne.SelectedItem as Materiel;
            ModifierMaterielFinal modifierMaterielFinal = new ModifierMaterielFinal(materielSelectionne);
            modifierMaterielFinal.Show();
        }

    }
}
