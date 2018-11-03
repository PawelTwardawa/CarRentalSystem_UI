using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj2_PTwardawa
{
     public class Dane
    {
        private string miejscowosc;
        private string ulica;
        private string nr_domu;
        private string kod_pocztowy;

        public Dane(string miejscowosc, string ulica, string nr_domu, string kod_pocztowy)
        {
            this.miejscowosc = miejscowosc;
            this.ulica = ulica;
            this.nr_domu = nr_domu;
            this.kod_pocztowy = kod_pocztowy;
        }
        ~Dane()
        {

        }

        public string Miejscowosc
        {
            get
            {
                return miejscowosc;
            }
        }
        public string Ulica
        {
            get
            {
                return ulica;
            }
        }
        public string Nr_domu
        {
            get
            {
                return nr_domu;
            }
        }
        public string Kod_pocztowy
        {
            get
            {
                return kod_pocztowy;
            }
        }
    }
}
