using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio7
{
    internal class Exercicio7
    {
        static void Main(string[] args)
        {
            double salary, fAli, sAli, tAli, foAli;
            char selection;

            
            do
            {
                Console.WriteLine("Informe o seu salário: ");
                salary = double.Parse(Console.ReadLine());

                if (salary <= 1412)
                {
                    fAli = (salary - 0) * 0.075 / 100;
                    Console.WriteLine("Total a recoler: " + Math.Round(fAli,2));
                }
                else if (salary <= 2666.68)
                {
                    fAli = (1412 - 0) * 0.075 / 100;
                    sAli = (salary - 1412.01) * 0.09 / 100;

                    Console.WriteLine("Total a recoler: " + Math.Round((fAli + sAli), 2));
                }
                else if (salary <= 4000.03)
                {
                    fAli = (1412 - 0) * 0.075 / 100;
                    sAli = (2666.68 - 1412.01) * 0.09 / 100;
                    tAli = (salary - 2666.69) * 0.12 / 100;

                    Console.WriteLine("Total a recoler: " +  Math.Round((fAli + sAli + tAli), 2));
                }
                else if (salary <= 7786.02)
                {
                    fAli = (1412 - 0) * 0.075 / 100;
                    sAli = (2666.68 - 1412.01) * 0.09 / 100;
                    tAli = (4000.03 - 2666.69) * 0.12 / 100;
                    foAli = (salary - 4000.04) * 0.14 / 100;

                    Console.WriteLine("Total a recoler: " + Math.Round((fAli + sAli + tAli + foAli), 2));
                } 
                else if(salary > 7786.02)
                {
                    fAli = (1412 - 0) * 0.075 / 100;
                    sAli = (2666.68 - 1412.01) * 0.09 / 100;
                    tAli = (4000.03 - 2666.69) * 0.12 / 100;
                    foAli = (7786.02 - 4000.04) * 0.14 / 100;

                    Console.WriteLine("Total a recoler: " + Math.Round((fAli + sAli + tAli + foAli), 2));
                }

                Console.WriteLine("Deseja informar mais um voto ? S/N");
                selection = char.Parse(Console.ReadLine());

            } while (selection == 'S');  
        }
    }
}
