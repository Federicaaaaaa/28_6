using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_6
{
    internal class Corso
    {
        public string Nome{ get; set; }
        public int NumeroEdizione { get; set; }
        public int NumeroLezioni { get; set; }
        public virtual Lezione Lezioni() 
        {
            return new Lezione();
        }
        public int StudentiIscritti { get; set; }
        public virtual Studente Studenti()
        {
            return new Studente();
        }

    }
}
