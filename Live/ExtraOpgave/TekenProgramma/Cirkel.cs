namespace TekenProgramma
{
    internal class Cirkel : Vorm
    {
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
