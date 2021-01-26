using System;

namespace _2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            This program Mad Libs 
            Author: legi0n13
            */

            //adjective - sıfat
            //verb - fiil
            //noun - isim

            // Let the user know that the program is starting:
            Console.WriteLine("Program is starting!\nGive the Mad Lib a title: ");


            // Give the Mad Lib a title:
            string title = Console.ReadLine();


            // Define user input and variables:
            Console.WriteLine("Enter a name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter three adjectives: ");
            string adj1 = Console.ReadLine();
            string adj2 = Console.ReadLine();
            string adj3 = Console.ReadLine();
            Console.WriteLine("Enter a verb: ");
            string verb1 = Console.ReadLine();
            Console.WriteLine("Enter two nouns: ");
            string noun1 = Console.ReadLine();
            string noun2 = Console.ReadLine();
            Console.WriteLine("Please enter one in order from each of the followings:\nAn animal\nA food\nA fruit\nA superhero\nA country\nA dessert\nA year");
            string animal = Console.ReadLine();
            string food = Console.ReadLine();
            string fruit = Console.ReadLine();
            string superhero = Console.ReadLine();
            string country = Console.ReadLine();
            string dessert = Console.ReadLine();
            string year = Console.ReadLine();


            // The template for the story:

            string story = $"This morning {name} woke up feeling {adj1}. 'It is going to be a {adj2} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verb1} to the rhythm of the {noun1}, which made all the {fruit}s very {adj3}. Concerned, {name} texted {superhero}, who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}. {name} woke up in the year {year}, in a world where {noun2}s ruled the world.";


            // Print the story:
            Console.WriteLine(title);
            Console.WriteLine(story);
        }
    }
}
