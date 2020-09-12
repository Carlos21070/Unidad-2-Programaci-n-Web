using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticaMVC.Models
{
    public class Numeros
    {
        public int N1 { get; set; }
        public int N2 { get; set; }

        public int Suma()
        {
            return N1 + N2;
        }
    }
}
