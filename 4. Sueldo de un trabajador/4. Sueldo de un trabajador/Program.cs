using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4.Sueldo_de_un_trabajador
{
    class Program
    {
        static void Main(string[] args)
        {
            double s, ns;
            Console.WriteLine("Dame el sueldo actual de el trabajador");
            s = double.Parse(Console.ReadLine());
            ns = s * 1.8;
            Console.WriteLine(ns);
            Console.ReadKey();
        }
    }
}
