using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _24.Operaciones_basicas_case
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, res, n1, n2;
            Console.WriteLine("Digita el primer numero");
              n1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Digita el segundo numero");
                  n2 = int.Parse(Console.ReadLine());
             Console.WriteLine("........Digita una opcion.......");
             Console.WriteLine(" 1.Suma\n 2.Resta\n 3.Multpiplicacion\n 4.Divicion\n 5.Raiz");
             num = int.Parse(Console.ReadLine());
             
            switch (num)
            {
                case 1:
                    {
                        res = n1 + n2;
                        Console.WriteLine("la suma es " + res);
                        break;
                    }
                case 2:
                    {
                        res = n1 - n2;
                        Console.WriteLine("la resta es " + res);
                        break;
                    }
                case 3:
                    {
                        res = n1 * n2;
                        Console.WriteLine("la multiplicacion es " + res);
                        break;
                    }
                case 4:
                    {
                        res = n1 / n2;
                        Console.WriteLine("la divicion es " + res);
                        break;
                    }
                case 5:
                    {
                        
                        Console.WriteLine("la Raiz de el primer numero es");
                        Console.WriteLine(Math.Sqrt(n1));
                        Console.WriteLine("la Raiz de el segundo  numero es");
                        Console.WriteLine(Math.Sqrt(n2));
                        break;
                    }
  

            }
            Console.ReadKey();
        }
    }
}
