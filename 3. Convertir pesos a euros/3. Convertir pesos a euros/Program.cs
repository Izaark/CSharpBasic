using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2.Convertir_pesos_a_euros
{
    class Program
    {
        static void Main(string[] args)
        {
            float pesos, euros;
            Console.WriteLine("Dame el valor en pesos");
            pesos = float.Parse(Console.ReadLine());
            euros = pesos / 17;
            Console.WriteLine("En euros es " + euros);
            Console.WriteLine("adios");
            Console.ReadKey();
            
        }
    }
}
