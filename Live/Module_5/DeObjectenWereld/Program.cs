namespace DeObjectenWereld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Big bang

            // Generaliserem

            Telefoon t1 = new Apple
            {
                Mute = true
            };
           
            t1.LaadOp();

            Telefoon s1 = new Samsung();
            s1.LaadOp();
            

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
            chargePort = new OplaadPoort();
        }
        public Telefoon(string merk, int hoogte, int breedte, int diepte)
        {
            // this betekent ik! Me myself and I
            Hoogte = hoogte;
            Breedte = breedte;
            Diepte = diepte;
            Merk = merk;
        }
    }

    // Apple erft van Telefoon 
    class Apple : Telefoon
    {
        public bool Mute { get; set; }

        public void LaadOp()
        {
            Console.WriteLine($"De {Merk} IPhone gaan nu laden ({Mute})");
            chargePort.ZuigEnergie();
        }
        public Apple()
        {
            chargePort = new OplaadPoort();
            Merk = "Apple";
        }
        public Apple(string merk, int hoogte, int breedte, int diepte)
        {
            Hoogte = hoogte;
            Breedte = breedte;
            Diepte = diepte;
            Merk = "Apple";
        }
    }

    class Samsung : Telefoon
    {
        public void LaadOp()
        {
            Console.WriteLine($"De {Merk} S25 gaan nu laden");
            chargePort.ZuigEnergie();
        }
        public Samsung()
        {
            chargePort = new OplaadPoort();
            Merk = "Samsung";
        }
        public Samsung(string merk, int hoogte, int breedte, int diepte)
        {
            Hoogte = hoogte;
            Breedte = breedte;
            Diepte = diepte;
            Merk = "Samsung";
        }
    }
}
