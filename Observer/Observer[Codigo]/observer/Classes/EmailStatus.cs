using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observer.Classes
{
    public class EmailStatus
    {
        public bool Ativo { get; set; }
        public TimeSpan Intervalo { get; set; }
        public List<string> Lista { get; set; }
        public EmailStatus() { }
    }
}
