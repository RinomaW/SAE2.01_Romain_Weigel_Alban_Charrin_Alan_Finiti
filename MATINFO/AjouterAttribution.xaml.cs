using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace MATINFO
{
    /// <summary>
    /// Logique d'interaction pour AjouterAttribution.xaml
    /// </summary>
    public partial class AjouterAttribution : Window
    {
        public AjouterAttribution()
        {
            InitializeComponent();
        }

        private void TBComm_GotFocus(object sender, RoutedEventArgs e)
        {
            this.TBComm.Text = "";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
