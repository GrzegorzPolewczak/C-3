using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadB
{
    class Stozek
    {
        private double promien;
        private double wysokosc;

        public double Promien
        {
            get { return promien; }
            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Promień nie może być ujemna");
                }
                promien = value; 
            }
        }

        public double Wysokosc
        {
            get { return wysokosc; }
            set 
            { 
                if(value <= 0)
                {
                    throw new ArgumentException("Wysokość nie może być ujemna");
                }
                wysokosc = value;
            }
        }

        public double Objetosc()
        {
            return (wysokosc * Math.PI * Math.Pow(promien,2.0))/3.0;
        }

        public double PolePowierzchni()
        {
            double lkwadrat = Math.Pow(promien, 2) + Math.Pow(wysokosc, 2);
            double l = Math.Sqrt(lkwadrat);
            return Math.PI * promien * (promien + l);
        }


        public override string ToString()
        {
            return $"Wysokość: {wysokosc}, Promień: {promien}, Objętość: {Objetosc():F2}, Pole powierzchni: {PolePowierzchni():F2}";
        }
    }
}
