using System;
namespace Calculadora_IMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float pesoUsuario = 0;
            float alturaUsuario = 0;
            float calculoIMC = 0;

            Console.WriteLine("------------------------");
            Console.WriteLine("      CALCULE O IMC     ");
            Console.WriteLine("------------------------");

            Console.Write("Insira seu peso (em Kg): ");
            pesoUsuario = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua altura (em metros): ");
            alturaUsuario += float.Parse(Console.ReadLine());

            calculoIMC = pesoUsuario / (alturaUsuario * alturaUsuario);

            if(calculoIMC < 18.5)
            {
                Console.WriteLine("Abaixo do peso");

            }
            else if (calculoIMC >= 18.5 && calculoIMC <= 24.9)
            {
                Console.WriteLine("Peso Normal");
            }
            else if (calculoIMC >= 25 && calculoIMC <= 29.9)
            {
                Console.WriteLine("Sobrepeso");
            }
            else
            {
                Console.WriteLine("Obesidade");
            }

            Console.WriteLine(calculoIMC);
        }
    }
}
