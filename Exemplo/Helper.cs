using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo
{
    public class Helper
    {




        public static double calculaFatorial(int n)
        {
            var fatorial = 1;

            for (var j = n; j >= 1; j--)
            {
                fatorial *= j;
            }

            return fatorial;
        }
    }
}
