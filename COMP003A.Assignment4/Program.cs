/*
 * Author: Oscar Mendez
 * Course: COMP-003A
 * Purpose: to complete assignment as shown for loop statements
 */

namespace COMP003A.Assignment4_
{
    internal class Program
    {
        static void Main(string[] args)

        // Loop section of the code
        {
            Console.WriteLine("".PadRight(50, '*'));
            Console.WriteLine("for loop section");
            Console.WriteLine("Output a right triangle based on user input");
            Console.WriteLine("".PadRight(50, '*'));


            // User input
            Console.Write("Enter a positive whole number: ");
            int limit = int.Parse(Console.ReadLine());

            // Declaring string variable as #
            string output = "#";

            // For loop statement
            for (int i = 0; i < limit; i++)
            {
                // Output for value
                Console.WriteLine(output);
                output += "#";
            }

            // A blank line for spacing
            Console.WriteLine();

            // Foreach section
            Console.WriteLine("".PadRight(50, '*'));
            Console.WriteLine("foreach Section");
            Console.WriteLine("Output all of the friends in an array");
            Console.WriteLine("".PadRight(50,'*'));

            // creating an array
            string[] friends = new string[]
            {
                "Rachel", "Joey", "Chandler", "Ross", "Monica", "Phoebe"
            };

            // Foreach statement
            foreach (string friend in friends)
            {
                // Output of each friend
                Console.WriteLine(friend);
            }

            // A blank line for spacing
            Console.WriteLine();

            Console.WriteLine("".PadRight(50, '*'));
            Console.WriteLine("do-while Section");
            Console.WriteLine("Output 0-50 by 5s");
            Console.WriteLine("".PadRight(50, '*'));

            // Declared an integer and assigned value
            int counter = 0;

            // Do-while statement with condition
            do
            {
                Console.WriteLine(counter);
                counter += 5;
            } while (counter <= 50);

            // A blank line for spacing
            Console.WriteLine();

            // While section
            Console.WriteLine("".PadRight(50, '*'));
            Console.WriteLine("while Section");
            Console.WriteLine("Output 1-20");
            Console.WriteLine("If the number is divisible by 2, output Foo");
            Console.WriteLine("If the number is divisible by 5, output Bar");
            Console.WriteLine("If the number is divisible by 2 & 5, output FooBar");
            Console.WriteLine("".PadRight(50, '*'));

            // Declared integer named counter2 with value of 1
            int counter2 = 1;
            while (counter2 <= 20) 
            {
                // Combination of if statements
                if (counter2 % 2 == 0 && counter2 % 5 == 0)
                {
                    Console.WriteLine("FooBar");
                }
                else if (counter2 % 2 == 0)
                {
                    Console.WriteLine("Foo");
                }
                else if (counter2 % 5 == 0)
                {
                    Console.WriteLine("Bar");
                }
                else
                {
                    Console.WriteLine(counter2);
                }

                // Incrementing value of counter2 by 1
                counter2++;
            }
        }
    }
}
