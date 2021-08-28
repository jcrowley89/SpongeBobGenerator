using System;

namespace SpongeBobGenerator
{
    class Program
    {
        static void Main()
        {

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("|----------------------------------------------------|");
            Console.WriteLine("|  SpOnGeBoB tExT gEnErAtOr v1.0.0 by John Crowley   |");
            Console.WriteLine("|----------------------------------------------------|\n");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("      .--..--..--..--..--..--.");
            Console.WriteLine("    .' \\  (`._   (_)     _   \\");
            Console.WriteLine("  .'    |  '._)         (_)  |");
            Console.WriteLine("  \\ _.')\\      .----..---.   /");
            Console.WriteLine("  | (_.'  |    /    .-\\-.  \\  |");
            Console.WriteLine("  \\     0 |    |   ( O| O) | o|");
            Console.WriteLine("   |  _  |  .--.____.'._.-.  |");
            Console.WriteLine("   \\ (_) | o         -` .-`  |");
            Console.WriteLine("    |    \\   |`-._ _ _ _ _\\ /");
            Console.WriteLine("    \\    |   |  `. |_||_|   |");
            Console.WriteLine("    | o  |    \\_      \\     |     -.   .-.");
            Console.WriteLine("    |.-.  \\     `--..-'   O |     `.`-' .'");
            Console.WriteLine("  _.'  .' |     `-.-'      /-.__   ' .-'");
            Console.WriteLine(".' `-.` '.|='=.='=.='=.='=|._/_ `-'.'");
            Console.WriteLine("`-._  `.  |________/\\_____|    `-.'");
            Console.WriteLine("   .'   ).| '=' '='\\/ '=' |");
            Console.WriteLine("   `._.`  '---------------'");
            Console.WriteLine("             //___\\   //___\\");
            Console.WriteLine("             ||        ||");
            Console.WriteLine("             || _.-.   ||_.-.");
            Console.WriteLine("            (_.--__) (_.--__)");

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
                        Console.Write(char.ToLower(input[i]));
                    }
                }

                Console.ResetColor();

                Console.WriteLine();

            }
        }
    }
}
