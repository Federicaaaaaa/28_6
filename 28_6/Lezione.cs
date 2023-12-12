using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_6
{
    internal class Lezione
    {
        public string Descrizione{ get; set; }
        public DateTime Data { get; set; }
        public DateTime OrarioInizio{ get; set; }
        public TimeSpan Durata { get; set; }
        public Docente Docente { get; set; }
        public Aula AulaAssegnata { get; set; }
    }
}
