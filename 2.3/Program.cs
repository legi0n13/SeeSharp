using System;

namespace Review
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            DATA TYPES: char, string
            STRING INTERPOLATION: $"blah blah"
            STRING INFO: .Length, .IndexOf()
            PARTS OF STRINGS: bracketNotation[], .Substring() 
            STRING MANIPULATION: .ToUpper(), .ToLower()

            Good luck! */
            string text = "abcdfghjkmnoprs";
            int textpos1 = text.IndexOf("j");
            string text1 = text.Substring(textpos1);
            string text2 = text1.ToUpper();


            Console.WriteLine(text2);


        }
    }
}
