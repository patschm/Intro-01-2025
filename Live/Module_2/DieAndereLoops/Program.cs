using System.Data.Common;

namespace DieAndereLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Beide loops gebruik je als je vantevoren niet weet hoe vaak vaak
            // iets moet worden herhaald.

            bool condition = false;
            // While gebruik je als iets 0 of meer keer moet worden uitgevoerd.
            // Voor het uit
            //DbDataReader rdrd = null;
            //while(rdrd.Read()) 
            while (condition) 
            {
                Console.WriteLine("While-do");
            }

            // Do gebruik je als iets 1 of meer keer moet worden uitgevoerd.
            // Bijvoorbeeld User invoer (Je weet niet hoe vaak zij het fout doet)
            do
            {
                Console.WriteLine("Do-While");
            }
            while (condition);

        }
    }
}
