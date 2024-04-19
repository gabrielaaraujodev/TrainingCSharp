using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exemplo;

namespace Exemplo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int repeat, parcela;
            double total = 1;

            Console.WriteLine("Informe a quantidade de vezes que o fatorial irá repetir: ");
            repeat = int.Parse(Console.ReadLine());

            for (parcela = 1; parcela <= repeat; parcela++)
            {
                var fatorial = Helper.calculaFatorial(parcela);

                var valorParcela = 1 / (double)fatorial;

                total += valorParcela;
            }
        }

        
    }
}
