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
    public partial class SupprimerCategorie : Window
    {
        public Categorie Categorie { get; set; }
        public SupprimerCategorie()
        {
            InitializeComponent();
        }

        public SupprimerCategorie(Categorie categorie)
        {
            InitializeComponent();
            this.Categorie = categorie;
            lvSupprimerCategorie.SelectedItem= categorie;
        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Categorie categorieSupprimee = lvSupprimerCategorie.SelectedItem as Categorie;
            categorieSupprimee.Delete();
        }

        
    }
}
