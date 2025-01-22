

namespace FuncProcs
{
    internal class TestClass
    {
        // Procedures
        static public void ShowWelcomsScreen()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Welcome to this magnificent program");
            Console.ResetColor();
        }
        static void ShowName(string name)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Nice to meet you {name}");
            Console.ResetColor();
        }

        // Functions
        static string AskForName()
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Wat is uw naam?");
            string line = Console.ReadLine();
            return line;

            //return AskForName(ConsoleColor.Yellow);
        }
        // Overload van AskForName()
        static string AskForName(ConsoleColor color)
        {
            Console.BackgroundColor = color;
            Console.WriteLine("Wat is uw naam?");
            string line = Console.ReadLine();
            return line;
        }

    }
}
