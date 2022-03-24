using System;

namespace Deliverable1
{
    class Program
    {
        public static string Indent(int count)
        {
            return "".PadLeft(count);
        }
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

            /* Do all of these need to be decimal? */

            Console.WriteLine();
            Console.WriteLine("You need:");
            Console.WriteLine();
            Console.WriteLine(Indent(3) + slices + " slices of bread");
            Console.WriteLine(Indent(3) + tbsp + " tablespoons of peanut butter");
            Console.WriteLine(Indent(3) + jelly + " teaspoons of jelly");
            Console.WriteLine();
            Console.WriteLine("which is...");
            Console.WriteLine();
            Console.WriteLine(Indent(3) + Math.Ceiling(totalLoaves) + " loaves of bread");
            Console.WriteLine(Indent(3) + Math.Ceiling(totalPb) + " jars of peanut butter");
            Console.WriteLine(Indent(3) + Math.Ceiling(totalJelly) + " jars of jelly");
            Console.WriteLine();

            Console.WriteLine("Would you like to restart?");
            string reply = Console.ReadLine();
            if (reply == "yes"
                || reply == "y")
            {
                Console.WriteLine();
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

/* Testing GitHub for desktop setup */