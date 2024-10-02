using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logikai
{
    class Program
    {
        static void Main(string[] args)
        {
            bool i = true,
                 h = false;
            #region ÉS Kapcsolat
            Console.WriteLine("Az és (&&) kapcsolat");
                Console.WriteLine($"Ha i={i} és h={h}, akkor i&&h = {i && h} ");

            i = true;
            h = true;

            Console.WriteLine($"Ha i={i} és h={h}, akkor i&&h = {i && h} ");

            i = false;
            h = true;

            Console.WriteLine($"Ha i={i} és h={h}, akkor i&&h = {i && h} ");

            i = false;
            h = false;

            Console.WriteLine($"Ha i={i} és h={h}, akkor i&&h = {i && h} ");
            #endregion Eof ÉS Kapcsolat
            #region VAGY Kapcsolat
            i = true;
            h = false;
            Console.WriteLine("\nAz vagy (||) kapcsolat");
            Console.WriteLine($"Ha i={i} vagy h={h}, akkor i||h = {i || h} ");

            i = true;
            h = true;

            Console.WriteLine($"Ha i={i} vagy h={h}, akkor i||h = {i || h} ");

            i = false;
            h = true;

            Console.WriteLine($"Ha i={i} vagy h={h}, akkor i||h = {i || h} ");

            i = false;
            h = false;

            Console.WriteLine($"Ha i={i} vagy h={h}, akkor i||h = {i || h} ");
            #endregion Eof VAGY Kapcsolat
            Console.ReadKey();
        }
    }
}
