using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _9.Area_de_triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            float b, h, a;
            Console.WriteLine("Dame la base");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("Dame la Haltura");
            h = float.Parse(Console.ReadLine());
            a = b * h / 2;
            Console.WriteLine("El area de el triangulo es " + a);
            Console.ReadKey();
        }
    }
}

