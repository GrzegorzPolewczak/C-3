using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation.Peers;
using System.Windows.Controls;

namespace Geometria
{
    public interface IWyswietl : IComparable
    {
        string PobierzIdentyfikator();
    }

    public static class DodajListBox
    {
        public static void Dodaj(this ListBox listBox, IWyswietl element)
        {
            listBox.Items.Add(element.PobierzIdentyfikator());
        }
    }

    public abstract class Bryla : IWyswietl
    {
        public string Nazwa { get; }
        public double Gestosc { get; }
        public double CenaZaKg { get; }

        protected Bryla(string nazwa, double gestosc, double cenaZaKg)
        {
            Nazwa = nazwa;
            Gestosc = gestosc;
            CenaZaKg = cenaZaKg;
        }

        public abstract double ObliczObjetosc();

        public double ObliczMase() => ObliczObjetosc() * Gestosc;

        public double ObliczCene() => ObliczMase() * CenaZaKg;

        public override string ToString()
        {
            return $"Bryła: {Nazwa} \n" +
                   $"Gęstość: {Gestosc}\n" +
                   $"Cena za kg: {CenaZaKg}\n" +
                   $"Objętość: {ObliczObjetosc():F2}\n" +
                   $"Masa: {ObliczMase():F2} \n" +
                   $"Cena: {ObliczCene():F2}";
        }

        public abstract string PobierzIdentyfikator();
        public int CompareTo(object obj)
        {
            // Bryły są po studentach
            if (obj is Student)
                return 1;

            if (obj is Bryla other)
                return -this.ObliczObjetosc().CompareTo(other.ObliczObjetosc()); // malejąco

            return 0;
        }
    }

    public class Kula : Bryla
    {
        public double Promien { get; }
        public Kula(string nazwa,double promien, double gestosc, double cenaZaKg) : base(nazwa, gestosc, cenaZaKg)
        {
            Promien = promien;
        }

        public override double ObliczObjetosc() => (4.0 / 3.0) * Math.PI * Math.Pow(Promien, 3);

        public override string PobierzIdentyfikator()
        {
            return $"Kula: r={Promien}";
        }
    }

    public class Stozek : Bryla
    {
        public double Promien { get; }
        public double Wysokosc { get; }
        public Stozek(string nazwa,double promien, double wysokosc, double gestosc, double cenaZaKg) : base(nazwa, gestosc, cenaZaKg)
        {
            Promien = promien;
            Wysokosc = wysokosc;
        }
        public override double ObliczObjetosc() => (1.0 / 3.0) * Math.PI * Math.Pow(Promien, 2) * Wysokosc;

        public override string PobierzIdentyfikator()
        {
            return $"Stożek: r={Promien}, h={Wysokosc}";
        }
    }

    public class Student : IWyswietl
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public Student(string imie, string nazwisko)
        {
            Imie = imie;
            Nazwisko = nazwisko;
        }
        public string PobierzIdentyfikator()
        {
            return $"Student: {Imie} {Nazwisko}";
        }

        public int CompareTo(object obj)
        {
            if (obj is Student other)
                return string.Compare(this.Nazwisko, other.Nazwisko);
            else
                return -1;
        }
    }
}
