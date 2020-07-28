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
            int commonDenominator = this.Denominator * that.Denominator;

            int firstAddendNumerator = (int) this.Numerator * (commonDenominator / this.Denominator);
            int secondAddendNumerator = (int) that.Numerator * (commonDenominator / that.Denominator);

            return new Fraction(firstAddendNumerator + secondAddendNumerator, commonDenominator);
        }

        public Fraction Minus(Fraction that)
        {
            return this.Plus(that.Negate());
        }

        public Fraction MultipliedBy(Fraction that)
        {
            return new Fraction(this.Numerator * that.Numerator, this.Denominator * that.Denominator);
        }

        public Fraction DividedBy(Fraction fraction)
        {
            return this;
        }

        public Fraction Negate()
        {
            return new Fraction(this.Numerator * -1, this.Denominator);
        }

        //Euclids GCD Algorithm
        private int GreatestCommonDivisor(int a, int b)
        {
            while (b != 0)
            {
                var temporary = b;
                b = a % b;
                a = temporary;
            }

            return Math.Abs(a);
        }

        private void ReduceFraction()
        {
            int greatestCommonDivisor = GreatestCommonDivisor(this.Numerator, this.Denominator);
            this.Numerator /= greatestCommonDivisor;
            this.Denominator /= greatestCommonDivisor;
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