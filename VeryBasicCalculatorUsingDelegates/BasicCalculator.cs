namespace VeryBasicCalculatorUsingDelegates
{
    class BasicCalculator 
    {
        public delegate double Delegate(double First, double second);

        public static double Add(double First, double second)
        {
            return First + second;
        }

        public static double Mult(double First, double second)
        {
            return First * second;
        }

        public static double Sub(double First, double second)
        {
            return First - second;
        }

        public static double Divide(double First, double second)
        {
            return First / second;
        }
    }
}
