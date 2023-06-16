using MATINFO.Mofifier;
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
    /// Logique d'interaction pour Modifier.xaml
    /// </summary>
    public partial class Modifier : Window
    {
        public Modifier()
        {
            InitializeComponent();
        }

        
        private void BTcateMBDWN(object sender, MouseButtonEventArgs e)
        {
            ModifierCategorie modifCate = new ModifierCategorie();
            this.Close();
            modifCate.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            ModifierCategorie modifierCategorie = new ModifierCategorie();
            modifierCategorie.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            ModifierMateriel modifierMateriel = new ModifierMateriel();
            modifierMateriel.Show();
        }
    }
}
