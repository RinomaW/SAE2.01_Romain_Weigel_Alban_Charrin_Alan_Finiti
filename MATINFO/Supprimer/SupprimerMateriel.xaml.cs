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
    public partial class SupprimerMateriel : Window
    {
        
        public SupprimerMateriel()
        {
            InitializeComponent();
        }

        private void TBNom_GotFocus(object sender, RoutedEventArgs e)
        {
            this.TBNom.Text = "";
        }

        private void TBEmail_GotFocus(object sender, RoutedEventArgs e)
        {
            this.TBEmail.Text = "";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           //string texte = "insert into attribution values ('" +id perso ""+"" id materiel ""+"" DateOnly"" + ",'"+tbtexte +"')";
           //DataAccess accesBD = new DataAccess();
           //String requete = 
           //accesBD.SetData(requete);
            
        }

        private void TBComm_TextChanged(object sender, TextChangedEventArgs e)
        {
            //string tbtexte = TBComm.Text;

        }

        private void TBPrenom_GotFocus(object sender, RoutedEventArgs e)
        {
            this.TBPrenom.Text = "";
        }
    }
}
