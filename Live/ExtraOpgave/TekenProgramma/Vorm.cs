namespace TekenProgramma
{
    internal class Vorm
    {
        public ConsoleColor kleur;
        public int x;
        public int y;

        public virtual void Teken()
        {
            Console.WriteLine("Vorm");
        }
    }
}
