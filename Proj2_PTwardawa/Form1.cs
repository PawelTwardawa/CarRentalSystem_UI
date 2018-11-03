using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proj2_PTwardawa
{
    public partial class Form1 : Form
    {
        Wypozyczalnia wypozyczalnia;
        public Form1(Wypozyczalnia obiekt)
        {
            wypozyczalnia = obiekt;
            InitializeComponent();           

            
            wypozyczalnia.odswiezGridView(this);

        }

        private void dodaj_klienta_button_Click(object sender, EventArgs e)
        {
            DodajKlienta dodajKlienta = new DodajKlienta(wypozyczalnia, Klient.unikalne_id, this);
            dodajKlienta.ShowDialog();

        }

        private void dodaj_pracownika_button_Click(object sender, EventArgs e)
        {
            DodajPracownika dodajPracownika = new DodajPracownika(wypozyczalnia, Pracownik.unikalne_id,this);
            dodajPracownika.ShowDialog();
        }


        private void dodaj_samochod_button_Click(object sender, EventArgs e)
        {
            DodajSamochod dodajSamochod = new DodajSamochod(wypozyczalnia, Samochody.unikalne_id,this);
            dodajSamochod.ShowDialog();
        }

        private void nowe_wypozyczenie_button_Click(object sender, EventArgs e)
        {
            NoweWypozyczenie noweWypozyczenie = new NoweWypozyczenie(wypozyczalnia,this);
            noweWypozyczenie.ShowDialog();
        }
        public void zamknij()
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LogowaniePracownika login = new LogowaniePracownika(wypozyczalnia, this);
            login.ShowDialog();
        }

        private void zwrot_samochodu_button_Click(object sender, EventArgs e)
        {
            ZwrotSamochodu zwrot = new ZwrotSamochodu(wypozyczalnia, this);
            zwrot.ShowDialog();
            
        }

        private void usun_klienta_button_Click(object sender, EventArgs e)
        {
            UsunKlienta usun = new UsunKlienta(wypozyczalnia, this);
            usun.ShowDialog();
        }

        private void usun_pracownika_button_Click(object sender, EventArgs e)
        {
            UsunPracownika usun = new UsunPracownika(wypozyczalnia, this);
            usun.ShowDialog();
        }

        private void usun_samochod_button_Click(object sender, EventArgs e)
        {
            UsunSamochod usun = new UsunSamochod(wypozyczalnia, this);
            usun.ShowDialog();
        }

        private void do_pliku_button_Click(object sender, EventArgs e)
        {
            wypozyczalnia.zapiszDoPliku();
        }

        private void zamknij_button_Click(object sender, EventArgs e)
        {
            zamknij();
        }

        public void odsiwezLabel2()
        {
            Pracownik pracownik = wypozyczalnia.zwrocPracownikaOId(wypozyczalnia.aktualnyPracownik);
            label2.Text =  pracownik.Imie + " " + pracownik.Nazwisko;
        }

        private void klienciGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            klienciGridView.Rows[e.RowIndex].Selected = true;
        }

        private void pracownicyGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pracownicyGridView.Rows[e.RowIndex].Selected = true;
        }

        private void samochodyDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           samochodyDataGridView.Rows[e.RowIndex].Selected = true;
        }
    }
}
