using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Plantas : SeresVivos
    {
        public string Tipo { get; set; }
        public virtual string DarFrutos()
        {
            return "su tipo de frutos";
        }
        public virtual string DarFrutos(string temporada)
        {
            return "su tipo de frutos con más sabor por temporada";
        }

        public override string Comunicarse()
        {
            return "*emite sonidos más o menos imperseptibles*";
        }
    }
}
