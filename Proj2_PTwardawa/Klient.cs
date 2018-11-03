using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj2_PTwardawa
{
   public class Klient : Osoba
    {
        public static int unikalne_id = 0;
        private int id_klienta;

        public Klient()
        {

        }
        public Klient(string imie, string nazwisko, string pesel, string miejscowosc, string ulica, string nr_domu, string kod_pocztowy): base(imie,nazwisko, pesel,miejscowosc,ulica,nr_domu,kod_pocztowy)
        {
            
            id_klienta = unikalne_id;
            unikalne_id++;
            
        }
        public Klient(int id, string imie, string nazwisko, string pesel, string miejscowosc, string ulica, string nr_domu, string kod_pocztowy) : base(imie, nazwisko, pesel, miejscowosc, ulica, nr_domu, kod_pocztowy)
        {

            id_klienta = id;

        }
        ~Klient()
        {

        }

        public int Id_klienta
        {
            get
            {
                return id_klienta;
            }
        }
    }
}
