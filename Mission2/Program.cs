using System;

namespace Mission2
{
    class Program
    {
        static void Main(string[] args)
        {
            //lines of text at begining of program
            Console.WriteLine("Welcome to the dice throwing simulator! \n");
            Console.WriteLine("How many dice rolls would you like to simulate?");

            //takes user input and changes it to an integer for later use
            int x = Convert.ToInt32(Console.ReadLine());

            //explains program output
            Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each \"*\" represents 1% of the total number of rolls. \nTotal number of rolls = " + x + '\n');

            //sets up an array that will contain 12 integers for roll total
            int[] dice = new int[13];

            //give each spot value of 0
            for (int i = 0; i < 13; i++)
            {
                dice[i] = 0;
            }

            //random number generator
            Random r = new Random();
            for (int i = 0; i < x; i++)
            {
                //this is the random rolls
                int roll1 = r.Next(1, 7);
                int roll2 = r.Next(1, 7);
                //addition of rolls for sum of rolls
                int rolltotal = roll1 + roll2;
                //assigning roll to count in array
                dice[rolltotal]++;
            }

            //loop 11 times to go through each number rolled
            for (int i = 2; i < 13; i++)
            {
                //finds the percentage of times number was rolled
                float y = ((dice[i] / (float)x) * 100);
                //rounds the average of each number 
                int w = Convert.ToInt32(Math.Round(y));
                string q = "";
                //for loop to create the strings containing "*"
                for (int z = 0; z < w; z++)
                {
                    //adds a "*" for every percentage
                    q = (q + "*");
                }
                //prints "*"
                Console.WriteLine(i + ": " + q);
            }

            //goodbye message
            Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
        }
    }
}
