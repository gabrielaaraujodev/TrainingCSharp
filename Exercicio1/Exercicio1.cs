using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class Exercicio1
    {
        static void Main(string[] args)
        {
            int cont;
            double food, transp, metros, value;

            for (cont = 1; cont <= 25; cont++)
            {
                

                Console.WriteLine($"O {cont}° pedreiro tem vale-alimentação de: ");
                food = double.Parse(Console.ReadLine());

                Console.WriteLine($"O {cont}° pedreiro tem vale-transporte de: ");
                transp = double.Parse(Console.ReadLine());

                transp = transp * 2;

                Console.WriteLine($"O {cont}° pedreiro produziu quantos metros quadrados:");
                metros = double.Parse(Console.ReadLine());

                if (metros < 10)
                {
                    value = metros * 10;
                } else if (metros <= 20)
                {
                    value = metros * 11.50;
                } else
                {
                    value = metros * 13;
                }

                Console.WriteLine("");

                Console.WriteLine($"O {cont} pedreiro possui o vale-alimentação de: R$ " + food + " o vale-transporte de: R$ " + " e vai receber: " + value + " por " + metros + " reais quadrados produzidos.");

                Console.WriteLine("");
            }

            Console.ReadLine();
        }
    }
}
