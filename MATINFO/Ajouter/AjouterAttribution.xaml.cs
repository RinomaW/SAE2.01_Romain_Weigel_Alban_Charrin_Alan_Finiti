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

    /// <summary>
    /// Logique d'interaction pour AjouterAttribution.xaml
    /// </summary>
    public partial class AjouterAttribution : Window
    {
        string tbtexte;
        string idPerso;
        string idMate;
        DateTime date;
        public AjouterAttribution(Attribution atr,Window owner)
        {
            this.Owner = owner;
            InitializeComponent();
            DataContext= atr;
            cbMaterielChoix.ItemsSource = ((ApplicationData)owner.DataContext).LesMateriels;
            cbChoixPersonnel.ItemsSource = ((ApplicationData)owner.DataContext).LesPersonnels;
        }

        private void TBComm_GotFocus(object sender, RoutedEventArgs e)
        {
            this.TBComm.Text = "";
        }

        private void TBComm_TextChanged(object sender, TextChangedEventArgs e)
        {
          string tbtexte = TBComm.Text;

        }



        private void DPDate_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            date = this.DPDate.SelectedDate.Value;
        }

        private void TBCreer_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TBComm.Text))
                MessageBox.Show(this.Owner, "Pas possible!", "Pb", MessageBoxButton.OK, MessageBoxImage.Error);
            else
            {
                new Attribution(TBComm.Text, DateTime.Now, ((Materiel)cbMaterielChoix.SelectionBoxItem).ID_Materiel, ((Personnel)cbChoixPersonnel.SelectionBoxItem).ID_Personnel ).Create();
                ((ApplicationData)Owner.DataContext).Recharge();
                this.Close();
            }

        }

        
    }
}
