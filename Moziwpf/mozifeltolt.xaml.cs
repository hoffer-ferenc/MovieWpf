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
    /// Interaction logic for mozifeltolt.xaml
    /// </summary>
    public partial class mozifeltolt : Window
    {
        public mozifeltolt()
        {
            InitializeComponent();
            //adat.LoadData();
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
            
            //betolti az adott értékeket
            mozi mozi = new mozi();
            mozi.ID = adat.Cinemas.Values.Count + 1;
            mozi.Megye = megye.Text;
            mozi.Varos = varos.Text;
            mozi.Utca = utca.Text;
            mozi.Hazszam = hazszam.Text;
            mozi.Movies = new Dictionary<int, mozi>();
            
            adat.Cinemas.Add(mozi.ID, mozi);
            // adat.felh.Moziid.Add(mozi.ID);
            
           // Moziolvaso();
            Mozi_mentes();
            Console.WriteLine(mozi.ID);
        }
        public static void Mozi_mentes()
        {
            using (StreamWriter iro = File.AppendText("mozik.txt"))
            {
                foreach (mozi mozi in adat.Cinemas.Values)
                {
                    iro.WriteLine($"{mozi.ID}\t{mozi.Megye}\t{mozi.Varos}\t{mozi.Utca}\t{mozi.Hazszam}");
                }
            }
        }
       

    }
}
