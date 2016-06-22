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
            float km, precio;
            Console.WriteLine("Dame el precio de el viaje");
            km = float.Parse(Console.ReadLine());
            precio = (km * 70);
            Console.WriteLine("tu calificacion es: " + precio);
            Console.ReadKey();
        }
    }
}
