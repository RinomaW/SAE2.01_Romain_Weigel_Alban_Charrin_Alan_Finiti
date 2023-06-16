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
    /// Logique d'interaction pour ModifierMaterielFinal.xaml
    /// </summary>
    public partial class ModifierMaterielFinal : Window
    {
        public Materiel MaterielSelectionne { get; set; }
        public ModifierMaterielFinal(Materiel materiel)
        {
            this.MaterielSelectionne= materiel;
            InitializeComponent();
            this.DataContext = materiel;
        }

        // changer le zboub en l'item selectionné dans le menu déroulant mais je sais pas faire
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MaterielSelectionne.Update(tbCodeBarre.Text, tbNom.Text, tbRef.Text, "zboub");
        }
    }
}
