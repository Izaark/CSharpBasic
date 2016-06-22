using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _23.Carreras
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, prom, pago, continuar = 0;
            while (continuar == 0)
            {
                Console.WriteLine(".................Escoje la carrera a estudiar.............");
                Console.WriteLine("1. Ingenieria en software\n 2. Ingenieria mecanica\n 3. Lic. en negocios");
                num = int.Parse(Console.ReadLine());
                switch (num)
                {

                    case 1:
                        {

                            Console.WriteLine("L a mejor carrera ingenieria en software");
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Una carrera regular ing mecanica");
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("NO sirve para nada");
                            break;
                        }
                }
                Console.WriteLine("Digita tu promedio");
                prom = int.Parse(Console.ReadLine());

                if (prom <= 6)
                {
                    pago = prom * 1000;
                    Console.WriteLine("Por tu promedio pagaras " + pago);
                }
                else if (prom > 6 && prom <= 9)
                {
                    pago = prom * 350;
                    Console.WriteLine("Por tu promedio regular pagaras " + pago);
                }
                else if(prom == 10)
                {
                    Console.WriteLine("Por tu excelente promedio no pagaras, tienes una beca de el 100%");
                }
                else
                {
                    Console.WriteLine("Error, Digita un promedio deel 6 al 10");
                }
                Console.WriteLine("Continuar = 0");
                continuar = int.Parse(Console.ReadLine());
            }
            Console.ReadKey();
        }
    }

}
