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

    public partial class SupprimerPersonnel : Window
    {
        
        public SupprimerPersonnel()
        {
            InitializeComponent();
        }


        private void BTSuppr_Click(object sender, RoutedEventArgs e)
        {
             Personnel personnelSupprimee = lvSupprimerPersonnel.SelectedItem as Personnel;
            personnelSupprimee.Delete();
            this.Close();
        }
    }
}
