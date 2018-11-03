using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj2_PTwardawa
{
   public class Pracownik : Osoba
    {
        public static int unikalne_id;
        private float wynagrodzenie;
        DateTime data_zatrudnienia;
        private int id_pracownika;

        Pracownik()
        {

        }
        public Pracownik(float wynagrodzenie, DateTime data_zatrudnienia, string imie, string nazwisko, string pesel, string miejscowosc, string ulica, string nr_domu, string kod_pocztowy): base(imie,nazwisko,pesel,miejscowosc,ulica,nr_domu,kod_pocztowy)
        {
            this.wynagrodzenie = wynagrodzenie;
            this.data_zatrudnienia = data_zatrudnienia;
            id_pracownika = unikalne_id;
            unikalne_id++;
        }
        public Pracownik(int id, float wynagrodzenie, DateTime data_zatrudnienia, string imie, string nazwisko, string pesel, string miejscowosc, string ulica, string nr_domu, string kod_pocztowy) : base(imie, nazwisko, pesel, miejscowosc, ulica, nr_domu, kod_pocztowy)
        {
            this.wynagrodzenie = wynagrodzenie;
            this.data_zatrudnienia = data_zatrudnienia;
            id_pracownika = id;
        }

        ~Pracownik()
        {

        }
        public float Wynagrodzenie
        {
            get
            {
                return wynagrodzenie;
            }
        }
        public DateTime Data_zatrudnienia
        {
            get
            {
                return data_zatrudnienia;
            }
        }
        public int Id_pracownika
        {
            get
            {
                return id_pracownika;
            }
        }
    }
}
