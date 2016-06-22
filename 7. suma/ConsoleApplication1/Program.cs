using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            float n1, n2, s, r, m, d;
            Console.WriteLine("Dame el primer numero ");
            n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Dame el segundo numero ");
            n2 = float.Parse(Console.ReadLine());
            s = n1 + n2;
            r = n1 - n2;
            m = n1 * n2;
            d = n1 / n2;
            Console.WriteLine("La suma es:" + s + "\n" + "La resta es:" + r + "\n" + "La multiplicacion es:" + m + "\n" + "La divicion es:" + d);
            Console.ReadKey();
        }
    }
}