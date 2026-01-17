using System;

namespace Mission2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the dice throwing simulator!");
            Console.Write("How many dice rolls would you like to simulate? ");

            int numRolls = int.Parse(Console.ReadLine());

            // Create DiceThrow object
            DiceThrow diceThrow = new DiceThrow();

            // Get roll results from DiceThrow class
            int[] results = diceThrow.RollDice(numRolls);

            Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
            Console.WriteLine($"Total number of rolls = {numRolls}.\n");

            // Print the * for sums 2–12
            for (int i = 2; i <= 12; i++)
            {
                int count = results[i];
                int percentage = (int)Math.Round((double)count / numRolls * 100);

                Console.Write($"{i}: ");
                for (int j = 0; j < percentage; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
        }
    }
}