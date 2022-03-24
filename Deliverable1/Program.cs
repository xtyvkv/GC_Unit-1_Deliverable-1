using System;

namespace Deliverable1
{
    class Program
    {
        public static void Run()
        {
            Console.WriteLine("How many people are we making PB and J sandwiches for?");

            string input =
                Console.ReadLine();
            decimal people = int.Parse(input);
            decimal slices = people * 2;
            decimal tbsp = people * 2;
            decimal jelly = people * 4;
            decimal totalLoaves = slices / 28;
            decimal totalPb = (2 * people) / 32;
            decimal totalJelly = (4 * people) / 48;

            /* There has to be an easier way than to change all of these to decimals right away? */

            Console.WriteLine("\nYou need:\n\n" + slices + " slices of bread\n" + tbsp + " tablespoons of peanut butter\n" + jelly + " teaspoons of jelly\n\n" + "which is...\n\n" + Math.Ceiling(totalLoaves) + " loaves of bread\n" + Math.Ceiling(totalPb) + " jars of peanut butter\n" + Math.Ceiling(totalJelly) + " jars of jelly\n");

            Console.WriteLine("Would you like to restart?");
            string reply = Console.ReadLine();
            if (reply == "yes"
                || reply == "y")
            {
                Run();
            }
            else
            {
                Console.WriteLine("Goodbye!");
            }
        }
        static void Main(string[] args)
        {
            Run();
        }
    }
}