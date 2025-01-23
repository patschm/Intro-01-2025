
namespace DeObjectenWereld
{
    internal class OplaadPoort
    {
        public virtual void ZuigEnergie()
        {
            Console.WriteLine("We leveren nu stroom");
        }
    }

    class USBCPoort : OplaadPoort
    {
        public override void ZuigEnergie()
        {
            Console.WriteLine("We leveren nu stroom via USB-C");
        }
    }

    class LighteningPoort: OplaadPoort
    {
        public override void ZuigEnergie()
        {
            Console.WriteLine("We leveren nu stroom via Lightening");
        }
    }
}
