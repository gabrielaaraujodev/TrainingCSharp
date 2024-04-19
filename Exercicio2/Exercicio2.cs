using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class Exercicio2
    {
        static void Main(string[] args)
        {
            int repeat, parcela, j;
            double total = 1;

            Console.WriteLine("Informe a quantidade de vezes que o fatorial irá repetir: ");
            repeat = int.Parse(Console.ReadLine());


            for (parcela = 1; parcela <= repeat; parcela++) // Calculo de cada parcela.
            {
                var fatorial = 1;

                for (j = parcela; j >= 1; j--)
                {
                    fatorial *= j;
                }

                var valorParcela = 1 / (double)fatorial;

                total += parcela;

            }

            Console.WriteLine(total);
            Console.ReadLine();
        }
    }
}
