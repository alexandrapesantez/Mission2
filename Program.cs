using Mission2;
using System.Runtime.InteropServices;
//Alexandra Pesantez 
// Section: 1 
//Description: The program is a dice throwing simulator designed to provide users with a realistic representation of dice rolls and their distribution.
//Users are prompted to input the number of dice rolls they would like to simulate.
//The distribution of outcomes is then recorded and displayed. 


// class named program 
internal class Program
{
    // Entry point of the application, where program execution begins
    private static void Main(string[] args)
    {
        // welcome message and prompt for user to input num of dice rolls
        System.Console.WriteLine("Welcome to the dice throwing simulator! \n\n" +
            "How many dice rolls would you like to simulate?");

        // User input for the number of dice rolls
        int dicerolled = int.Parse(System.Console.ReadLine());

        // Create an instance of DiceRoll class
        DiceRoll dr = new DiceRoll();

        // Perform dice simulation and get results
        int[] results = dr.DiceSim(dicerolled);

        // Display simulation results header
        System.Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
        System.Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
        System.Console.WriteLine("Total number of rolls = " + dicerolled + "\n");

        // Iterate through the results array to display the distribution of dice roll outcomes
        for (int i = 0; i < results.Length; i++)

        {
            // Calculate the percentage of occurrences for the current dice roll outcome
            int percentage = (int)((double)results[i] / dicerolled * 100);
            
            // Display the current dice roll value along with its percentage
            Console.Write(i+ 2 + ": ");

            // Display '*' for each percentage point, representing the distribution
            for (int j = 0; j < percentage; j++)
            {
                Console.Write("*");
            }
            // Move to the next line for the next dice roll outcome
            Console.WriteLine();

        }

        // Display a concluding message after completing the simulation
        System.Console.WriteLine("\n Thank you for using the dice throwing simulator. Goodbye!");
    }


}





