using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio8
{
    internal class Exercicio8
    {
        static void Main(string[] args)
        {
            double number;
            int cont;

            Console.WriteLine("Informe um número: ");
            number = double.Parse(Console.ReadLine());

            for (cont = 1; number > 0; cont = cont + 2)
            {
                number = number - cont;

                Console.WriteLine(number);
            }

            Console.ReadLine();
        }
    }
}
