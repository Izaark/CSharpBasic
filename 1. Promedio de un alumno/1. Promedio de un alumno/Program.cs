using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.Promedio_de_un_alumno
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            float cal1, cal2, cal3, promedio;
            Console.WriteLine("ingresa el nombre del Alumno");
            nombre = Console.ReadLine();
            Console.WriteLine("ingresa la primera califcacion");
            cal1 = float.Parse(Console.ReadLine());
            Console.WriteLine("ingresa la segunda calificacion");
            cal2 = float.Parse(Console.ReadLine());
            Console.WriteLine("ingresa la tercera calificacion");
            cal3 = float.Parse(Console.ReadLine());
            promedio = (cal1 + cal2 + cal3) / 3;
            Console.WriteLine(nombre + " " + "tu calificacion es: " + promedio);
            if (promedio > 6)
            {
                Console.WriteLine("aprobado");
            }
            else
            {
                Console.WriteLine("reprobado");
            }
            Console.ReadKey();

        }
    }
}
