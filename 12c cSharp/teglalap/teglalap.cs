using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace korhasab
{
    class tegla
    {
        //Osztályváltozók

        private double a_old,
            b_old,
            kerulet,
            terulet;

        //Konstruktorok
        public tegla() {}

        public tegla(double a, double b)
        {
            this.a_old = a;
            this.b_old = b;
        }

        //metodusok

        public void ReadAoldal(double a)
        {
            this.a_old = a;
        }

        public void ReadBoldal(double b)
        {
            this.b_old = b;
        }

        public void SetKerulet()
        {
            this.kerulet = 2 * (a_old + b_old);
        }

        public void SetTerulet()
        {
            this.terulet = a_old * b_old;
        }
        public double GetKerulet() { return this.kerulet; }
        public double GetTerulet() { return this.terulet; }

        public double GetAoldal() { return this.a_old; }
        public double GetBoldal() { return this.b_old; }

    }
}
