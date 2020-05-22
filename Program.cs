using System;

namespace GrausCF
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Olá usuário, vou ajudá-lo a coverter °C para °F. Digite uma tecla para continuar:");

            Console.ReadKey();



            Console.WriteLine("Digite o valor em celcius:");

            double celcius = double.Parse (Console.ReadLine ());



            double valor = 1.8;

            double farenheit  = 32;



            Console.Write(celcius + " graus celcius equivalem a: ");

            Console.Write(celcius * valor + farenheit );

            Console.WriteLine(" graus farenheit.");


        }
    }
}
