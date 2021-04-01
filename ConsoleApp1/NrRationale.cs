using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace NrRationale
{
    public class NrRationale
    {
        int numarator, numitor; //stabilim partile fractiei

        public NrRationale(int numarator, int numitor)
        {
            int greatestComDiv = gcd(numarator, numitor);

            this.numarator = numarator / greatestComDiv;
            this.numitor = numitor / greatestComDiv;
        }

        private int gcd(int numarator, int numitor)
        {
            while ((numarator % numitor) > 0)
            {
                int r = numarator % numitor;
                numarator = numitor;
                numitor = r;
            }
            return numitor;
        }

        public NrRationale(int numarator) : this(numarator, 1)
        {

        }

        public NrRationale(string fraction)
        {
            fraction = Regex.Replace(fraction, @"\s+", "");
            Regex pattern = new Regex(@"(\+|-|)\d+");
            MatchCollection matches = pattern.Matches(fraction);

            if (matches.Count != 2)
            {
                if (fraction.Contains("/"))
                {
                    throw new Exception("Incorrect input.");
                }
                else
                {
                    this.numarator = int.Parse(matches[0].ToString());
                    this.numitor = 1;
                }

            }
            else
            {
                this.numarator = int.Parse(matches[0].ToString());
                this.numitor = int.Parse(matches[1].ToString());

                if (this.numarator < 0 ^ this.numitor < 0)
                {
                    this.numarator = Math.Abs(this.numarator);
                    this.numitor = Math.Abs(this.numitor);

                    int greatestComDiv = gcd(numarator, numitor);

                    this.numarator /= greatestComDiv * -1;
                    this.numitor /= greatestComDiv;
                }
                else if (this.numarator < 0 && this.numitor < 0)
                {
                    this.numarator = Math.Abs(this.numarator);
                    this.numitor = Math.Abs(this.numitor);

                    int greatestComDiv = gcd(numarator, numitor);

                    this.numarator /= greatestComDiv;
                    this.numitor /= greatestComDiv;
                }
                else
                {
                    int greatestComDiv = gcd(numarator, numitor);

                    this.numarator /= greatestComDiv;
                    this.numitor /= greatestComDiv;
                }
            }
        }

        public NrRationale Multiplying(NrRationale r1)
        {
            return new NrRationale(r1.numarator * this.numarator, r1.numitor * this.numitor);
            
        }

        public NrRationale Division(NrRationale r1)
        {
            return new NrRationale(this.numarator * r1.numitor, this.numitor * r1.numarator);
        }

        public NrRationale Addition(NrRationale r1) => new NrRationale((this.numarator * r1.numitor) + (r1.numarator * this.numitor), this.numitor * r1.numitor);
        public NrRationale Subtraction(NrRationale r1) => new NrRationale((this.numarator * r1.numitor) - (r1.numarator * this.numitor), this.numitor * r1.numitor);
        public NrRationale SquareRoot() => new NrRationale((int)Math.Sqrt(this.numarator), (int)Math.Sqrt(this.numitor));
        public NrRationale Power(int n) => new NrRationale((int)Math.Pow(this.numarator, n), (int)Math.Pow(this.numitor, n));
    }
}
