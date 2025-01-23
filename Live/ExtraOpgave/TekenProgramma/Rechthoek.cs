namespace TekenProgramma
{
    internal class Rechthoek
    {
        public ConsoleColor kleur;
        public int x;
        public int y;
        public float lengte;
        public float breedte;

        public void Teken()
        {
            Console.ForegroundColor = kleur;
            Console.WriteLine($"Rechthoek op ({x}, {y}) met lengte {lengte} en breedte {breedte}");
            Console.ResetColor();
        }
    }
}
