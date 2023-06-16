using MATINFO.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Logique d'interaction pour ModifierCategorie.xaml
    /// </summary>
    
    public partial class ModifierCategorie : Window
    {

        public ObservableCollection<Categorie> LesCategories { get; set; }
        public Categorie categorieSelectionnee = new Categorie();
        public ModifierCategorie()
        {
            InitializeComponent();
            lvModifierCategorie.SelectedIndex= 0;
            this.DataContext = LesCategories;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            categorieSelectionnee = lvModifierCategorie.SelectedItem as Categorie;
            ModifierCategorieFinal modifierCategorieFinal= new ModifierCategorieFinal(categorieSelectionnee);
            modifierCategorieFinal.Show();
        }
    }
}
