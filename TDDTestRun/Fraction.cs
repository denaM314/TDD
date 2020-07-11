namespace TDDTestRun
{
    public class Fraction
    {
        private int value;

        public Fraction(int v)
        {
            this.value = v;
        }

        public Fraction Plus(Fraction fraction)
        {       
            return new Fraction(fraction.IntValue() + this.IntValue());
        }

        public int IntValue()
        {
            return value;
        }
    }
}