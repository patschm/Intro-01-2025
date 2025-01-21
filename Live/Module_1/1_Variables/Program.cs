namespace Variables
{
    // Scope Namespace

    internal class Program
    {
        //string name = "Patrick";


        // Main Entry Point
        static void Main(string[] args)
        {
            // Hier begint het programma.



            // Declaratie van een variabele
            //{
            // DataType Naam = Initialisatie.
            char a = 'A';
            string name = "Patrick";
            // 32 bits
            int age = 430;
            // Casting
            byte b = (byte)age;
            int c = b;
            Console.WriteLine(b);
            // 16 bits
            short kort = 32_000;
            // 8-bits
            byte manvrouw = 1;
            bool isMan = true;
            // 32-bits
            //float drijver = 34.7;
            decimal geld = 123456789.123456789M;
            Console.WriteLine(geld);

            float d = (float)3.6;

            // 64-bits
            double dubbel = 42.9;

            // 128-bits
            //decimal geld = 67.9;

            //}

            // string getal = "128128128128";
            //int igetal = int.Parse(getal);

                int igetal = age * 100_000_000;
                Console.WriteLine(igetal);
            Console.WriteLine(name);


            // Hier eindigt het programma.
        }
    }
}
