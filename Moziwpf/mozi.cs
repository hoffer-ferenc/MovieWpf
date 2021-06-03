using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moziwpf
{
    public class mozi
    {
        public int ID { get; set; }
        public string Megye { get; set; }
        public string Varos { get; set; }
        public string Utca { get; set; }
        public string Hazszam { get; set; }
        public Dictionary<int, mozi> Movies { get; set; }
        
    }
}
