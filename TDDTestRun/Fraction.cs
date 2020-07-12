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
            if(this.Denominator == fraction.Denominator)
                return new Fraction(fraction.Numerator + this.Numerator, this.Denominator);

            int sumDenominator;
            int firstAddendNumerator;
            int secondAddendNumerator;

            if (this.Denominator > fraction.Denominator && this.Denominator%fraction.Denominator == 0)
            {
                int multiplier = this.Denominator / fraction.Denominator;
                sumDenominator = fraction.Denominator * multiplier;
                secondAddendNumerator = fraction.Numerator*multiplier;

                return new Fraction(secondAddendNumerator + this.Numerator, sumDenominator);
            }

            if (fraction.Denominator > this.Denominator && fraction.Denominator % this.Denominator == 0)
            {
                int multiplier = fraction.Denominator / this.Denominator;
                sumDenominator = this.Denominator * multiplier;
                firstAddendNumerator = this.Numerator * multiplier;

                return new Fraction(firstAddendNumerator + fraction.Numerator, sumDenominator);
            }

            sumDenominator = this.Denominator * fraction.Denominator;
            firstAddendNumerator = this.Numerator * fraction.Denominator;
            secondAddendNumerator = fraction.Numerator * this.Denominator;

            return new Fraction(firstAddendNumerator + secondAddendNumerator, sumDenominator);
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