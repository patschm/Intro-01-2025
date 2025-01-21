namespace _4a_looping
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // int teller = 0;

            // De for-loop gebruik je als je weet hoe vaak je iets wilt herhalen.
            for (int teller = 1; teller <= 10; teller++)
            {
                if (teller == 9)
                {
                    // Stopt de hele loop
                    break;
                }
                if (teller == 5) 
                {
                    // Stopt de huidige iteratie
                    continue;
                }
                //Task.Delay(500).Wait();
                Console.WriteLine($"Hello, World! {teller}");
            }
            //Console.WriteLine(teller);
            Console.WriteLine("En verder....");
        }
    }
}
