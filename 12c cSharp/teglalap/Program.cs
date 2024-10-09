using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace korhasab
{
    class Program
    {
        static void Main(string[] args)
        {
            //A kor osztály felhsználása
            //1. objektum
            #region 1.objektum
            tegla k1 = new tegla();
            k1.ReadAoldal(10.0);
            k1.ReadBoldal(23.0);
            k1.SetKerulet();
            k1.SetTerulet();

            Console.WriteLine($"A {k1.GetAoldal()}, {k1.GetBoldal()} oldalú teglalap, kerülete: {k1.GetKerulet()}, területe: {k1.GetTerulet()} ");
            #endregion Eof 1.objektum
            #region 2. objektum
            tegla k2 = new tegla(21.7, 10.96);
            k2.SetKerulet();
            k2.SetTerulet();

            Console.WriteLine($"A {k2.GetAoldal()}, {k2.GetBoldal()} oldalú teglalap, kerülete: {k2.GetKerulet()}, területe: {k2.GetTerulet()} ");

            #endregion Eof 2. objektum
            Console.ReadKey();
        }
    }
}
