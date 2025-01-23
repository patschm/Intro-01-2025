namespace TekenProgramma
{
    internal class Canvas
    {
        ///public List<Cirkel> cirkels = new List<Cirkel>();
        //public List<Rechthoek> rechthoeken = new List<Rechthoek>();

        public List<Vorm> vormen = new List<Vorm>();

        public void Refresh()
        {
            Console.Clear();
            foreach(Vorm vorm in vormen)
            {
                vorm.Teken();
            }
            
        }
    }
}
