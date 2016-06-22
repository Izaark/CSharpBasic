using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _15.Cuadrado_de_un_numero_o_zero
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
              Console.WriteLine("Digita un numero");
               n = int.Parse(Console.ReadLine());
                if (n == 0)
                 {
                  Console.WriteLine("El numero es zero");
                  }
                    else 
                    {
                        Console.WriteLine("El cuadrado de el numero es " + (Math.Pow(n,2)));
                      }
                        Console.ReadKey();
        }
    }
}
