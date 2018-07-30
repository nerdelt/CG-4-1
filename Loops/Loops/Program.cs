using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //asks user for number
            Console.Write("Please enter a number: ");

            //takes user number and turns it into int
            string userNumber = Console.ReadLine();
            int number = int.Parse(userNumber);

            //loops from 2 to 20 multiplying user input
            int sum = 0;

            for (int i = 2; i < 21; i++)
            {
                int multiple = i * number;
                Console.WriteLine($"{number} x {i} = {multiple}");
                sum += i * number;
            }

            // sum of all these numbers 
            Console.WriteLine($"The sum of these numbers is: {sum}");
            Console.ReadLine();

                
        }
    }
}
