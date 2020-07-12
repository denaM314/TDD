namespace TDDTestRun
{
    public class Fraction
    {
        private int Numerator;
        private int Denominator;

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
            return new Fraction(fraction.GetNumerator() + this.Numerator, Denominator);
        }

        public int GetNumerator()
        {
            return Numerator;
        }

        public int GetDenominator()
        {
            return Denominator;
        }

        public override bool Equals(object obj)
        {
            //Check for null and compare run-time types.
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
                return false;
            
            Fraction fraction = (Fraction)obj;
            return (fraction.GetNumerator() == this.Numerator) && (fraction.GetDenominator() == this.Denominator);
        }
    }
}