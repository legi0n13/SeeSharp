using System;

namespace _2._2
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            addition +
            subtraction -
            multiplication *
            division /
            */


            // Your Age
            int userAge = 51;

            // Length of years on Jupiter (in Earth years)
            double jupiterYears = 11.86;

            // Age on Jupiter
            double jupiterAge = userAge / jupiterYears;
            // Time to Jupiter
            double journeyToJupiter = 6.142466;

            // New Age on Earth
            double newEarthAge = userAge + journeyToJupiter;

            // New Age on Jupiter
            double newJupiterAge = newEarthAge / jupiterYears;

            // Log calculations to console
            Console.WriteLine(userAge);
            Console.WriteLine(jupiterAge);
            Console.WriteLine(newEarthAge);
            Console.WriteLine(newJupiterAge);

            /* 

            DATA TYPES: int, double, decimal
            ARITHMETIC OPERATORS: +, -, *, /
            INCREMENT/DECREMENT: ++, --
            MODULO: % 
            BUILT-IN METHODS: Abs, Pow, Sqrt, Floor, Ceiling, Min, Max

            */


        }
    }
}
