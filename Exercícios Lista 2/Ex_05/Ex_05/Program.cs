using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int area;

            Console.Write("Informe a medida da altura do terreno: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Informe a medida da base do terreno: ");
            b = int.Parse(Console.ReadLine());

            area = a * b;

            if (area > 100)
            {
                Console.WriteLine("Terreno Grande");
            }
            else
            {
                Console.WriteLine("Terreno Pequeno");
            }
        }
    }
}
