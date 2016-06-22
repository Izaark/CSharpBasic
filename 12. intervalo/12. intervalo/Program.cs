using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _12.intervalo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Digita el numero");
            n = int.Parse(Console.ReadLine());
            if (n >= -5 && n <= 5)
            {
                Console.WriteLine("El numero " + n + " esta en el intervalo");
            }
            else
            {
                Console.WriteLine("El numero " + n +  " No esta en el intervalo");
            }
            Console.ReadKey();


        }
    }
}
