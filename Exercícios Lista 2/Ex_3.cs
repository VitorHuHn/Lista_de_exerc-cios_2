using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;

            Console.Write("Informe 1º valor: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Informe 2º valor: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Informe 3º valor: ");
            c = int.Parse(Console.ReadLine());

            if (a == b)
            {
                if (b == c)
                {
                    Console.WriteLine("Todos são iguais");
                }
                else
                {
                    if (a > c)
                    {
                        Console.WriteLine("1º e 2º São Maiores");
                    }
                    else
                    {
                        Console.WriteLine("3º é maior");
                    }
                }
            }
            else {
                if (a == c)
                {
                    Console.WriteLine("1º e 3º São maiores");
                }
                else
                {
                    if (b > a)
                    {
                        if (b > c) {
                            Console.WriteLine("2º é maior");
                        }
                        else
                        {
                             
                        }
                    }
                }

            }
        }
    }
}
