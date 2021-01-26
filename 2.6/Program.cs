using System;

namespace _2._6
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Capture Input
            Console.WriteLine("Welcome to Money Maker!");
            Console.WriteLine("Enter an amount to convert to coins: ");
            string value = Console.ReadLine();
            double convValue = Convert.ToDouble(value);
            Console.WriteLine($"{convValue} cents is equal to...");

            //Convert To Coins
            double gold = 10;
            double silver = 5;
            double goldCoins = Math.Floor(convValue / gold);
            double remainder = convValue % gold;
            //convvalue 16
            //goldcoins 1

            double silverCoins = Math.Floor(remainder / silver);

            remainder = remainder % silver;
            double remainderFloor = Math.Floor(remainder);
            double excess = remainder - remainderFloor;

            //Print all coins
            Console.WriteLine($"Gold coins: {goldCoins}\nSilver coins: {silverCoins}\nBronze coins: {remainderFloor}\nExcess: {excess}");



        }
    }
}
