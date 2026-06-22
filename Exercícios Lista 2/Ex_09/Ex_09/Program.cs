using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double peso;
            double altura;
            double imc;
            string sexo;

            Console.Write("Informe seu peso: ");
            peso = double.Parse(Console.ReadLine());
            Console.Write("Informe sua altura: ");
            altura = double.Parse(Console.ReadLine());
            Console.Write("Informe seu sexo: ");
            sexo = Console.ReadLine();

            imc = peso / Math.Pow(altura, 2);

            if (sexo == "m")
            {
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
            else {
                if (sexo == "f") ;
                {
                    if (imc > 19)
                    {
                        if (imc >= 19 && imc < 24)
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
    }
}
