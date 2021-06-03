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

namespace Moziwpf
{
    /// <summary>
    /// Interaction logic for mozivagyfilm.xaml
    /// </summary>
    public partial class mozivagyfilm : Window
    {
        public mozivagyfilm()
        {
            InitializeComponent();
        }

        private void mozi_Click(object sender, RoutedEventArgs e)
        {
            Window1 ablak = new Window1();
            ablak.Owner = this;
            ablak.Show();
            this.Hide();
        }

        private void film_Click(object sender, RoutedEventArgs e)
        {
            filmek ablak = new filmek();
            ablak.Owner = this;
            ablak.Show();
            this.Hide();
        }
    }
}
