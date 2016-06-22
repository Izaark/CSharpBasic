using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _28.media_de_numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            float n, i, s;
            Console.WriteLine("Dame 15 numeros\n");
            s = 0;
            i = 1;
            while (i <= 15)
            {
                n = float.Parse(Console.ReadLine());
                i = i + 1;
                s = s + n;
            }
            s = s / 15;
            Console.WriteLine("La media es " +s);
            Console.ReadKey();
        }
    }
}
