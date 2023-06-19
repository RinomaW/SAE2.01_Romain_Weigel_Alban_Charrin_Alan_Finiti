using MATINFO.Model;
using MATINFO.ModifierFichier;
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

namespace MATINFO.Modifier
{
    /// <summary>
    /// Logique d'interaction pour ModifierPersonnel.xaml
    /// </summary>
    public partial class ModifierPersonnel : Window
    {
        public ModifierPersonnel()
        {
            InitializeComponent();
        }

        private void BTModi_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility= Visibility.Hidden;
            ModifierPersonnel modifierPersonnel = new ModifierPersonnel();
            modifierPersonnel.Show();
        }
    }
}
