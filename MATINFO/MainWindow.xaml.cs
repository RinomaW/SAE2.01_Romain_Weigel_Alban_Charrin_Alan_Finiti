using MATINFO.Model;
using MATINFO.ModifierFichier;
using MATINFO.Mofifier;
using MATINFO.Supprimer;
using System;
using System.Collections;
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
            CAPM CAPM = new CAPM(this);
            
            CAPM.Show();
        }

        private void BTModi(object sender, RoutedEventArgs e)
        {
            if(lvAttribution.SelectedItem!= null) 
            {
                ModifierAttributionFinal modifierAttributionFinal = new ModifierAttributionFinal(lvAttribution.SelectedItem as Attribution, this);
                modifierAttributionFinal.Show();                
            }
            else if (lvMateriel.SelectedItem != null)
            {
                ModifierMaterielFinal modifierMaterielFinal = new ModifierMaterielFinal(lvMateriel.SelectedItem as Materiel, this);
                modifierMaterielFinal.Show();
            }
            else if(lvCategorie.SelectedItem != null)
            {
                ModifierCategorieFinal modifierCategorieFinal = new ModifierCategorieFinal(lvCategorie.SelectedItem as Categorie, this);
                modifierCategorieFinal.Show();
            }
            else
            {
                ActionModifier Modifier = new ActionModifier(this);
                Modifier.Show();
            }
            
        }


        private void BTSuppr(object sender, RoutedEventArgs e)
        {
            //coubeh
            if (lvAttribution.SelectedItem != null)
            {
                DoubleClicSupprimer supprimerAttributionFinal = new DoubleClicSupprimer(lvAttribution.SelectedItem as Attribution);
                supprimerAttributionFinal.Show();

            }
            else if (lvMateriel.SelectedItem != null)
            {
                DoubleClicSupprimer supprimerMaterielFinal = new DoubleClicSupprimer(lvMateriel.SelectedItem as Materiel);
                supprimerMaterielFinal .Show();
            }
            else if (lvCategorie.SelectedItem != null)
            {
                DoubleClicSupprimer supprimerCategorieFinal = new DoubleClicSupprimer(lvCategorie.SelectedItem as Categorie);
                supprimerCategorieFinal.Show();
            }
            else
            {
                CAPMSuppr supprimer = new CAPMSuppr();
                supprimer.Show();
            }
           Refresh();

        }

        public void Refresh()
        {
            lvAttribution.Items.Refresh();
            lvCategorie.Items.Refresh();
            lvMateriel.Items.Refresh();
        }

        private void lvCategorie_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count > 0) 
            {
                ListBox listBox = sender as ListBox;
                var valid = e.AddedItems[0];
                foreach (var item in new ArrayList(listBox.SelectedItems))
                {
                    if (item != valid)
                    {
                        listBox.SelectedItems.Remove(item);
                    }
                }
            }
        }

        private void lvMateriel_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count > 0)
            {
                ListBox listBox = sender as ListBox;
                var valid = e.AddedItems[0];
                foreach (var item in new ArrayList(listBox.SelectedItems))
                {
                    if (item != valid)
                    {
                        listBox.SelectedItems.Remove(item);
                    }
                }
            }
        }


        private void lvAttribution_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count > 0)
            {
                ListBox listBox = sender as ListBox;
                var valid = e.AddedItems[0];
                foreach (var item in new ArrayList(listBox.SelectedItems))
                {
                    if (item != valid)
                    {
                        listBox.SelectedItems.Remove(item);
                    }
                }
            }
        }
    }
}
