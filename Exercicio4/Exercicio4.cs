using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    class Exercicio4
    {
        static void Main(string[] args)
        {
            int cont;
            double temperature, bigger, smaller;

                Console.WriteLine("Informe a temperatura média em BH no 1º dia de Abril: ");
                temperature = double.Parse(Console.ReadLine());

            bigger = temperature;
            smaller = temperature;

            for(cont = 2; cont < 31; cont++)
            {
                Console.WriteLine($"Informe a temperatura média em BH no {cont}º dia de Abril: ");
                temperature = double.Parse(Console.ReadLine());

                if (temperature > bigger)
                {
                    bigger = temperature;
                }

                if (temperature < smaller)
                {
                    smaller = temperature;
                }
            }

            Console.WriteLine("A maior temperatura média de BH é: " + bigger);
            Console.WriteLine("A menor temperatura média de BH é: " + smaller);

            Console.ReadLine();

        }
    }
}
