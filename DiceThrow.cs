using System;

namespace Mission2
{
    class DiceThrow
    {
        public int[] RollDice(int numRolls)
        {
            // Sums go from 2 to 12. With the dice 1 and 2 aint used
            int[] rollResults = new int[13];
            
            // makes object for random 
            Random rand = new Random();
            
            // will start at 0 and then go how many times the user wants it to ya know
            for (int i = 0; i < numRolls; i++)
            {
                // rolling the 2 dice and seeing the numbers 1-6, and adding to sum
                int die1 = rand.Next(1, 7);
                int die2 = rand.Next(1, 7); 
                int sum = die1 + die2;

                rollResults[sum]++;
            }
            // returns them results
            return rollResults;
        }
    }
}