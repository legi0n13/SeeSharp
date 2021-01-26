using System;

namespace _3._6
{
    class Program
    {
        static void Main(string[] args)
        {
            /* THE MYSTERIOUS NOISE */
            // Author: legi0n13
            // Set Up The Program
            // Start by asking for the user's name:
            Console.Write("What is your name?: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}! Welcome to our story.");
            Console.WriteLine("It begins on a cold rainy night. You're sitting in your room and hear a noise coming from down the hall. Do you go investigate?");
            Console.Write("Type YES or NO: ");
            string noiseChoice = Console.ReadLine();
            string noiseChoiceUp = noiseChoice.ToUpper();
            // Adding Conditional Statements
            string riddleAnswer;
            if (noiseChoiceUp == "YES")
            {
                Console.WriteLine("You walk into the hallway and see a light coming from under a door down the hall.You walk towards it. Do you open it or knock?");
            }
            else if (noiseChoiceUp == "NO")
            {
                Console.WriteLine("Not much of an adventure if we don't leave our room! THE END.");
            }
            else
            {
                Console.WriteLine("Wrong Answer!");
            }
            Console.Write("Type OPEN or KNOCK: ");
            string doorChoice = Console.ReadLine();
            string doorChoiceUp = doorChoice.ToUpper();
            if (doorChoiceUp == "KNOCK")
            {
                Console.WriteLine("A voice behind the door speaks. It says,\"Answer this riddle: \"");
                Console.WriteLine("\"Poor people have it. Rich people need it. If you eat it you die. What is it?\"");
                Console.Write("Type your answer: ");
                riddleAnswer = Console.ReadLine();
                bool riddleBool = (riddleAnswer.ToUpper() == "NOTHING");
                string ternaryOp = riddleBool ? "The door opens and NOTHING is there.You turn off the light and run back to your room and lock the door.THE END." : "You answered incorrectly. The door doesn't open.THE END.";
                Console.WriteLine(ternaryOp);
                //if (riddleAnswer.ToUpper() == "NOTHING")
                //{
                //    Console.WriteLine("The door opens and NOTHING is there.You turn off the light and run back to your room and lock the door.THE END.");
                //}
                //else
                //{
                //    Console.WriteLine("You answered incorrectly. The door doesn't open.THE END.");
                //}
            }
            else if (doorChoiceUp == "OPEN")
            {
                Console.WriteLine("The door is locked! See if one of your three keys will open it.");
                Console.Write("Enter a number (1-3): ");
                string keyChoice = Console.ReadLine();
                switch (keyChoice)
                {
                    case "1":
                        Console.WriteLine("You choose the first key. Lucky choice! The door opens and NOTHING is there.\n Strange... THE END.");
                        break;
                    case "2":
                        Console.WriteLine("You choose the second key. The door doesn't open. THE END.");
                        break;
                    case "3":
                        Console.WriteLine("You choose the third key. The door doesn't open. THE END.");
                        break;
                    default:
                        Console.WriteLine("Unknown digit");
                        break;
                }

            }
        }
    }
}



