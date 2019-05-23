using System;

namespace HtpWork
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Calculate();
                Console.WriteLine("Do you want continue calculation? - y/n");
                var answer = Console.ReadLine();
                if (!(answer.Equals("y") || answer.Equals("Y")))
                    return;

              
                }  
            
            
           // MultipleTable(x);
            
            Console.ReadLine();

        }

        static void MultipleTable(double x)
        {
            for (int i = 0; i < 11; i++)
            {
                ICalculation calculator = new Calculator();
                Console.WriteLine(calculator.Calculate(x, i, "*"));
            }
            }

        static void Calculate()
        {
            Console.WriteLine("Input x:");
            var x = Console.ReadLine();

            foreach (var symbol in x)
            {
                if (!char.IsDigit(symbol))
                {
                    return;
                }
            }

            Console.WriteLine("Input y:");
            var y = Convert.ToInt32(Console.ReadLine());
          
            Console.WriteLine("Input sign:");
            var sign = Console.ReadLine();
                
            ICalculation calculator = new Calculator();
            Console.WriteLine(calculator.Calculate(Convert.ToDouble(x), y, sign));
        }

        }

    }