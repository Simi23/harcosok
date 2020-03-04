using System;

namespace Harcosok
{
    class Program
    {
        static void Main(string[] args)
        {
            Harcos h1 = new Harcos("Erik", 100, 12);
            Harcos h2 = new Harcos("Powerpoint", 90, 13);

            while (true)
            {
                bool eredmeny = h1.harcol(h2);
                Console.WriteLine(h1.toString());
                Console.WriteLine(h2.toString());
                Console.WriteLine("");

                if (eredmeny)
                {
                    Console.WriteLine("A harcnak vége.");
                    break;
                }
            }
        }
    }
}
