using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NrComplexe
{
    class Program
    {
        static void Main(string[] args)
        {
           /* NrComplexe nr;
            Console.WriteLine("Introduceti o valoare pentru partea reala si una pentru partea imaginara pentru a forma numarul complex");
            nr = new NrComplexe(Console.ReadLine());
           */
            NrComplexe c1 = new NrComplexe(0, 6);
            Console.WriteLine(c1);
            NrComplexe c2 = new NrComplexe(6, -4);
            Console.WriteLine(c2);
            NrComplexe c3 = new NrComplexe(3);
            Console.WriteLine(c3);
            NrComplexe c4 = new NrComplexe(0, -5);
            Console.WriteLine(c4);
            NrComplexe c5 = new NrComplexe("+2i");
            NrComplexe b = new NrComplexe("-20 + 2i");
            NrComplexe c = new NrComplexe("3 + 7i");
            NrComplexe d = new NrComplexe("7 - 4i");
           
            NrComplexe c6 = c5.Add(c1);
            NrComplexe c7 = c2.Multiply(c3);
            double a = c1.Modul(c1);
            
            Console.WriteLine(a);
            Console.WriteLine(c7);
            
            NrComplexe suma = b + d;
            Console.WriteLine(suma);

            NrComplexe suma2 = c1.Add(c2);

            Console.WriteLine($"{c1} + {c2} = {suma}");
            
            NrComplexe subtract = c1.Substract(c2);
            
            NrComplexe mult = c1.Multiply (c2);
        }
    }
}
