using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int paros = 0;
            int paratlan = 0;

            while (true)
            {
                Console.Write("Adj meg egy számot: ");
                int szam = Convert.ToInt32(Console.ReadLine());

                sum += szam;

                if (szam % 2 == 0)
                {
                    paros++;
                }
                else
                {
                    paratlan++;
                }

                if (sum > 100)
                {
                    break;
                }
            }

            Console.WriteLine($"a számok összege: {sum}");
            Console.WriteLine($"Páros számok: {paros}");
            Console.WriteLine($"Páratlan számok: {paratlan}");
            Console.ReadLine();
        }
    }
}
