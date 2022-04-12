using System;
using System.Globalization;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //variavel
            double A, imposto;

            //Entrada
            A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Processamento / Saida

            if (A <= 2000.0)
                imposto = 0.0;

            else if (A <= 3000.0)
                imposto = (A - 2000.0) * 0.08;

            else if (A <= 4500.0)
                imposto = (A - 3000.0) * 0.18 + 1000.0 * 0.08;

            else
                imposto = (A - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;

            if(imposto == 0.0)
                Console.WriteLine("Isento");

            else
                Console.WriteLine("R$ " + imposto.ToString("F2",CultureInfo.InvariantCulture));








        }
    }
}