using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_06
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double peso;
            double altura;
            double imc;

            Console.Write("Informe seu peso: ");
            peso = double.Parse(Console.ReadLine());
            Console.Write("Informe sua altura: ");
            altura = double.Parse(Console.ReadLine());

            imc = peso / Math.Pow (altura, 2);

            if (imc > 20)
            {
                if (imc >= 20 && imc < 25)
                {
                    Console.Write("Você esta no peso ideal");
                }
                else
                {
                    Console.WriteLine("Você esta acima do peso ideal");
                }
            }
            else
            {
                Console.Write("Você está abaixo do peso ideal");
            }
}
}
}
