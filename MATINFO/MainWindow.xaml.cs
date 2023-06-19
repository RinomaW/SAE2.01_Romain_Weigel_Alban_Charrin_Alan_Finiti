using MATINFO.Model;
using MATINFO.ModifierFichier;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MATINFO
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {//feur
            InitializeComponent();
            DataContext = applicationData;
        }

        private void BTAjout(object sender, RoutedEventArgs e)
        {
            CAPM CAPM = new CAPM();
            
            CAPM.Show();
        }

        private void BTModi(object sender, RoutedEventArgs e)
        {
            if(lvAttribution.SelectedItem!= null) 
            {
                ModifierAttributionFinal modifierAttributionFinal = new ModifierAttributionFinal(lvAttribution.SelectedItem as Attribution);
                modifierAttributionFinal.Show();                
            }
            else if (lvMateriel.SelectedItem != null)
            {
                ModifierMaterielFinal modifierMaterielFinal = new ModifierMaterielFinal(lvMateriel.SelectedItem as Materiel);
                modifierMaterielFinal.Show();
            }
            else if(lvCategorie.SelectedItem != null)
            {
                ModifierCategorieFinal modifierCategorieFinal = new ModifierCategorieFinal(lvCategorie.SelectedItem as Categorie);
                modifierCategorieFinal.Show();
            }
            else
            {
                ActionModifier Modifier = new ActionModifier();
                Modifier.Show();
            }
            
        }

        private void lvCategorie_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void BTSuppr(object sender, RoutedEventArgs e)
        {
            if (lvAttribution.SelectedItem != null)
            {
                Attribution modifierAttributionFinal = lvAttribution.SelectedItem as Attribution;
                modifierAttributionFinal.Delete();

            }
            else if (lvMateriel.SelectedItem != null)
            {
                Materiel modifierMaterielFinal = lvMateriel.SelectedItem as Materiel;
                modifierMaterielFinal.Delete();
            }
            else if (lvCategorie.SelectedItem != null)
            {
                Categorie modifierCategorieFinal = lvCategorie.SelectedItem as Categorie;
                modifierCategorieFinal.Delete();
            }
            else
            {
                CAPMSuppr supprimer = new CAPMSuppr();
                supprimer.Show();
            }
        }
    }
}
