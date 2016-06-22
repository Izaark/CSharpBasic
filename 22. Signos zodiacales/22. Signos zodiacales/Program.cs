using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _22.Signos_zodiacales
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, continuar = 0;
            char letra;
            while (continuar == 0)
            {

                Console.WriteLine("..............Signos Zodicales...............");
                Console.WriteLine("1.Aries\n 2.Tauro\n 3.Geminis\n 4.Cáncer\n 5.Leo\n 6.Virgo\n 7.Libra\n 8.Escorpio\n 9.Sagitario\n 10.Capricornio\n 11.Acuario\n 12.Piscis\n");
                num = int.Parse(Console.ReadLine());

                switch (letra)
                {

                    case 'a':
                        {
                            Console.WriteLine("Aries el mejor signo xD");
                            break;

                        }
                    case 2:
                        {
                            Console.WriteLine("Tauro");
                            break;

                        }
                    case 3:
                        {
                            Console.WriteLine("Geminis");
                            break;

                        }

                    case 4:
                        {
                            Console.WriteLine("Cáncer");
                            break;

                        }

                    case 5:
                        {
                            Console.WriteLine("Leo");
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("Virgo");
                            break;

                        }

                    case 7:
                        {
                            Console.WriteLine("Libra");
                            break;

                        }

                    case 8:
                        {
                            Console.WriteLine("Escorpion");
                            break;

                        }


                    case 9:
                        {
                            Console.WriteLine("Sagitario");
                            break;

                        }
                    case 10:
                        {
                            Console.WriteLine("Capricornio");
                            break;

                        }

                    case 11:
                        {
                            Console.WriteLine("Acuario");
                            break;

                        }
                    case 12:
                        {
                            Console.WriteLine("Piscis");
                            break;

                        }

                    default:
                        {
                            Console.WriteLine("Error");
                            break;
                        }
                }
                Console.WriteLine("continar = 0");
                continuar = int.Parse(Console.ReadLine());
                 }
            Console.ReadKey();
               

        }
    }
}
