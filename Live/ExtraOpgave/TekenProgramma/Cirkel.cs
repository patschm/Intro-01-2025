namespace TekenProgramma
{
    internal class Cirkel
    {
        public ConsoleColor kleur;
        public int x;
        public int y;
        public float straal;

        public void Teken()
        {
            Console.ForegroundColor = kleur;
            Console.WriteLine($"Cirkel op ({x}, {y}) met straal {straal}");
            Console.ResetColor();
        }
    }
}
