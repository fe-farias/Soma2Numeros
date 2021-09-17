using System;

namespace Soma2Numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1,n2;
            string numeroDigitado;

            Console.Write("Digite o primeiro valor: ");
            n1 = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Digite o segundo valor: ");
            numeroDigitado = Console.ReadLine();
            n2 = Convert.ToDouble(numeroDigitado);

            double resultado = n1 + n2;

            Console.WriteLine($"Soma: {resultado}");


        }
    }
}
