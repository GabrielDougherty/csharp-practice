using System;

namespace ArrayPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("NUMBER ADDER\n" +
                "Enter a series of numbers, 'exit' to Quit.");
            string input = "";
            int[] nums = new int[256];

            // I could of course sum in this loop, but then why use arrays at all?
            int i = 0;
            do
            {
                input = Console.ReadLine();
                int newNum = 0;
                int.TryParse(input, out newNum);
                nums[i++] = newNum; // post increment increments `i` after assignment
            } while (string.Compare(input, "exit", true) != 0); // compares to "exit" and ignores case
            Console.WriteLine("The produced array has {0} items", i-1);

            int total;
            for (total = 0, i--; i >= 0; i--)
            {
                total += nums[i];
            }
            Console.WriteLine("Sum: {0}", total);

            // wait
            Console.ReadLine();
        }
    }
}
