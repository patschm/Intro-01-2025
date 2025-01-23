namespace DeObjectenWereld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Big bang

            Telefoon telefoon1 = new Telefoon();
            telefoon1.Hoogte = -15;
            telefoon1.Merk = "Samsung";

            telefoon1.LaadOp();

            Console.WriteLine(telefoon1.Hoogte);

            Telefoon telefoon2 = new Telefoon();
            telefoon2.Hoogte = 15;
            //.hoogte = 22;
            telefoon2.Merk = "Apple";

            telefoon2.LaadOp();

            Console.WriteLine(telefoon2.Hoogte);

            Telefoon telefoon3 = new Telefoon("LG", 20, 10, 1);
            telefoon3.LaadOp();

            Console.WriteLine(telefoon3.Hoogte);


            Console.WriteLine(telefoon1.Merk);
            Console.WriteLine(telefoon2.Merk);
            Console.WriteLine(telefoon3.Merk);

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
    //[Obsolete("Gebruik die andere class")]
    class Telefoon
    {
        // Fields. Hierin slaan we eigenschappen van het object op.
        private int _hoogte = 20;
        // int breedte;
        //public int diepte;
        public OplaadPoort chargePort = new OplaadPoort();


        // propfull
        private int _breedte;

        public int Breedte
        {
            get { return _breedte; }
            set { _breedte = value; }
        }


        // Auto-generating properties. Die genereert zijn eigen private field
        public string Merk { get; set; } = "Neutraal";
        // prop
        public int Diepte { get; set; }

        // Properties. Met properties regel je de (gecontroleerde) toegang tot jouw private fields
        public int Hoogte
        {
            get
            {
                return _hoogte;
            }
            set
            {
                if (value >= 0 && value < 40)
                {
                    _hoogte = value;
                }
            }
        }

        // Zo doen C++-ers dat
        //public void SetHoogte(int hgt)
        //{
        //    if (hgt >= 0 && hgt < 40)
        //    {
        //        _hoogte = hgt;
        //    }
        //}
        //public int GetHoogte()
        //{
        //    return _hoogte;
        //}
        // Methods. Hierin definieren we het gedrag van het object
        public void LaadOp()
        {
            Console.WriteLine($"De {Merk} gaan nu laden");
            chargePort.ZuigEnergie();
        }

        // Constructor.
        // Hiermee gaaf je FIELDS!!!!!!!! en initiele waarde
        public Telefoon()
        {
            Console.WriteLine("Een telefoon");
            chargePort = new OplaadPoort();
        }
        public Telefoon(string merk, int hoogte, int breedte, int diepte)
        {
            // this betekent ik! Me myself and I
            Hoogte = hoogte;
            this.breedte = breedte;
            this.diepte = diepte;
            Merk = merk;
        }
    }
}
