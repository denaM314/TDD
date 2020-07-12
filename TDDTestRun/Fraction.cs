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
            return new Fraction(fraction.Numerator + this.Numerator, Denominator);
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