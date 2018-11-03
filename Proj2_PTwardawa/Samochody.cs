using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj2_PTwardawa
{
    public class Samochody
    {
        public static int unikalne_id = 0;
        private string marka;
        private string model;
        private int rok_produkcji;
        private int przebieg;
        private string kolor;
        private int id_samochodu;
        private int id_klienta;
        private int id_pracownika;
        private DateTime data_wypozyczenia;

        Samochody()
        {

        }
        public Samochody(string marka, string model, int rok_produkcji, int przebieg, string kolor)
        {
            this.rok_produkcji = rok_produkcji;
            this.marka = marka;
            this.model = model;
            
            this.przebieg = przebieg;
            this.kolor = kolor;
            this.id_samochodu = unikalne_id;
            unikalne_id++;
            this.id_klienta = -1;
            this.id_pracownika = -1;
        }
        public Samochody(int id_samochodu, int id_klienta, int id_pracownika, string marka, string model, int rok_produkcji, int przebieg, string kolor, DateTime data_wypozyczenia)
        {
            this.rok_produkcji = rok_produkcji;
            this.marka = marka;
            this.model = model;
            
            this.przebieg = przebieg;
            this.kolor = kolor;
            this.data_wypozyczenia = data_wypozyczenia;
            this.id_samochodu = id_samochodu;
            this.id_klienta = id_klienta;
            this.id_pracownika = id_pracownika;
        }
        ~Samochody()
        {

        }
        public string Marka
        {
            get
            {
                return marka;
            }
        }
        public string Model
        {
            get
            {
                return model;
            }
        }
        public int Rok_produkcji
        {
            get
            {
                return rok_produkcji;
            }
        }
        public int Przebieg
        {
            get
            {
                return przebieg;
            }
        }
        public string Kolor
        {
            get
            {
                return kolor;
            }
        }
        public int Id_samochodu
        {
            get
            {
                return id_samochodu;
            }
        }
        public int Id_klienta
        {
            get
            {
                return id_klienta;
            }
            set
            {
                id_klienta = value;
            }
        }
        public int Id_pracownika
        {
            get
            {
                return id_pracownika;
            }
            set
            {
                id_pracownika = value;
            }
        }
        public DateTime Data_wypozyczenia
        {
            get
            {
                return data_wypozyczenia;
            }
            set
            {
                data_wypozyczenia = value;
            }
        }
    }
}
