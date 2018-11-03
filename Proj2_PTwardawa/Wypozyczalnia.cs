using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows;
using System.ComponentModel;
using System.Windows.Forms;

namespace Proj2_PTwardawa
{
    public class Wypozyczalnia
    {
        //       List<Osoba> osoby = new List<Osoba>();
        //      List<Tuple<Klient, Pracownik>> osoby = new List<Tuple<Klient, Pracownik>>();
        //       public var osoby = new List<Osoba>();


        public int aktualnyPracownik;
        List<Klient> klienci = new List<Klient>();
        List<Pracownik> pracownicy = new List<Pracownik>();
        List<Samochody> samochody = new List<Samochody>();
        public Wypozyczalnia()
        {

        }
        ~Wypozyczalnia()
        {
            this.zapiszDoPliku();
        }
        public void CzytajZPliku()
        {
            FileStream plik;
            StreamReader str;
            string[] data;
            string[] data2;
            try
            {
                plik = new FileStream("klienci.txt", FileMode.Open, FileAccess.Read);
                str = new StreamReader(plik);

                string wiersz;
                string[] dane = null;

                while ((wiersz = str.ReadLine()) != null)
                {

                    dane = wiersz.Split(' ');
                    if (dane[0] != "")
                    {
                        DodajKlienta(int.Parse(dane[0]), dane[1], dane[2], dane[3], dane[4], dane[5], dane[6], dane[7]);
                        if (int.Parse(dane[0]) > Klient.unikalne_id - 1)
                        {
                            Klient.unikalne_id = int.Parse(dane[0]) + 1;
                        }
                    }
                }
                plik.Close();

                plik = new FileStream("pracownicy.txt", FileMode.Open, FileAccess.Read);
                str = new StreamReader(plik);

                while ((wiersz = str.ReadLine()) != null)
                {

                    dane = wiersz.Split(' ');
                    if (dane[0] != "")
                    {
                        data = dane[8].Split('.');
                        DodajPracownika(int.Parse(dane[0]), float.Parse(dane[9]), new DateTime(int.Parse(data[2]), int.Parse(data[1]), int.Parse(data[0])), dane[1], dane[2], dane[3], dane[4], dane[5], dane[6], dane[7]);
                        if (int.Parse(dane[0]) > Pracownik.unikalne_id - 1)
                        {
                            Pracownik.unikalne_id = int.Parse(dane[0]) + 1;
                        }
                    }
                }
                plik.Close();

                plik = new FileStream("samochody.txt", FileMode.Open, FileAccess.Read);
                str = new StreamReader(plik);

                while ((wiersz = str.ReadLine()) != null)
                {

                    dane = wiersz.Split(' ');
                    if (dane[0] != "")
                    {
                        data = dane[8].Split('.');
                        data2 = dane[9].Split(':');
                        DodajSamochod(int.Parse(dane[0]), int.Parse(dane[1]), int.Parse(dane[2]), dane[3], dane[4], int.Parse(dane[5]), int.Parse(dane[6]), dane[7], new DateTime(int.Parse(data[2]), int.Parse(data[1]), int.Parse(data[0]), int.Parse(data2[0]), int.Parse(data2[1]), int.Parse(data2[2])));

                        if (int.Parse(dane[0]) > Samochody.unikalne_id - 1)
                        {
                            Samochody.unikalne_id = int.Parse(dane[0]) + 1;
                        }
                    }
                }
                plik.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                System.Environment.Exit(1);
                
            }

        }

        public void DodajKlienta(string imie, string nazwisko, string pesel, string miejscowosc, string ulica, string nr_domu, string kod_pocztowy)
        {
            klienci.Add(new Klient(imie, nazwisko, pesel, miejscowosc, ulica, nr_domu, kod_pocztowy));
        }
        public void DodajKlienta(int id, string imie, string nazwisko, string pesel, string miejscowosc, string ulica, string nr_domu, string kod_pocztowy)
        {
            klienci.Add(new Klient(id, imie, nazwisko, pesel, miejscowosc, ulica, nr_domu, kod_pocztowy));
        }
        public void DodajPracownika(float wynagrodzenie, DateTime data_zatrudnienia, string imie, string nazwisko, string pesel, string miejscowosc, string ulica, string nr_domu, string kod_pocztowy)
        {
            pracownicy.Add(new Pracownik(wynagrodzenie, data_zatrudnienia, imie, nazwisko, pesel, miejscowosc, ulica, nr_domu, kod_pocztowy));
        }
        public void DodajPracownika(int id, float wynagrodzenie, DateTime data_zatrudnienia, string imie, string nazwisko, string pesel, string miejscowosc, string ulica, string nr_domu, string kod_pocztowy)
        {
            pracownicy.Add(new Pracownik(id, wynagrodzenie, data_zatrudnienia, imie, nazwisko, pesel, miejscowosc, ulica, nr_domu, kod_pocztowy));
        }
        public void DodajSamochod(string marka, string model, int rok_produkcji, int przebieg, string kolor) // nie testowane
        {
            samochody.Add(new Samochody(marka, model, rok_produkcji, przebieg, kolor));
        }

        public void DodajSamochod(int id_samochodu, int id_klienta, int id_pracownika, string marka, string model, int rok_produkcji, int przebieg, string kolor, DateTime data_wypozyczenia) // nie testowane
        {
            samochody.Add(new Samochody(id_samochodu, id_klienta, id_pracownika, marka, model, rok_produkcji, przebieg, kolor, data_wypozyczenia));
        }

        public void odswiezGridView(Form1 obiekt )
        {
              obiekt.klienciGridView.DataSource = klienci.Select(klient => new {klient.Id_klienta, klient.Imie , klient.Nazwisko, klient.Pesel, klient.Adres.Miejscowosc, klient.Adres.Ulica, klient.Adres.Nr_domu, klient.Adres.Kod_pocztowy }).ToList();
          //  obiekt.klienciGridView.DataSource = klienciDataSource();
            obiekt.pracownicyGridView.DataSource = PracownicyDataSource();
            obiekt.samochodyDataGridView.DataSource = SamochodyDataSource();
        }
/*
        public void odswiezPracownicyGridView(Form1 obiekt)
        {
            obiekt.pracownicyGridView.DataSource = pracownicy.Select(pracownik => new { pracownik.Id_pracownika, pracownik.Imie, pracownik.Nazwisko, pracownik.Pesel, pracownik.Adres.Miejscowosc, pracownik.Adres.Ulica, pracownik.Adres.Nr_domu, pracownik.Adres.Kod_pocztowy, pracownik.Data_zatrudnienia, pracownik.Wynagrodzenie }).ToList();
        }
        public void odswiezSamochodyGridView(Form1 obiekt)
        {
            obiekt.samochodyDataGridView.DataSource = SamochodyDataSource();
        }
*/
        public object klienciDataSource()
        {
            return klienci.Select(klient => new { klient.Id_klienta, klient.Imie, klient.Nazwisko, klient.Pesel, klient.Adres.Miejscowosc, klient.Adres.Ulica, klient.Adres.Nr_domu, klient.Adres.Kod_pocztowy }).ToList();
        }

        public object PracownicyDataSource()
        {
            return pracownicy.Select(pracownik => new { pracownik.Id_pracownika, pracownik.Imie, pracownik.Nazwisko, pracownik.Pesel, pracownik.Adres.Miejscowosc, pracownik.Adres.Ulica, pracownik.Adres.Nr_domu, pracownik.Adres.Kod_pocztowy, pracownik.Data_zatrudnienia, pracownik.Wynagrodzenie }).ToList();
        }

        public object SamochodyDataSource()
        {
              return samochody.Select(samochody => new { samochody.Id_samochodu, samochody.Marka, samochody.Model, samochody.Rok_produkcji, samochody.Przebieg, samochody.Kolor, samochody.Id_klienta, samochody.Data_wypozyczenia, samochody.Id_pracownika }).ToList();
        }

        public List<Samochody> ZwrocSamochodyList()
        {
            return samochody;
        }

        public bool Wypozycz(int id_klienta, int id_samochodu)
        {
            DateTime aktualnaData = DateTime.Now;
            for(int i = 0; samochody.Count > i; i++ )
            {
                if(samochody[i].Id_samochodu == id_samochodu)
                {
                    if(samochody[i].Id_klienta == -1)
                    {
                        samochody[i].Id_klienta = id_klienta;
                        samochody[i].Id_pracownika = aktualnyPracownik;
                        samochody[i].Data_wypozyczenia = aktualnaData;
                        
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
            }
            return false; 
        }

        public  Klient zwrocKlientaOId(int id)
        {
            for(int i =0; i < klienci.Count; i++)
            {
                if(klienci[i].Id_klienta == id)
                {
                    return klienci[i];
                }
            }
            return null;
        }
        public Pracownik zwrocPracownikaOId(int id)
        {
            for (int i = 0; i < pracownicy.Count; i++)
            {
                if (pracownicy[i].Id_pracownika == id)
                {
                    return pracownicy[i];
                }
            }
            return null;
        }
        public Samochody zwrocSamochodOId(int id)
        {
            for (int i = 0; i < samochody.Count; i++)
            {
                if (samochody[i].Id_samochodu == id)
                {
                    return samochody[i];
                }
            }
            return null;
        }

        public bool zwrotSamochodu(int id)
        {
            for(int i = 0; i < samochody.Count; i++ )
            {
                if(samochody[i].Id_samochodu == id)
                {
                    samochody[i].Id_klienta = -1;
                    samochody[i].Id_pracownika = -1;
                    samochody[i].Data_wypozyczenia = new DateTime(1,1,1);
                    return true;
                }
            }
            return false;
        }

        public bool Usun(Klient klient)
        {
            for (int i = 0; i < klienci.Count; i++)
            {
                if (klienci[i].Id_klienta == klient.Id_klienta)
                {
                    klienci.Remove(klienci[i]);
                    return true;
                }
            }
            return false;
        }
        public bool Usun(Pracownik pracownik)
        {
            for (int i = 0; i < pracownicy.Count; i++)
            {
                if (pracownicy[i].Id_pracownika == pracownik.Id_pracownika)
                {
                    pracownicy.Remove(pracownicy[i]);
                    return true;
                }
            }
            return false;
        }

        public bool Usun(Samochody samochod)
        {
            for (int i = 0; i < samochody.Count; i++)
            {
                if (samochody[i].Id_samochodu == samochod.Id_samochodu)
                {
                    samochody.Remove(samochody[i]);
                    return true;
                }
            }
            return false;
        }
    
        public bool zapiszDoPliku()
        {
            FileStream plik;
            StreamWriter str;
            if (klienci.Count > 0 && samochody.Count > 0 && pracownicy.Count > 0)
            {
                plik = new FileStream("klienci.txt", FileMode.Create, FileAccess.Write);
                str = new StreamWriter(plik);
            
                for (int i = 0; i < klienci.Count; i++)
                {
                    str.WriteLine(klienci[i].Id_klienta + " " + klienci[i].Imie + " " + klienci[i].Nazwisko + " " + klienci[i].Pesel + " " + klienci[i].Adres.Miejscowosc + " " + klienci[i].Adres.Ulica + " " + klienci[i].Adres.Nr_domu + " " + klienci[i].Adres.Kod_pocztowy);
                }
                str.Close();
                plik.Close();

                plik = new FileStream("pracownicy.txt", FileMode.Create, FileAccess.Write);
                str = new StreamWriter(plik);

                for (int i = 0; i < pracownicy.Count; i++)
                {
                    str.WriteLine(pracownicy[i].Id_pracownika + " " + pracownicy[i].Imie + " " + pracownicy[i].Nazwisko + " " + pracownicy[i].Pesel + " " + pracownicy[i].Adres.Miejscowosc + " " + pracownicy[i].Adres.Ulica + " " + pracownicy[i].Adres.Nr_domu + " " + pracownicy[i].Adres.Kod_pocztowy + " " + pracownicy[i].Data_zatrudnienia.Day + "." + pracownicy[i].Data_zatrudnienia.Month + "." + pracownicy[i].Data_zatrudnienia.Year + " " + pracownicy[i].Wynagrodzenie);
                }
                str.Close();
                plik.Close();

                plik = new FileStream("samochody.txt", FileMode.Create, FileAccess.Write);
                str = new StreamWriter(plik);

                for (int i = 0; i < samochody.Count; i++)
                {
                    str.WriteLine(samochody[i].Id_samochodu + " " + samochody[i].Id_klienta + " " + samochody[i].Id_pracownika + " " + samochody[i].Marka + " " + samochody[i].Model + " " + samochody[i].Rok_produkcji + " " + samochody[i].Przebieg + " " + samochody[i].Kolor + " " + samochody[i].Data_wypozyczenia.Day + "." + samochody[i].Data_wypozyczenia.Month + "." + samochody[i].Data_wypozyczenia.Year + " " + samochody[i].Data_wypozyczenia.Hour + ":" + samochody[i].Data_wypozyczenia.Minute + ":" + samochody[i].Data_wypozyczenia.Second);

                }
                str.Close();
                plik.Close();

                return true;
            }
            return false;
        }
    }
}
