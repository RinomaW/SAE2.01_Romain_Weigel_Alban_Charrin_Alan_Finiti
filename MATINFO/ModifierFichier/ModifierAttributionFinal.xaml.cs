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

namespace MATINFO.ModifierFichier
{
    /// <summary>
    /// Logique d'interaction pour ModifierAttributionFinal.xaml
    /// </summary>
    public partial class ModifierAttributionFinal : Window
    {
        public Attribution AttributionModifiee { get; set; }
        public ModifierAttributionFinal( Attribution attributionModifiee, Window owner)
        {
            this.Owner = owner;
            InitializeComponent();
            this.AttributionModifiee= attributionModifiee;
        }

        private void BTModi_Click(object sender, RoutedEventArgs e)
        {
            this.AttributionModifiee.CommentaireAttribution = tbCommentaireAttribution.Text;
            this.AttributionModifiee.DateAttribution = DateTime.Parse(tbDate.Text);
            this.AttributionModifiee.IdMateriel = ((Materiel)cbMaterielChoisi.SelectedItem).ID_Materiel;
            this.AttributionModifiee.IdPersonnels = ((Personnel)cbPersonnelChoisi.SelectedItem).ID_Personnel;
            AttributionModifiee.Update();
            this.Close();
        }
    }
}
