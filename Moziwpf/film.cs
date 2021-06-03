using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moziwpf
{
    public class film
    {
        
        public string nev { get; set; }
       
        public List<string> mufaj { get; set; }
        
        public List<string> foszereplok { get; set; }
        
        public int filmhossz { get; set; }
        
        public DateTime vetitesdatum { get; set; }
        
        public int CinemaId { get; set; }
    }
}
