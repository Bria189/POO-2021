using System;
using System.Text.RegularExpressions;

namespace NrComplexe
{
    class NrComplexe
    {
        private double partere; //partea reala a nr complex
        private double parteim; //partea imaginara a nr complex

        public NrComplexe(double partere) : this(partere, 0)
        {

        }

        public NrComplexe(string v)
        {
            v = Regex.Replace(v, @"\s+", "");

            Regex realPattern = new Regex(@"^(-|\+|)\d*(?!i)");
            if (realPattern.IsMatch(v))
            {
                MatchCollection realMatches = realPattern.Matches(v);

                if (!(realMatches[0].ToString().Length == 0 || realMatches[0].ToString() == "-" || realMatches[0].ToString() == "+"))
                {
                    this.partere= double.Parse(realMatches[0].ToString());
                }
            }

            Regex imagPattern = new Regex(@"(\+|-|)\d*(?=i$)");
            if (imagPattern.IsMatch(v))
            {
                MatchCollection imagMatches = imagPattern.Matches(v);
                this.parteim = double.Parse(imagMatches[0].ToString());
            }
        }

        public NrComplexe(double re, double parteim)
        {
            this.partere= re;
            this.parteim = parteim;
        }

        public override string ToString()
        {
            string semn2 = "";

            if (partere== 0)
            {
                if (parteim == 0)
                    return "0";
                else
                    return parteim.ToString() + "i";
            }

            if (parteim < 0)
            {
                parteim = -parteim;
                semn2 = "-";
            }
            else if (parteim > 0)
                semn2 = "+";
            else
                return partere.ToString();

            return "(" + (partere.ToString()) + " " + semn2 + " " + parteim.ToString() + "i" + ")";
        }

        public NrComplexe Add(NrComplexe c2)
        {
            return new NrComplexe(partere + c2.partere, parteim + c2.parteim);
        }

        public NrComplexe Substract(NrComplexe c2)
        {
            return new NrComplexe(partere - c2.partere, parteim - c2.parteim);
        }

        public NrComplexe Multiply(NrComplexe c2)
        {
            return new NrComplexe((partere * c2.partere) - (parteim * c2.parteim), (partere * c2.parteim) + (c2.partere * parteim));
        }

        public double ParteReala
        {
            get
            {
                return partere;
            }
        }

        public double ParteImaginara
        {
            get
            {
                return parteim;
            }
        }

        public double Modul(NrComplexe c)
        {
            return Math.Sqrt(Math.Pow(partere, 2) + Math.Pow(parteim, 2));
        }

        public double Argument(NrComplexe c)
        {
            return Math.Atan(parteim / partere);
        }

        public static NrComplexe operator +(NrComplexe c1, NrComplexe c2)
        {
            return new NrComplexe(c1.partere + c2.partere, c1.parteim + c2.parteim);
        }

        public static NrComplexe operator -(NrComplexe c1, NrComplexe c2)
        {
            return new NrComplexe(c1.partere - c2.partere, c1.parteim - c2.parteim);
        }

        public static NrComplexe operator *(NrComplexe c1, NrComplexe c2)
        {
            return new NrComplexe(c1.partere * c2.partere, c1.parteim * c2.parteim);
        }
    }
}
