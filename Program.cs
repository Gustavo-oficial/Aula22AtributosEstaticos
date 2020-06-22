using System;

namespace Aula22AtributosEstaticos
{
    class Program
    {
        static void Main(string[] args)
        {

            Conversor.CotacaoDolar = 5.29f;
            Conversor.CotacaoEuro = 5.86f;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("A conversão do Dolar para o Real é de: ");
            Console.WriteLine(Conversor.CoverterDolarparaReal(200f));
            Console.WriteLine("A conversão do Real para Dolar é de: ");
            Console.WriteLine(Conversor.CoverterRealparaDolar(100f));
            Console.WriteLine("A conversão do Euro para o Real é de: ");
            Console.WriteLine(Conversor.CoverterEuroparaReal(100f));
            Console.WriteLine("A conversão do Real para Euro é de: ");
            Console.WriteLine(Conversor.CoverterRealparaEuro(200f));
            Console.ResetColor();
        }
    }
}
