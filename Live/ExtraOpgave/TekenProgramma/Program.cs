namespace TekenProgramma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Canvas canvas = new Canvas();

            Cirkel c1 = new Cirkel();
            c1.x = 100;
            c1.y = 200;
            c1.kleur = ConsoleColor.Red;

            Rechthoek r1 = new Rechthoek();
            r1.x = 300;
            r1.y = 100;
            r1.kleur = ConsoleColor.Green;
            r1.breedte = 200;
            r1.lengte = 100;

            

            canvas.cirkels.Add(c1);
            canvas.rechthoeken.Add(r1);

            canvas.Refresh();

            Console.WriteLine("Press Enter to add a cirkel");
            Console.ReadLine();

            Cirkel c2 = new Cirkel
            {
                x = 50,
                y = 100,
                kleur = ConsoleColor.Blue,
                straal = 200
            };

            canvas.cirkels.Add(c2);
            canvas.Refresh();


            // Advanced
            ConsoleKey key;
            do
            {
                Console.WriteLine("Press C to add a circle");
                Console.WriteLine("Press R to add a rectangle");
                key = Console.ReadKey().Key;
                switch(key)
                {
                    case ConsoleKey.R:
                        Rechthoek r = CreateRechthoek();
                        canvas.rechthoeken.Add(r);
                        break;
                    case ConsoleKey.C:
                        Cirkel c = CreateCirkel();
                        canvas.cirkels.Add(c);
                        break;
                    case ConsoleKey.Escape:
                        break;
                }
                canvas.Refresh();
            }
            while (true);
        }


        static Cirkel CreateCirkel()
        {
            Cirkel c1 = new Cirkel();
            c1.kleur = (ConsoleColor)Random.Shared.Next(0, 16);
            c1.y = Random.Shared.Next(0, 500);
            c1.y = Random.Shared.Next(0, 500);
            c1.straal = Random.Shared.Next(10, 300);
            return c1;
        }

        static Rechthoek CreateRechthoek()
        {
            Rechthoek r1 = new Rechthoek();
            r1.kleur = (ConsoleColor)Random.Shared.Next(0, 16);
            r1.y = Random.Shared.Next(0, 500);
            r1.y = Random.Shared.Next(0, 500);
            r1.breedte = Random.Shared.Next(10, 400);
            r1.lengte = Random.Shared.Next(0, 400); ;
            return r1;
        }
    }
}
