using System;

namespace SpongeBobGenerator
{
    class Program
    {
        static void Main()
        {

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("SpOnGeBoB tExT gEnErAtOr v1.0.0\nby John Crowley");
            Console.ResetColor();

            while (true)
            {

                Console.WriteLine("\nEnter text: ");

                string input = Console.ReadLine();

                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.Yellow;

                for (var i = 0; i < input.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write(char.ToUpper(input[i]));
                    }
                    else
                    {
                        Console.Write(input[i]);
                    }
                }

                Console.ResetColor();

                Console.WriteLine();

            }
        }
    }
}
