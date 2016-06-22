using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _18.Numero_par_o_impar
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, r;
            Console.WriteLine("Introduce el numero");
            n = int.Parse(Console.ReadLine());
            r = n % 2;
            if (r == 0)
            {
                Console.WriteLine("El numero es par ");
            }
            else
            {
                Console.WriteLine("El numero es impar");
            }
            Console.ReadKey();


        }
    }
}
