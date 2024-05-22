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

namespace instailerJarvis
{
    /// <summary>
    /// Логика взаимодействия для soglash.xaml
    /// </summary>
    public partial class soglash : Window
    {
        public soglash()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("А дальше нету(");
        }
        private void otmena(object sender, RoutedEventArgs e) { Close(); }
    }
}
