using System;

namespace TDDTestRun
{
    public class Fraction
    {
        public int Numerator { get; private set; }
        public int Denominator { get; private set; }

        public Fraction(int numerator) : this(numerator, 1) { }

        public Fraction(int numerator, int denominator)
        {
            if (denominator == 0)
                throw new ArgumentOutOfRangeException("Cannot have zero as the denominator");

            if (denominator < 0)
            {
                numerator *= -1;
                denominator *= -1;
            }

            this.Numerator = numerator;
            this.Denominator = denominator;

            ReduceFraction();
        }

        public Fraction Plus(Fraction that)
        {
            int firstAddendNumerator = this.Numerator;
            int secondAddendNumerator = that.Numerator;
            int leastCommonDenominator = LeastCommonMultiple(this.Denominator, that.Denominator);

            firstAddendNumerator *= (int)(leastCommonDenominator / this.Denominator);
            secondAddendNumerator *= (int)(leastCommonDenominator / that.Denominator);

            return new Fraction(firstAddendNumerator + secondAddendNumerator, leastCommonDenominator);
        }

        public Fraction Minus(Fraction that)
        {
            int firstAddendNumerator = this.Numerator;
            int secondAddendNumerator = that.Numerator;
            int leastCommonDenominator = LeastCommonMultiple(this.Denominator, that.Denominator);

            firstAddendNumerator *= (int)(leastCommonDenominator / this.Denominator);
            secondAddendNumerator *= (int)(leastCommonDenominator / that.Denominator);

            return new Fraction(firstAddendNumerator - secondAddendNumerator, leastCommonDenominator);
        }

        public Fraction Negate()
        {
            return new Fraction(this.Numerator * -1);
        }
        //Euclids GCD Algorithm
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

        private void ReduceFraction()
        {
            if (this.Numerator != 0)
            {
                int greatestCommonDivisor = GreatestCommonDivisor(this.Numerator, this.Denominator);
                this.Numerator /= greatestCommonDivisor;
                this.Denominator /= greatestCommonDivisor;
            }
            else
            {
                this.Numerator = 0;
                this.Denominator = 1;
            }
        }

        public override bool Equals(object obj)
        {
            //Check for null and compare run-time types.
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
                return false;
            
            Fraction fraction = (Fraction)obj;
            return (fraction.Numerator == this.Numerator) && (fraction.Denominator == this.Denominator);
        }

        public override int GetHashCode()
        {
            return Numerator*19 + Denominator;
        }

        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }
    }
}