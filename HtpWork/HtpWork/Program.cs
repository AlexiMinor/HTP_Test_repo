using System;

namespace HtpWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input number:");
            var x = Console.ReadLine();

            int number = Convert.ToInt32(x);
            
            WriteArrayOfLongValues(Multiple(number), number);

            Console.ReadLine();

        }

        private static long[] Multiple(int number)
        {
            long[] array = new long[11];
            for (int i = 0; i < 20; i++)
            {
                array[i] = number * i;
            }

            return array;
        }

        static void WriteArrayOfLongValues(long[] array, int number)
        {
            for (int i = 0; i < array.Length; i++)
            {
               
                    Console.WriteLine($"{number.ToString()} * {i.ToString()} = {array[i].ToString()}");
               }
            }
        }

    }