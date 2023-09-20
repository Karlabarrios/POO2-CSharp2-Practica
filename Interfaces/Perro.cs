using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Perro : AnimalesDomesticos, Biteable
    {
        public string Masticar()
        {
            return "*mastica*";
        }

        public string Morder()
        {
            return "*lo muerde*";
        }
    }
}
