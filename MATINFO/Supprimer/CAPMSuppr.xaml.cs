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

namespace MATINFO
{
    /// <summary>
    /// Logique d'interaction pour CAPM.xaml
    /// </summary>
    public partial class CAPMSuppr : Window
    {
        public CAPMSuppr()
        {
            InitializeComponent();
        }

      


        private void BTCate_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            AjouterCategorie ajoutCate = new AjouterCategorie();
            ajoutCate.Show();
        }

        private void BTAttri_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            AjouterAttribution ajoutAttri = new AjouterAttribution();
            ajoutAttri.Show();
        }

        private void BTPerso_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            AjouterPersonnel ajoutPerso = new AjouterPersonnel();
            ajoutPerso.Show();
        }
    }
}
