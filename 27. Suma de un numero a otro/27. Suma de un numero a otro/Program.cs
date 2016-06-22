using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _27.Suma_de_un_numero_a_otro
{
    class Program
    {
        static void Main(string[] args)
        {
            int x,suma,n;
Console.WriteLine("introduce un numero\n");
n = int.Parse(Console.ReadLine());
x=1;
suma=0;
while(x<=n)
{
suma=suma+x;
x=x+1;
}
Console.WriteLine("la suma desde 1 hasta ese numero es " + suma);
Console.ReadKey();
        }
    }
}
