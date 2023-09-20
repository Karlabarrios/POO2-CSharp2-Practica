using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones1
{
    class Ave
    {
        public string Nombre { get; set; }
        public string Color { get; set; }
        public int Edad { get; set; }

        public string Cantar()
        {
            return "*Canta*";
        }
        public string Cantar(string tipoAve)
        {
            if (tipoAve.Contains("pinguino"))
                return "snort snort";
            else if (tipoAve.Contains("aguila"))
                return "quiiiii";
            else if (tipoAve.Contains("paloma"))
                return "curru curru";
            else
                return "*canta*";
        }
    }
}
