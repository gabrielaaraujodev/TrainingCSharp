using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio6
{
    internal class Exercicio6
    {
        static void Main(string[] args)
        {
            int option; double temp, c, f, k;

            do
            {
                Console.WriteLine("1 - Converter de Celsius para Fahrenheit");
                Console.WriteLine("2 - Converter de Celsius para Kelvin");
                Console.WriteLine("3 - Converter de Fahrenheit para Celsius");
                Console.WriteLine("4 - Converter de Fahrenheit para Kelvin");
                Console.WriteLine("5 - Converter de Kelvin para Celsius");
                Console.WriteLine("6 - Converter de Kelvin para Fahrenheit");
                Console.WriteLine("7 - Sair");
                option = int.Parse(Console.ReadLine());

                if (option == '7') {
                    Console.WriteLine("Opção Inválida !");
                } else
                {
                    Console.WriteLine("Informe a 1ª temperatura: ");
                    temp = double.Parse(Console.ReadLine());

                    switch (option)
                    {
                        case 1:
                            f = 1.8 * temp + 32;
                            Console.WriteLine("A temperatura será: ");
                        break;

                        case 2:
                            k = temp + 273;
                            Console.WriteLine("A temperatura será: ");
                            break;

                        case 3:
                            c = (temp - 32) / 1.8;
                            Console.WriteLine("A temperatura será: ");
                            break;

                        case 4:
                            k = (temp - 32) * 5 / 282;
                            Console.WriteLine("A temperatura será: ");
                            break;

                        case 5:
                            c = temp - 273;
                            Console.WriteLine("A temperatura será: ");
                            break;

                        case 6:
                            f = (temp - 273) * 1.8 + 32;
                            Console.WriteLine("A temperatura será: ");
                            break;
                    }
                }



            } while (option != '7');
        }
    }
}
