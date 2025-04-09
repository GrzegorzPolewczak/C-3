using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadC
{
    public struct Prostopadloscian
    {
        public double Wysokosc { get; }
        public double Szerokosc { get; }
        public double Grubosc { get; }

        public Prostopadloscian(double wysokosc,double szerokosc, double grubosc)
        {
            Wysokosc = wysokosc;
            Szerokosc = szerokosc;
            Grubosc = grubosc;
        }

        public Prostopadloscian(double bok):this(bok,bok,bok)
        {

        }

        public override string ToString()
        {
            return $"Wysokosc: {Wysokosc}, Szerokosc: {Szerokosc}, Grubosc: {Grubosc}";
        }
    }
}
