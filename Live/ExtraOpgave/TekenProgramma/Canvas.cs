namespace TekenProgramma
{
    internal class Canvas
    {
        public List<Cirkel> cirkels = new List<Cirkel>();
        public List<Rechthoek> rechthoeken = new List<Rechthoek>();

        public void Refresh()
        {
            Console.Clear();
            foreach(Cirkel cirkel in cirkels)
            {
                cirkel.Teken();
            }
            foreach(Rechthoek rechthoek in rechthoeken)
            {
                rechthoek.Teken();
            }
        }
    }
}
