using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _11.numero_absoluto
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Digita un numero");
            n = int.Parse(Console.ReadLine());
            if (n >= 0)
            {
                Console.WriteLine("El valor absoluto de el numero es " + n);
            }
            else
            {
                Console.WriteLine("El valor absuluto de el numero es " + (-n));
            }
            Console.ReadKey();

        }
    }
}
