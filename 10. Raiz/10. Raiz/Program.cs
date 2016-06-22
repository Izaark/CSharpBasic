using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10.Raiz
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Diguita el numero");
            n = int.Parse(Console.ReadLine());
           Console.WriteLine("L a raiz es:");
           Console.WriteLine(Math.Sqrt(n));
           Console.ReadKey();

        }
    }
}
