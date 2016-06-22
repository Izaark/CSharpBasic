using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _14.Numeros_iguales
{
    class Program
    {
        static void Main(string[] args)
        {
           int n1, n2;
               Console.WriteLine("Digita el primer numero");
                 n1 = int.Parse(Console.ReadLine());
                  Console.WriteLine("Dame el segundo numero");
                    n2 = int.Parse(Console.ReadLine());
                     if (n1 == n2)
                       {
                         Console.WriteLine("Los numeros son iguales");
                        }
                            else 
                          {
                              Console.WriteLine("Los numeros no son iguales");
                             }
                     Console.ReadKey();
            
        }
    }
}
