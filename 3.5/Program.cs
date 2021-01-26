//using System;

//namespace _3._5
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {

//        }
//    }
//    public class Tools
//    {
//        public static bool Contains(string target, string list)
//        {
//            return target.IndexOfAny(list.ToCharArray()) != -1;
//        }
//    }


//}
using System;

namespace _3._5
{
    class Program
    {
        public static void Main(string[] args)
        {
            int minLength = 8;
            string uppercase = "ABCDEFGHJKLMNOPRSTUVYZX";
            string lowercase = uppercase.ToLower();
            string digits = "0123456789";
            string specialChars = "!'^+%&/()=?-£$#*_";

            Console.Write("Enter a password: ");
            string password = Console.ReadLine();
            int score = 0;
            int passLength = password.Length;
            if (passLength >= minLength)
            {
                score++;
            }
            if (Tools.Contains(password, uppercase))
            {
                score++;
            }
            if (Tools.Contains(password, lowercase))
            {
                score += 1;
            }
            if (Tools.Contains(password, digits))
            {
                score++;
            }
            if (Tools.Contains(password, specialChars))
            {
                score++;
            }
            if ((password == "password") || (password == "1234"))
            {
                score = 0;
            }
            switch (score)
            {
                case 5:
                    Console.WriteLine("Password is extremely strong");
                    break;
                case 4:
                    Console.WriteLine("Password is extremely strong");
                    break;
                case 3:
                    Console.WriteLine("Password is strong");
                    break;
                case 2:
                    Console.WriteLine("Password is medium");
                    break;
                case 1:
                    Console.WriteLine("Password is weak");
                    break;
                default:
                    Console.WriteLine("Password doesn’t meet any of the standards");
                    break;


            }


            Console.WriteLine(score);
        }
    }
}   public class Tools
    {
        public static bool Contains(string target, string list)
        {
        return target.IndexOfAny(list.ToCharArray()) != -1;
        }
    }


