using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moziwpf
{
    public class adat
    {
            public static Dictionary<int, mozi> Cinemas = new Dictionary<int, mozi>();
            
            public static Dictionary<string, felh> felhasznalok = new Dictionary<string, felh>();
           
            public static felh felh = null;
            public static void LoadData()
            {
            List<mozi> result = Window1.Moziolvaso(); ;
                foreach (var item in result)
                {
                    Cinemas.Add(item.ID, item);
                }
                List<felh> felh = MainWindow.Felholvas();
                int i = 0;
                foreach (var item in felh)
                {
                    item.ID = ++i;
                    //felhasznalok.Add(item.Nev, item);
                }
            }
        }
    }

