using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Manzano : Plantas
    {
        public override string DarFrutos(string temporada)
        {
            if (temporada.Contains("primavera"))
                return "da manzánas con más sabor por temporada";
            else if (temporada.Contains("verano"))
                return "da manzánas con más sabor por temporada";
            else if (temporada.Contains("otoño"))
                return "da manzánas con menos sabor por temporada";
            else if (temporada.Contains("invierno"))
                return "da manzánas con menos sabor por temporada";
            else
                return "da manzánas c:";
        }
    }
}
