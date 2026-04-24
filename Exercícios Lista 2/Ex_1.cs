using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_OP_LG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;

            Console.Write("Informe o primeiro valor: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Informe o primeiro valor: ");
            b = int.Parse(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("O Primeiro Valor é Maior!");
            }
            else
            {
                Console.WriteLine("O Segundo Valor é Maior!");
            }
        }
    }
}
