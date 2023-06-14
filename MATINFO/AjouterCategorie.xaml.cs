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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MATINFO
{
    /// <summary>
    /// Logique d'interaction pour AjouterCategorie.xaml
    /// </summary>
    public partial class AjouterCategorie : Window
    {
        public AjouterCategorie()
        {
            InitializeComponent();
        }

        string texte;

        private void TBNomCate_TextChanged(object sender, TextChangedEventArgs e)
        {
            texte = this.TBNomCate.Text;
        }

        private void TBNomCate_GotFocus(object sender, RoutedEventArgs e)
        {
            this.TBNomCate.Text = "";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            String requete = "insert into categorie values ('" +texte+"')";
            DataAccess accesBD = new DataAccess();
            accesBD.SetData(requete);
        }

        
    }
}
