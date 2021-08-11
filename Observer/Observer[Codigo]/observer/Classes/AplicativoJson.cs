using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observer.Classes
{
    public class AplicativoJson
    {
        public bool Ativo { get; set; }     
        public string Diretorio { get; set; }
        public string Nome { get; set; }
        public EmailStatus Email { get; set; }
        public Reabrir ReOpen { get; set; }
        public ReabrirCrash CaseCrashApp { get; set; }
        public Relatorio Log { get; set; }
        public AplicativoJson() { }
    }
}
