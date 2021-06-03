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
using System.IO;

namespace Moziwpf
{
    /// <summary>
    /// Interaction logic for filmek.xaml
    /// </summary>
    public partial class filmek : Window
    {
        public filmek()
        {
            InitializeComponent();
            McDataGrid.ItemsSource = Filmolvaso();
            List<film> filmes = new List<film>();
            filmes = Filmolvaso();
            this.McDataGrid.ItemsSource = filmes;
        }
        public static List<film> Filmolvaso()
        {
            List<film> result = new List<film>();
            using (var sr = new StreamReader("Filmek.txt"))
            {
                while (!sr.EndOfStream)
                {
                    var sor = sr.ReadLine();
                    var ertek = sor.Split('\t');
                    result.Add(new film
                    {
                        nev = ertek[0],
                        mufaj = new List<string>(ertek[1].Split(',')),
                        foszereplok = new List<string>(ertek[2].Split(',')),
                        filmhossz = int.Parse(ertek[3]),
                        vetitesdatum = DateTime.ParseExact(ertek[4], "yyyy.MM.dd HH:mm", null),
                        CinemaId = int.Parse(ertek[5])
                    });
                }
            }
            
            return result;
        }
        public void textBox1_KeyUp(object sender, System.Windows.Input.KeyEventArgs e)
        {
            
            var keres = Filmolvaso().Where(film => film.nev.StartsWith(textBox1.Text));

            McDataGrid.ItemsSource = keres;
        }
    }
}
