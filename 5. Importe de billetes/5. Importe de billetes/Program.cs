using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5.Importe_de_billetes
{
    class Program
    {
        static void Main(string[] args)
        {
            int b5, b10, b20, cant;
            Console.WriteLine("...............Importe de billetes........");

            Console.WriteLine("Dame los billetes de a 5");
            b5 = int.Parse(Console.ReadLine());
            Console.WriteLine("Dame los billetes de a 10");
            b10 = int.Parse(Console.ReadLine());
            Console.WriteLine("Dame los billetes de a 20");
            b20 = int.Parse(Console.ReadLine());
            b5 = b5 * 5;
            b10 = b10 * 10;
            b20 = b20 * 20;
            cant = b5 + b10 + b20;
            Console.WriteLine("El importe total es " + cant);
            Console.ReadKey();
        }
    }
}
