using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Macskak
{
    class Program
    {
        enum Animal {Cat, Dog, Tiger, Wolf};
        static void Main(string[] args)
        {
            Animal b = Animal.Wolf;
            Animal c = Animal.Cat;

            if (b == Animal.Wolf)
            {
                Console.WriteLine("A b állat farkas");
            }
            if (c == Animal.Cat)
            {
                Console.WriteLine("A c állat macska");
            }
            Console.ReadKey();
        }
    }
}
