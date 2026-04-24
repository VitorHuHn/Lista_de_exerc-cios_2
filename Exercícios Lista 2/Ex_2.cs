using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;

            Console.Write("Informe o primerio valor: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Informe o primerio valor: ");
            b = int.Parse(Console.ReadLine());

            if (a == b)
            {
                Console.WriteLine("Os Valores são Identicos");
            }
            else
            {
                if (a > b)
                {
                    Console.WriteLine("1º Valor é maior");
                }
                else
                {
                    Console.WriteLine("2º Valor é maior");
                }
            }
        }
    }
}
