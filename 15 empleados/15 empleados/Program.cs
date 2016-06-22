using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_empleados
{
    class Program
    {
        static void Main(string[] args)
        {

            int nomina = 0;
            int salario;
            for (int i = 1; i <= 15; i++)  
            {
                Console.WriteLine("Digita el salario del Trabajador " + i);
                salario = int.Parse(Console.ReadLine());
                nomina = nomina + salario;
            }
            Console.WriteLine("La nomina total es :" + nomina); 
            Console.ReadKey();
	}

    }
}
