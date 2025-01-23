namespace DeObjectenWereld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Big bang

            Telefoon telefoon1 = new Telefoon();
            telefoon1.hoogte = 15;
            telefoon1.merkNaam = "Samsung";

            Console.WriteLine(telefoon1.hoogte);

            Telefoon telefoon2 = new Telefoon();
            telefoon2.hoogte = 22;
            telefoon2.merkNaam = "Apple";

            Console.WriteLine(telefoon2.hoogte);

            Telefoon telefoon3 = new Telefoon("LG", 20, 10, 1);
            
            Console.WriteLine(telefoon3.hoogte);


            Console.WriteLine(telefoon1.merkNaam);
            Console.WriteLine(telefoon2.merkNaam);
            Console.WriteLine(telefoon3.merkNaam);

            Telefoon[] telefoons = new Telefoon[10];

            Deur d1 = new Deur();
            Deur d2 = new Deur();
            Deur[] deuren = new Deur[10];
            List<Deur> deuren2 = new List<Deur>();

            // Big crunch
        }
    }


    // Blauwdruk telefoon 
    // Custom type
    class Telefoon
    {
        // Fields. Hierin slaan we eigenschappen van het object op.
        public int hoogte;
        public int breedte;
        public int diepte;
        public string merkNaam;

        // Constructor.
        // Hiermee gaaf je FIELDS!!!!!!!! en initiele waarde
        public Telefoon()
        {
            Console.WriteLine("Een telefoon");
        }
        public Telefoon(string merk, int hoogte, int breedte, int diepte)
        {
            // this betekent ik! Me myself and I
            this.hoogte = hoogte;
            this.breedte = breedte;
            this.diepte = diepte;
            merkNaam = merk;
        }
    }
}
