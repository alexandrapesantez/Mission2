using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Namespace declaration for the Mission2 project
namespace Mission2
{
    // Class responsible for simulating dice rolls
    internal class DiceRoll
    {
        // Method to simulate dice rolls and return the distribution of outcomes
        public int[] DiceSim(int numOfRolls)
        {
            // Variables to represent the values of two dice and their total
            int Dice1 = 0;
            int Dice2 = 0;
            int DiceRollTotal = 0;
            
            // Random number generator for simulating dice rolls
            Random random = new Random();

            // Array to store the distribution of dice roll outcomes
            int[] results = new int[11];
            // Loop through the specified number of rolls
            for (int rolls = 0; rolls < numOfRolls; rolls++)
            {
              // Generate random values for two dice
                Dice1 = random.Next(1, 7);
                Dice2 = random.Next(1, 7);
                // Calculate the total value of the dice rolls
                DiceRollTotal = Dice1 + Dice2;
                // Update the array to reflect the occurrence of the current total
                results[DiceRollTotal - 2]++;
            }
           // Return the array representing the distribution of dice roll outcomes
            return results;

        }
    }
}
