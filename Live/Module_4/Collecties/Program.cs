using System.Text;

namespace Collecties
{
    internal class Program
    {

        static void Main(string[] args)
        {
            // DataType[] naam;
            int[] getallen = new int[10];
            getallen[0] = 4;
            getallen[9] = 10;
            //getallen[10] = 11;
            int nr = getallen[0];

            decimal[] decimals = new decimal[10];
            //string[] texten = new string[5] {"een", "twee", "drie", "vier", "vijf" };
            //string[] texten = new string[] { "een", "twee", "drie", "vier", "vijf" };
            //string[] texten =  { "een", "twee", "drie", "vier", "vijf" };
            string[] texten= [ "een", "twee", "drie", "vier", "vijf" ];
            //texten[0] = "een";
            //texten[1] = "twee";

            Console.WriteLine(texten[2]);


            DateTime[] data = new DateTime[20];
            Roeiboot[] boten = new Roeiboot[12];
            StringReader[] readers = new StringReader[8];
            Schroef[] schroeven = new Schroef[10];

            Roeiboot boot;


            int[] heelveel = new int[100_000];

            for(int offset = 0;  offset < heelveel.Length; offset++) 
            {
                heelveel[offset] = Random.Shared.Next(int.MinValue, int.MaxValue);
            }

            Console.WriteLine(heelveel[53_748]);

            long tmp = 0;
            for(int offset = 0;offset < heelveel.Length;offset++)
            {
                tmp = tmp + heelveel[offset];
            }

            Console.WriteLine(tmp/heelveel.Length);


            List<int> list = new List<int>();
            list.Add(1);

            List<string> list2 = new List<string>();

            List<DateTime> list3 = new List<DateTime>();

            List<Roeiboot> list4 = new List<Roeiboot>();

            //list[1000] = 34;
            Console.WriteLine(list[0]);


            for (int offset = 0; offset < 100_000; offset++)
            {
                int tmp2 = Random.Shared.Next(int.MinValue, int.MaxValue);
                list.Add(tmp2);
               // heelveel[offset] = Random.Shared.Next(int.MinValue, int.MaxValue);
            }

            for(int offset = 0; offset < list.Count;offset++)
            {
                int test = list[offset];
                //Console.WriteLine(test);
            }

            foreach(int test in list)
            {
                Console.WriteLine(test);
            }
        }
    }

    internal class Schroef
    {
    }
}
