using System;

namespace Mission2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the dice throwing simulator! \n");
            Console.WriteLine("How many dice rolls would you like to simulate?");
            int x = Convert.ToInt32(Console.ReadLine());

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
                //this is the random roll
                int roll1 = r.Next(1, 7);
                int roll2 = r.Next(1, 7);
                int rolltotal = roll1 + roll2;
                dice[rolltotal]++;
            }

            //loop 11 times to go through each number rolled
            for (int i = 2; i < 13; i++)
            {
                float y = ((dice[i] / (float)x) * 100);
                int w = Convert.ToInt32(Math.Round(y));
                string q = "";
                for (int z = 0; z < w; z++)
                {
                    q = (q + "*");
                }
                Console.WriteLine(i + ": " + q);
            }

            //goodbye message
            Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
        }
    }
}
