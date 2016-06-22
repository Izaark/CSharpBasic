using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _13.Numero_positivo_o_negativo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Digita un numero");
            n = int.Parse(Console.ReadLine());
            if (n > 0)
            {
                Console.WriteLine("El numero es positivo");
            }
            else if (n < 0)
            {
                Console.WriteLine("El numero es negativo");
            }
            else
            {
                Console.WriteLine("El numero es Zero");
            }
            Console.ReadKey();




        }

    }
}
