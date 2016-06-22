using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _30.horas_minutos
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = 0, m = 0, s = 0;
            for (h = 0; h < 1; h++)
            {
                Console.WriteLine("horas: \n");
                h = int.Parse(Console.ReadLine());
                for (m = 0; m < 1; m++)
                {
                    Console.WriteLine("minutos: \n");
                    m = int.Parse(Console.ReadLine());
                    for (s = 0; s < 1; s++)
                    {
                        Console.WriteLine("segundos: \n");
                        s = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine(+ h + m + s);
                    Console.ReadKey();
                }
            }
        }
    }
}
