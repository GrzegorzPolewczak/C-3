using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadA
{
    class Obywatel
    {
        private string nazwisko;
        private long pesel;

        public static List<Obywatel> Obywatele = new List<Obywatel>();

        public Obywatel(string nazwisko, long pesel)
        {
            this.nazwisko = nazwisko;
            this.pesel = pesel;
            Obywatele.Add(this);
        }

        public override string ToString()
        {
            return $"Nazwisko: { nazwisko }, PESEL: { pesel }";
        } 
            

    }
}
