using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double mediaMinima = 5;

            Console.Write("Digite a nota da P1: ");
            double p1 = double.Parse(Console.ReadLine());

            double p2Necessaria = (3 * mediaMinima - p1) / 2;

            if (p2Necessaria < 0)
            {
                p2Necessaria = 0;
            }

            Console.WriteLine($"O aluno precisa tirar no mínimo {p2Necessaria:F2} na P2 para ser aprovado.");
        }
    }
}
