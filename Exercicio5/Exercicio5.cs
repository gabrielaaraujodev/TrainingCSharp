using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5
{
    class Exercicio5
    {
        static void Main(string[] args)
        {
            int cont = 1, option, voteOne = 0, voteTwo = 0, voteThree = 0, voteNull = 0;
            char selection;

            do
            {
                Console.WriteLine("Digite 1 para o PRIMEIRO candidato");
                Console.WriteLine("Digite 2 para o SEGUNDO candidato");
                Console.WriteLine("Digite 3 para o TERCEIRO candidato");
                Console.WriteLine("Digite 4 para votar em BRANCO");
                option = int.Parse(Console.ReadLine());

                if (option == 1)
                {
                    voteOne++;
                } else if (option == 2)
                {
                    voteTwo++;
                } else if (option == 3)
                {
                    voteThree++;
                } else if (option == 4)
                {
                    voteNull++;
                }

                Console.WriteLine("Deseja informar mais um voto ? S/N");
                selection = char.Parse(Console.ReadLine());

                cont++;

            } while (selection == 'S');

            Console.WriteLine("O 1° candidato recebeu: " + voteOne);
            Console.WriteLine("O 2° candidato recebeu: " + voteTwo);
            Console.WriteLine("O 3° candidato recebeu: " + voteThree);


        }
    }
}
