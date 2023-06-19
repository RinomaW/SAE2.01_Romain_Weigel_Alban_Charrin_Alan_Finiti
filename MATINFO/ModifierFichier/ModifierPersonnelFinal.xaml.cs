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
using System.Windows.Shapes;

namespace MATINFO.ModifierFichier
{
    /// <summary>
    /// Logique d'interaction pour ModifierPersonnelFinal.xaml
    /// </summary>
    public partial class ModifierPersonnelFinal : Window
    {
       
        public Personnel PersonnelSelectionne { get; set; }
        public ModifierPersonnelFinal( Personnel personnelSelectionne)
        {
            InitializeComponent();
            this.PersonnelSelectionne= personnelSelectionne;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PersonnelSelectionne.Update(tbNomPersonnel.Text,tbPrenomPersonnel.Text,tbEmailPersonnel.Text);
        }
    }
}
