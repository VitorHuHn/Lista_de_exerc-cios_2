using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double p1;
            double p2;
            double media;

            Console.Write("Informe o valor da P1: ");
            p1 = double.Parse(Console.ReadLine());
            Console.Write("Informe o valor da P2: ");
            p2 = double.Parse(Console.ReadLine());

            media = p1 + (2 * p2);
            media = media / 3;

            if (media >= 5)
            {
                Console.Write("Aluno Aprovado!");
            }
            else
            {
                Console.Write("Aluno Reprovado!");
            }
        }
    }
}
