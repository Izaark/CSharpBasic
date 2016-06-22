using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _24.Primeros_numeros_pares
{
    class Program
    {
        static void Main(string[] args)
        {
            int par, x;
            for (x = 2; x <= 20; x++)
            {
                par = x++;
                Console.WriteLine("Los primeros numeros pares son " + par);
            }
            Console.ReadKey();

        }
    }
}
