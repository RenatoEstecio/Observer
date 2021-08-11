using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observer.Classes
{
    public class Relatorio
    {
        public bool Ativo { get; set; }
        public TimeSpan Intervalo { get; set; }
        public Relatorio() { }
    }
}
