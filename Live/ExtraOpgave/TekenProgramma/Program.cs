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
            r1.Breedte = 200;
            r1.Lengte = 100;

            
            canvas.vormen.Add(c1);
            canvas.vormen.Add(r1);

            canvas.Refresh();

            Console.WriteLine("Press Enter to add a cirkel");
            Console.ReadLine();

            Cirkel c2 = new Cirkel
            {
                x = 50,
                y = 100,
                kleur = ConsoleColor.Blue,
                Straal = 200
            };

            canvas.vormen.Add(c2);
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
                        canvas.vormen.Add(r);
                        break;
                    case ConsoleKey.C:
                        Cirkel c = CreateCirkel();
                        canvas.vormen.Add(c);
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
            c1.x = Random.Shared.Next(0, 500);
            c1.Straal = Random.Shared.Next(10, 300);
            return c1;
        }

        static Rechthoek CreateRechthoek()
        {
            Rechthoek r1 = new Rechthoek();
            r1.kleur = (ConsoleColor)Random.Shared.Next(0, 16);
            r1.y = Random.Shared.Next(0, 500);
            r1.x = Random.Shared.Next(0, 500);
            r1.Breedte = Random.Shared.Next(10, 400);
            r1.Lengte = Random.Shared.Next(0, 400); ;
            return r1;
        }
    }
}
