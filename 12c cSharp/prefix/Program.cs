using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prefix
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10,
                y = 112;

            Console.WriteLine($"Az x eredeti értéke {x}");
            Console.WriteLine($"Az x értéke '++x' iratással ({x++}) az");
            Console.WriteLine($"Az x értéke kiíratás után {x}");

            Console.WriteLine($"\nAz y eredeti értéke {y}");
            Console.WriteLine($"Az y értéke '++y' iratással ({y++}) az");
            Console.WriteLine($"Az y értéke kiíratás után {y}");

            Console.ReadKey();
        }
    }
}
