namespace Expressies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int getalA = 10;
            //Console.WriteLine(getalA);

            // Expressie
            int result =  getalA + 20;
            //Console.WriteLine(getalA);
            //Console.WriteLine(result);
            getalA = getalA + 20;
            getalA += 20;
            getalA++;
            //.WriteLine(getalA);
            //Console.WriteLine(result);
            result = getalA + 20;
            //Console.WriteLine(getalA);
            //Console.WriteLine(result);

            int getalB = 30;

            //int resultA = getalA + getalB;
            double resultD = getalA / getalB;

            string a = "10";
            string b = "20";

            string r = a + getalB;

            bool isGroter = getalA < 10;
            bool isGelijk = 10 == getalA;

            // 0001
            int iA = 1;
            // 0010
            int iB = 3;

            // 0001 AND 0010 = 0000
            int iRes= iA & iB;
            Console.WriteLine(iRes);

            bool bA = false;
            bool bB = true;

            bool bResult = bA && iB > 10;
            Console.WriteLine(bResult);

            float fA = 9.9F;

            bool fB = fA > 9;
            Console.WriteLine(fB);
            Console.WriteLine(r);
            Console.WriteLine(resultD);

            int nrA = 10;
           // ++nrA;
            Console.WriteLine(nrA++);
            Console.WriteLine(nrA);

        }
    }
}
