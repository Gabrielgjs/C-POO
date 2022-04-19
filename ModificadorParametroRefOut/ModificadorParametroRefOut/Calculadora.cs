using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModificadorParametroRefOut
{
    class Calculadora
    {
        public static void Triplicar(ref int x)
        {
            x = x * 3;
        }

    }
}
