using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_6
{
    enum Risorse
    {
        VideoProiettore, 
        PC, 
        Notebook,
        Tablet, 
        LIM
    }
    internal class Aula
    {
        public int Capienza { get; set; }
        public int Nome { get;set; }
        public Risorse Risorsa { get; set; }
    }
}
