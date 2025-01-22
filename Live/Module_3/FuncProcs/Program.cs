namespace FuncProcs
{
    class Program
    { 
        static void Main(string[] args)
        {
            int x = 42;
            ShowWelcomsScreen();
            string voornaam = "Patrick";

            voornaam = AskForName();

            //string name = voornaam;
            ShowName(voornaam);
            ShowName("123");
        }

        // Hier mag je functies en procedures definieren

        // Procedures
        static void ShowWelcomsScreen()
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
            Console.ResetColor();
            return line;

            //return AskForName(ConsoleColor.Yellow);
        }
        // Overload van AskForName()
        static string AskForName(ConsoleColor color)
        {
            Console.BackgroundColor = color;
            Console.WriteLine("Wat is uw naam?");
            string line = Console.ReadLine();
            Console.ResetColor();
            return line;
        }

    }
}
