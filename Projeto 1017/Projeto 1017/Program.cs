using System;
using System.Globalization;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            double H, V, resultado;

            H = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            V = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            resultado = (H * V) / 12;

            Console.WriteLine(resultado.ToString("F3", CultureInfo.InvariantCulture));


            //Console.ReadLine();
        }
    }
}
