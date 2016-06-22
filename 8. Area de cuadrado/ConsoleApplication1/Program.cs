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
            int l1, l2, a;
            Console.WriteLine("Dame el primer lado de el cuadrado");
            l1 = int.Parse(Console.ReadLine());
            Console.Write("Dame el segundo lado");
            l2 = int.Parse(Console.ReadLine());
            a = l1 * l2;
            Console.Write("El area del cuadrado es " + a);
            Console.ReadKey();






        }
    }
}
