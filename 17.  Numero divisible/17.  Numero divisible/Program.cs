using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _17.Numero_divisible
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
               Console.WriteLine("Dame el primer numero");
                  n1 = int.Parse(Console.ReadLine());
                      Console.WriteLine("Dame el segundo numero");           
                   n2 = int.Parse(Console.ReadLine());
                   if (n1%n2 == 0)
                   {
                       Console.WriteLine("Divisible");
                   }
                   else
                   {
                       Console.WriteLine("No es divisible");
                       Console.WriteLine("Hola");
                       foreach (var item in collection)
                       {
                           Console.WriteLine("isaac");
                       }
                   }

                   Console.ReadKey();
            }
    }
}
