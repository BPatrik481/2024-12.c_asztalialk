using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Írjunk olyan programot, amely addig kér
be egész számokat a billentyűzetről, amíg azok összege meg nem haladja a 100-at. A
beolvasás végén írjuk ki azt, hogy a bekért számok közül hány volt páros, és hány volt
páratlan.*/

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
