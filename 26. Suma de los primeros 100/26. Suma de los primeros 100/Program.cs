using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _26.Suma_de_los_primeros_100
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, x, sum;
            for (x = 1; x <= 100; x++)
            {
                num = x;
                Console.WriteLine("los numeros son "+num);
            }
            sum = 0;
            x = 1;
            while (x <= 100)
            {
                sum = sum + x;
                x = x + 1;
            }
            Console.WriteLine("la suma de los primeros 100 numeros naturales es " + sum);
            Console.ReadKey();
        }
     
    }
}
