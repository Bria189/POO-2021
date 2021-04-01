using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NrRationale
{
    class Program
    {
        static void Main(string[] args)
        {
            NrRationale r1 = new NrRationale(10, 8);
            NrRationale r2 = new NrRationale(5, 9);
            NrRationale r3 = r1.Power(3);
            Console.ReadKey();
        }
    }
}
