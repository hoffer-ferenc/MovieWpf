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
using System.Data.SqlClient;
using System.Data;
using System.IO;


namespace Moziwpf
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Felholvas();
        }
       
        private void belep_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection("Data Source=DESKTOP-94S9BT1;Initial Catalog=belepes;Integrated Security=True");
            //SqlCommand cmd = new SqlCommand("select * from belep where felhnev='" + nev.Text + "' and jelszo='" + jelszo.Text + "'", con);
            //SqlDataAdapter sda = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //sda.Fill(dt);
            //string ertek = ((ComboBoxItem)comboBox.SelectedItem).Tag.ToString();
            //if (dt.Rows.Count > 0)
            //{
            //    for (int i = 0; i < dt.Rows.Count; i++)
            //    {
            //        if (dt.Rows[i]["tipus"].ToString() == ertek)
            //        {
            //            MessageBox.Show("Sikeresen belépve : " + dt.Rows[i][2] + "-ként");
            //            if (comboBox.SelectedIndex == 0)
            //            {
            //                Window1 ablak = new Window1();
            //                ablak.Owner = this;
            //                ablak.Show();
            //                this.Hide();

            //            }
            //            else
            //            {
            //                Window1 bWin = new Window1();
            //                bWin.Owner = this;
            //                bWin.Show();
            //                this.Hide();
            //            }
            //        }
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Hiba!");
            //}
            List<felh> felhasznalo = new List<felh>();
            using (var reader = new StreamReader("felh.txt"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var ertek = line.Split('\t');
                    List<int> moziid = new List<int>();

                    felhasznalo.Add(new felh
                    {
                        ID = int.Parse(ertek[0]),
                        Nev = ertek[1],
                        jelszo = ertek[2],
                        jogosultsag = ertek[3],
                        Moziid = moziid

                    });
                    if (ertek[4] != "")
                    {
                        foreach (string item in ertek[4].Split(','))
                        {
                            moziid.Add(int.Parse(item));
                        }
                    }
                }
            }
            string ertek3 = "";
            if (((ComboBoxItem)comboBox.SelectedItem).Tag.ToString() != null)
            {
                ertek3 = ((ComboBoxItem)comboBox.SelectedItem).Tag.ToString();
            }
            else
            {
                MessageBox.Show("Kérem válassza ki a felhasználó típusát!");
            }
            using (StreamReader sr = new StreamReader("felh.txt"))
                {
                    while (!sr.EndOfStream)
                    {
                        var sor = sr.ReadLine();
                        var ertek2 = sor.Split('\t');
                    // ha latogato 
                    if (ertek2[1] == nev.Text && ertek2[2] == jelszo.Text && ertek2[3] == ertek3 && ertek2[3] == "latogato")
                    {
                        mozivagyfilm ablak = new mozivagyfilm();
                        ablak.Owner = this;
                        ablak.Show();
                        this.Hide();
                    }
                    //ha uzemelteto
                    if (ertek2[1] == nev.Text && ertek2[2] == jelszo.Text && ertek2[3] == ertek3 && ertek2[3] == "uzemelteto")
                    {
                        uzemeltetovalasztas ablak = new uzemeltetovalasztas();
                        ablak.Owner = this;
                        ablak.Show();
                        this.Hide();
                    }
                    //if(ertek2[1] == "" || ertek2[2] == "" || ertek2[3] == "")
                    //{
                    //    MessageBox.Show("hiba a belépés során");
                    //}

                }
                }
         



        }

        //beolvasott felh lista
        public static List<felh> Felholvas()
        {
            List<felh> felhasznalo = new List<felh>();
            using (var reader = new StreamReader("felh.txt"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var ertek = line.Split('\t');
                    List<int> moziid = new List<int>();

                    felhasznalo.Add(new felh
                    {
                        
                        Nev = ertek[0],
                        jelszo = ertek[1],
                        jogosultsag = ertek[2],
                        Moziid = moziid

                    });
                    if (ertek[3] != "")
                    {
                        foreach (int item in ertek[3])
                        {
                            moziid.Add(item);
                        }
                    }
                }
            }
            
            return felhasznalo;

        }

        public static void Felh_ir()
        {
            using (StreamWriter iro = File.AppendText("felh.txt"))
            {
                foreach (var felh in adat.felhasznalok.Values)
                {
                    iro.Write($"{felh.ID}\t{felh.Nev}\t{felh.jelszo}\t{felh.jogosultsag}\t");
                    if (felh.jogosultsag == "latogato")
                    {

                        iro.Write($"0\n");

                    }
                    if (felh.jogosultsag == "uzemelteto")
                    {
                        iro.Write($"1\n");
                        //Random rnd = new Random();

                        //for (int i = 0; i < felh.Moziid.Count; i++)
                        //{
                        //    if (i == felh.Moziid.Count - 1)
                        //    {
                        //        felh.Moziid[i] = rnd.Next(0, 101);
                        //        iro.Write($"{felh.Moziid[i]}\n");
                        //        break;
                        //    }
                        //    iro.Write($"{rnd.Next(0, 101)},");
                        //}
                    }

                }
            }
        }

        private static int CountLines(string str)
        {
            if (str == null)
                throw new ArgumentNullException("str");
            if (str == string.Empty)
                return 0;
            int index = -1;
            int count = 0;
            while (-1 != (index = str.IndexOf(Environment.NewLine, index + 1)))
                count++;

            return count + 1;
        }

        private void regisztral_Click(object sender, EventArgs e)
        {
            if (nev.Text == "" || jelszo.Text == "" || ((ComboBoxItem)comboBox.SelectedItem).Tag.ToString() == "")
            {
                MessageBox.Show("Kérem töltsön ki minden adatot !!");
            }
            else
            {
            string ertek = ((ComboBoxItem)comboBox.SelectedItem).Tag.ToString();
            adat.felh = new felh();
            int x = 0;
            using (var reader = new StreamReader("felh.txt"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    x = CountLines(line);
                }
            }
            
            for (int i = 1; i < x; i++)
            {
                adat.felh.ID = i;
            }
            
            adat.felh.Nev = nev.Text;
            adat.felh.jelszo = jelszo.Text;
            adat.felh.jogosultsag = ertek;
            adat.felh.Moziid = new List<int>();
            adat.felhasznalok.Add(adat.felh.Nev, adat.felh);
            
            Felh_ir();
            MessageBox.Show("siker");
            }

        }
        

    }
}
