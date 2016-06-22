


//estas son las bibliotecas 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//nombre del proyecto

namespace ejemplo_1 
{

    //clase principal
    class Program
    {

        //acceso a los programas de manera global de la funcion main 

        static void Main(string[] args)
        {

            metodos m = new metodos();
            m.mensaje();
            Console.ReadKey();


        }
    }
}
