using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_07
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double l1;
            double l2;
            double l3;

            Console.Write("Informe 1ª medida: ");
            l1 = double.Parse(Console.ReadLine());
            Console.Write("Informe 2ª medida: ");
            l2 = double.Parse(Console.ReadLine());
            Console.Write("Informe 3ª medida: ");
            l3 = double.Parse(Console.ReadLine());

            if (l1 + l2 > l3 && l1 + l3 > l2 && l2 + l3 > l1) //testa se existe o triangulo
            {
                if (l1 == l2 || l2 == l3 || l1 == l3)
                {
                    if (l1 == l2 && l2 == l3 && l1 == l3)
                    {
                        Console.Write("É um triângulo eqüilátero");
                    }
                    else
                    {
                        Console.Write("É um triângulo isósceles");
                    }
                }
                else
                {
                    Console.Write("É um triângulo escaleno");
                }
            }
            else
            {
                Console.Write("Não existe um triângulo para essas medidas ");
            }

}
}
}
