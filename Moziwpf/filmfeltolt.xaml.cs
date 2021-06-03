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
using System.Data.SqlClient;
using System.IO;

namespace Moziwpf
{
    /// <summary>
    /// Interaction logic for filmfeltolt.xaml
    /// </summary>
    public partial class filmfeltolt : Window
    {
        public filmfeltolt()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            /*
            using (StreamReader sr = new StreamReader(File.Open("Filmek.txt", FileMode.Open))) // "C:\\musor.txt"
            {
                using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-94S9BT1;Initial Catalog=belepes;Integrated Security=True"))
                {
                    con.Open();
                    string line = "";
                    while ((line = sr.ReadLine()) != "")
                    {
                        string[] parts = line.Split(new string[] { "\t" }, StringSplitOptions.None);
                        string cmdTxt = String.Format("INSERT INTO dbo.musor(mufaj,foszereplo,filmhossz,datum,idopont) VALUES ('{0}','{1}','{2}','{3}','{4}')", parts[0], parts[1], parts[2], parts[3], parts[4]);
                        using (SqlCommand cmddd = new SqlCommand(cmdTxt, con))
                        {
                            cmddd.ExecuteNonQuery();
                            int eredmeny = cmddd.ExecuteNonQuery();
                            if (eredmeny < 0)
                            {
                                MessageBox.Show("hiba tortent a feltoltes kozben!");
                            }
                            else
                            {
                                MessageBox.Show("Sikeres feltöltés! ");
                            }
                        }
                    }
                }
            } */
        }


    }
}
