using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberToReach = 100;
            
            for(int i = 1; i<=numberToReach; i++)
            {
                Console.WriteLine(i);

                Boolean DivisiblebyThree = i % 3 == 0;
                Boolean DivisiblebyFive = i % 5 == 0;

                if (DivisiblebyThree)
                {
                    Console.WriteLine(" Fizz");
                }
                if (DivisiblebyFive)
                {
                    Console.WriteLine(" Buzz");
                }
               Console.WriteLine();
            }

        }
    }
}
