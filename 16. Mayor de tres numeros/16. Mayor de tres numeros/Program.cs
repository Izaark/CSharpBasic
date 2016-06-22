using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _16.Mayor_de_tres_numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3;
            Console.WriteLine("Damne el primer numero");
               n1 = int.Parse(Console.ReadLine());
                 Console.WriteLine("Damne el segundo numero");
                   n2 = int.Parse(Console.ReadLine());
                     Console.WriteLine("Damne el tercer numero");
                        n3 = int.Parse(Console.ReadLine());

                        if (n1 > n2 && n1 > n3 && n2 > n3)
                        {
                            Console.WriteLine("El mayor es " + n1 + " Seguido de " + n2 + " El menor seria " + n3);
                        }
                        else if (n1 > n2 && n1 > n3 && n3 > n2)
                        {
                              Console.WriteLine("El mayor es " + n1 + " Seguido de " + n3 + " El menor seria " + n2);
                        }

                        else if (n2 > n1 && n2 > n3 && n1 > n3)
                        {
                                 Console.WriteLine("El mayor es " + n2 + " Seguido de " + n1 + " El menor seria " + n3);
                        }
                        else if (n2 > n1 && n2 > n3 && n3 > n1)
                         {
                                        Console.WriteLine("El mayor es " + n2 + " Seguido de " + n3 + " El menor seria " + n1);
                        }
                        else if (n3 > n2 && n3 > n1 && n2 > n1)
                        {
                                             Console.WriteLine("El mayor es " + n3 + " Seguido de " + n2 + " El menor seria " + n1);
                        }
                        else if (n3 > n2 && n3 > n1 && n1 > n2)
                        {
                                                   Console.WriteLine("El mayor es " + n3 + " Seguido de " + n1 + " El menor seria " + n2);
                        }

                        Console.ReadKey();
        }
    }
}
