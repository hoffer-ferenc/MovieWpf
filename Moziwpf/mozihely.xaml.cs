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
using System.Data;
using System.IO;

namespace Moziwpf
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        
        public Window1()
        {
            InitializeComponent();
            McDataGrid.ItemsSource = Moziolvaso();
        }
        // mozi osztály lista feltöltése txtből
        public static List<mozi> Moziolvaso()
        {
            List<mozi> result = new List<mozi>();
            using (var reader = new StreamReader("mozik.txt"))
            {
                while (!reader.EndOfStream)
                {
                    var sor = reader.ReadLine();
                    var ertek = sor.Split('\t');
                    result.Add(new mozi
                    {
                        ID = int.Parse(ertek[0]),
                        Megye = ertek[1],
                        Varos = ertek[2],
                        Utca = ertek[3],
                        Hazszam = ertek[4],

                        Movies = new Dictionary<int, mozi>()
                    });
                }
            }     
            return result;
        }
        

        //szűrés városra
        public void textBox1_KeyUp(object sender, System.Windows.Input.KeyEventArgs e)
        {
           
            var keres = Moziolvaso().Where(mozi => mozi.Varos.StartsWith(textBox1.Text));

            McDataGrid.ItemsSource = keres;
        }
    }
}
