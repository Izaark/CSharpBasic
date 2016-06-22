using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _21.Dias_de_la_semana
{
    class Program
    {
        static void Main(string[] args)
        {
            char d;
            Console.WriteLine("Captura un numero del 1 al 7 ");
            d = char.Parse(Console.ReadLine());
            switch(d)
            {
                case 'l':
                    {
                        Console.WriteLine("Lunes");
                        break;
                    }
                case 'm':
                    {
                        Console.WriteLine("Martes");
                        break;
                    }
                case 'i':
                    {
                        Console.WriteLine("Miercoles");
                        break;
                    }
                case 'j':
                        {
                            Console.WriteLine("Jueves");
                            break;
                        }
                case 'v':
                        {
                            Console.WriteLine("viernes");
                            break;
                        }
                case 's':
                        {
                            Console.WriteLine("savado");
                            break;
                        }
                case 'd':
                        {
                            Console.WriteLine("domingo");
                            break;
                        }
                default:
                    {
                        Console.WriteLine("Error, captura la letra de la semana");
                        break;
                    }

            }
            Console.ReadKey();


        }
        
    }
}
