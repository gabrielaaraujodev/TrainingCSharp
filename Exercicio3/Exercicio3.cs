using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    class Exercicio3
    {
        static void Main(string[] args)
        {
            int cont;
            double price, amount, total, bigger, smaller, media = 0;

            Console.WriteLine("Preço do kWh: ");
            price = double.Parse(Console.ReadLine()); 

            Console.WriteLine("Quantidade do kWh consumidos no mês: ");
            amount = double.Parse(Console.ReadLine());

            bigger = amount; 
            smaller = amount;

            total = price * amount;

            total = media;
            Console.WriteLine("O valor total a pagar do 1º consumidor é: " + total);

            for (cont = 2; cont < 5; cont++)
            {
                Console.WriteLine("Preço do kWh: ");
                price = double.Parse(Console.ReadLine()); 

                Console.WriteLine("Quantidade do kWh consumidos no mês: ");
                amount = double.Parse(Console.ReadLine()); 

                total = price * amount; 

                if (amount > bigger) 
                {
                    bigger = amount;
                } 
                
                if (amount < smaller) 
                {
                    smaller = amount;
                }

                Console.WriteLine($"O valor total a pagar do {cont} consumidor é: " + total);

                media += amount;
                
            }

            Console.WriteLine("O maior valor consumido é: " + bigger);
            Console.WriteLine("O menor valor consumido é: " + smaller);
            Console.WriteLine("A média dos valores consumidos é: "  + (media/50));

            Console.ReadLine();

        }
    }
}
