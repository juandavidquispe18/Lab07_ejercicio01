using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_ejercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el valor de n: ");
            int n = int.Parse(Console.ReadLine());

            float suma_total = 0;

            for (int i = 1; i <= n; i++)
            {
                float resultado = (16.00f - i) / (3f * i);
                Console.WriteLine("resultado: " + resultado);
                suma_total += resultado;
            }
            Console.WriteLine(suma_total);
            Console.ReadKey();
        }
    }
}
