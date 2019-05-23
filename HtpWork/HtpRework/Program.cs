using System;

namespace HtpRework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input number: ");
            var x = Console.ReadLine();
            
            Console.WriteLine($"You input {GetDayOfWeekByNumber(x)}");

        }

        static string GetDayOfWeekByNumber(string numberOfDay)
        {
            switch (numberOfDay)
            {
                case "1":
                    return "Monday";
                
                case "2":
                    return "Tuesday";
                
                default:
                    return "Incorrect value for day of week";
            }
            
        }
    }
}