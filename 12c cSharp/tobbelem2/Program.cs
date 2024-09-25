using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Írjunk olyan programot, amely addig kér
be egész számokat a billentyűzetről, amíg azok összege meg nem haladja a 100-at. A
beolvasás végén írjuk ki azt, hogy a bekért számok közül hány volt páros, és hány volt
páratlan.*/

namespace tobbelem2
{
    class TobbElemOsztaly
    {
        //osztályváltozók
        private int szam;
        private bool isParos;
        //konstruktor
        public TobbElemOsztaly()
        {
           this.szam = 0;
           this.isParos = false;
        }

        public void Getszam(int p)
        {
           this.szam = p;
        }

        public void SetSzamTipus()
        {
            this.isParos = szam % 2 == 0;
        }

        public bool outSzamTipus()
        {
            return this.isParos;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //osztályváltozók
            string valasz = String.Empty;
            int paros = 0,
                szam=0,
            paratlan = 0;

            //Példányosítjuk az osztályt
            //másnéven objektumot hozunk létre az osztálynak

            TobbElemOsztaly a = new TobbElemOsztaly();

            //Szám megadása
            while (paros + paratlan < 100)
            {
                Console.WriteLine("adj meg egy egész számot:");
                szam = Convert.ToInt32(Console.ReadLine());
                a.Getszam(szam);
                a.SetSzamTipus();
                if (a.outSzamTipus())
                {
                    valasz = "paros";
                    paros+=szam;
                }
                else
                {
                    valasz = "paratlan";
                    paratlan+=szam;
                }
                Console.WriteLine($"A szám tipusa: {valasz}, eddig {paros + paratlan} számot adott meg.");
                Console.ReadKey();
            }
        }
    }
}
