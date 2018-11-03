using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj2_PTwardawa
{
    
     public abstract class Osoba
    {
        protected string imie;
        protected string nazwisko;
        protected string pesel;
        protected Dane adres;

        public Osoba()
        {
            
        }

        public Osoba(string imie, string nazwisko, string pesel, string miejscowosc, string ulica, string nr_domu, string kod_pocztowy)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.pesel = pesel;
            this.adres = new Dane(miejscowosc, ulica, nr_domu, kod_pocztowy);
        }    
        ~Osoba()
        {

        }
        
        public  string Imie
        {
            get
            {
                return imie;
            }
        }
        public string Nazwisko
        {
            get
            {
                return nazwisko;
            }
        }
        public string Pesel
        {
            get
            {
                return pesel;
            }
        }
        public Dane Adres
        {
            get
            {
                return adres;
            }
        }     
    }
}
