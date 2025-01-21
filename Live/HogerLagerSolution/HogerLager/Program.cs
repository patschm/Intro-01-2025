namespace HogerLager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int max = 10;

            ConsoleKey key;
            do
            {
                int hetTeRadenGetal = Random.Shared.Next(max + 1);
               // int guess = 0;
                Console.WriteLine("Welkom bij Raad het Getal");
                do
                {
                    Console.WriteLine($"Geef een getal tusen  0 en {max} en druk op Enter om te evaluaren");
                    string line = Console.ReadLine();
                    int guess = int.Parse(line);
                    if (guess == hetTeRadenGetal)
                    {
                        // Irrelevante cosmetica
                        for (int i = 0; i < 80; i++)
                        {
                            Console.Beep(2000, 20);
                            if (i < 30)
                            {
                                Console.Write("{");
                            }

                            if (i == 30)
                            {
                                Console.Write("Geraden");
                            }
                            if (i > 38)
                            {
                                Console.Write("}");
                            }

                            //Task.Delay(20).Wait();
                        }
                        Console.WriteLine();
                        break;
                    }
                    if (guess < hetTeRadenGetal)
                    {
                        Console.WriteLine($"{guess} is kleiner dan het te raden getal");
                    }
                    if (guess > hetTeRadenGetal)
                    {
                        Console.WriteLine($"{guess} is groter dan het te raden getal");
                    }
                }
                while (true);
                Console.WriteLine("Nog een keer? (ESC om te stoppen)");
                key = Console.ReadKey().Key;
                Console.Clear();
            }
            while (key != ConsoleKey.Escape);
        }
    }
}
