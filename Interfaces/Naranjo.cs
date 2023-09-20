using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Naranjo : Plantas
    {
        public override string DarFrutos(string temporada)
        {
            if (temporada.Contains("primavera"))
                return "da naranjas con más sabor por temporada";
            else if (temporada.Contains("verano"))
                return "da naranajas con más sabor por temporada";
            else if (temporada.Contains("otoño"))
                return "da naranjas con menos sabor por temporada";
            else if (temporada.Contains("invierno"))
                return "da naranjas con menos sabor por temporada";
            else
                return "da naranjas c:";
        }
    }
}
