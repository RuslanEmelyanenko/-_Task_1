using System;

namespace countTheWeeks
{
    class Program
    {
        static void Main(string[] args)
        {
            // Таск 1.0
            // Подсчитать колличество полных недель!

            short days = 234;
            const byte week = 7;

            Console.WriteLine($"In 234 days is: {days / week} weeks!");
        }
    }
}
