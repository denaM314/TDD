using System;

namespace TDDTestRun
{
    public class Fraction
    {
        public int Numerator { get; }
        public int Denominator { get; }

        public Fraction(int numerator)
        {
            Numerator = numerator;
            Denominator = 1;
        }

        public Fraction(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        public Fraction Plus(Fraction fraction)
        {
            int leastCommonDenominator = this.Denominator;
            int firstAddendNumerator = this.Numerator;
            int secondAddendNumerator = fraction.Numerator;

            leastCommonDenominator = LeastCommonMultiple(this.Denominator, fraction.Denominator);
            firstAddendNumerator *= (int)(leastCommonDenominator / this.Denominator);
            secondAddendNumerator *= (int)(leastCommonDenominator / fraction.Denominator);

            return new Fraction(firstAddendNumerator + secondAddendNumerator, leastCommonDenominator);
        }

        //Euclids GCM Algorithm
        private int GreatestCommonDivisor(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);

            int x = a >= b ? a : b;
            int y = a < b ? a : b;

            while (true)
            {
                int remainder = x % y;
                if (remainder == 0)
                    return y;
                x = y;
                y = remainder;
            }
        }

        private int LeastCommonMultiple(int a, int b)
        {
            return a * b / GreatestCommonDivisor(a, b);
        }

        public override bool Equals(object obj)
        {
            //Check for null and compare run-time types.
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
                return false;
            
            Fraction fraction = (Fraction)obj;
            return (fraction.Numerator == this.Numerator) && (fraction.Denominator == this.Denominator);
        }
    }
}