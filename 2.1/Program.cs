using System;

namespace _2._1
{
    class Program
    {
        static void Main(string[] args)
        {

            // Ask user for fave number
            Console.Write("Enter your favorite number!: ");
            //int faveNumber = (int)Console.ReadLine();
            //string doesn't convert implicitly to int
            int faveNumber = Convert.ToInt32(Console.ReadLine());
            // Turn that answer into an int
            Console.WriteLine(faveNumber);
            /* 
            DATA TYPES: int, double, char, string, bool
            VARIABLES: datatype variableName = value;
            COMMON ERRORS: wrong type, wrong value, no semicolon
            DATA TYPE CONVERSION: implicit classic, explicit (int), methods Convert.ToX*/
        }
    }
}
