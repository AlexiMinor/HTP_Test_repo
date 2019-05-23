namespace HtpWork
{
    public class Calculator : ICalculation
    {
        private double Add(double x, double y) => x + y;

        private double Multiple(double x, double y) => x * y;

        private double Negation(double x, double y) => x - y;

        private double Division(double x, double y) => x/y;
        
        
        public double Calculate(double x, double y, string sign)
        {
            switch (sign)
            {
                case "+":
                    return Add(x, y);
                
                case "-":
                    return Negation(x, y);
                
                case "*":
                    return Multiple(x, y);
                
                case "/":
                    return Division(x, y);
                
                default:
                    return 0;
            }
        }
    }
}