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
            lvCategorie.SelectedIndex= 0;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CAPM CAPM = new CAPM();
            
            CAPM.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Modifier Modifier = new Modifier();
            Modifier.Show();
        }

        private void lvCategorie_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lvCategorie.SelectedIndex != 0)
            {
                lvMateriel.SelectedItem = lvCategorie.SelectedItem;
            }
        }
    }
}
