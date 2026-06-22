using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor do lado A: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor do lado B: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor do lado C: ");
            double c = double.Parse(Console.ReadLine());

            double hipotenusa = a;
            double cateto1 = b;
            double cateto2 = c;

            if (b > a && b > c)
            {
                hipotenusa = b;
                cateto1 = a;
                cateto2 = c;
            }
            if (c > a && c > b)
            {
                hipotenusa = c;
                cateto1 = a;
                cateto2 = b;
            }

            if ((hipotenusa * hipotenusa) == (cateto1 * cateto1) + (cateto2 * cateto2))
            {
                Console.WriteLine("Os valores formam um triângulo retângulo!");
            }
            else
            {
                Console.WriteLine("Os valores NÃO formam um triângulo retângulo.");
            }
        }
    }
}
