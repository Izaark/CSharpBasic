using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _19.Minutos_de_una_llamada
{
    class Program
    {
        static void Main(string[] args)
        {
            int m1, m2, x;
            {
                Console.WriteLine("Introdusca los munitos");
                x = int.Parse(Console.ReadLine());
                if (x <= 5)
                {
                    m1 = x * 15;
                    Console.WriteLine("Tendras que pagar\n" + m1);
                }
                else
                {
                    m2 = (x - 5) * 5 + 75;
                    Console.WriteLine("Tendras que pagar\n" + m2);
                }
                Console.Read();

           }

        }
    }
}
