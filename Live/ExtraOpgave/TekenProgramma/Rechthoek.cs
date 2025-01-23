namespace TekenProgramma
{
    internal class Rechthoek
    {
        public ConsoleColor kleur;
        public int x;
        public int y;
        private float _lengte;
        private float _breedte;

        public float Lengte
        {
            get { return _lengte; }
            set
            {
                if (value >= 0)
                {
                    _lengte = value;
                }
            }
        }
        public float Breedte
        {
            get { return _breedte; }
            set
            {
                if (value >= 0)
                {
                    _breedte = value;
                }
            }
        }

        public void Teken()
        {
            Console.ForegroundColor = kleur;
            Console.WriteLine($"Rechthoek op ({x}, {y}) met lengte {Lengte} en breedte {Breedte}");
            Console.ResetColor();
        }
    }
}
