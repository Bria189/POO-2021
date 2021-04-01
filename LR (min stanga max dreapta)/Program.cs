using System;

namespace LR__min_stanga_max_dreapta_
{
    class Program
    {
        static void Main(string[] args)
        {
            long n, m;
            Console.WriteLine("Introduceti o valoare pentru n:");
            n = int.Parse(Console.ReadLine());

            int[] a = new int[n];
            m = n;
            int i = 0, j;
            Console.WriteLine("Introduceti numere naturale");
            while (m != 0)
            {
                a[i] = int.Parse(Console.ReadLine());
                i++;
                m--;
            }

            Console.WriteLine("Sirul de numere este: ");
            for (i = 0; i < n; i++)
                Console.Write(a[i] + " ");

           
            bool ok = true;
            m = n;
            int c = 0;//nr elementelor LR din sir

            
            for (i = 1; i < n; i++)
            {
                for (j = 0; j <= a[i]; j++)
                   if (a[j] >= a[i])
                      ok = false;
                for (j = a[i]; j < n; j++)
                   if (a[i] >= a[j])
                      ok = false;
                if (ok == true)
                   c++;
            }
            Console.WriteLine("In sir sunt " + c + " numere de tip LR");
                

        }
    }
}
