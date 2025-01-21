namespace VooruitSpringen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int rnd = Random.Shared.Next(-1, 10);
            Console.WriteLine($"Spiekbriefje {rnd}");


            // Het if-statement is vooral handig als je range-checks gaat uitvoeren
            //bool kleinerDan3 = rnd < 3;
            //if (kleinerDan3)
            if (rnd > 0 && rnd < 3)
            {
                Console.WriteLine("{0} is kleiner dan 3", rnd);
            }
            else if (rnd < 7)
            {
                Console.WriteLine($"{rnd} is kleiner dan 7 en groter of gelijk aan 3");
            }
            else
            {
                Console.WriteLine($"{rnd} is groter of gelijk aan 7");
            }

            // De switch gebruik je als je op conrete waarden wil testen
            switch (rnd)
            {
                case 0:
                case 1:
                    Console.WriteLine("Een");
                    break;
                case 2:
                    Console.WriteLine("Twee");
                    break;
                case 3:
                    Console.WriteLine("Drie");
                    break;
                default:
                    Console.WriteLine($"Iets anders. nm {rnd}");
                    break;
            }

            char key = Console.ReadKey().KeyChar;

            switch (key)
            {
                case 'h':
                case 'H':
                    Console.WriteLine("Er is op H gedrukt");
                    break;
                default:
                    Console.WriteLine($"een andere toets ({key})");
                    break;
            }

            Console.WriteLine("Goodbye World!");
        }
    }
}
