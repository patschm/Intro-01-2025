namespace TekenProgramma
{
    internal class Cirkel
    {
        public ConsoleColor kleur;
        public int x;
        public int y;
        private float _straal;

        public float Straal
        {
            get { return _straal; }
            set
            {
                if (value >= 0)
                {
                    _straal = value;
                }
            }
        }

        public void Teken()
        {
            Console.ForegroundColor = kleur;
            Console.WriteLine($"Cirkel op ({x}, {y}) met straal {Straal}");
            Console.ResetColor();
        }
    }
}
