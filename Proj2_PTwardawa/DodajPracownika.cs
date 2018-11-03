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
    public partial class DodajPracownika : Form
    {
        Wypozyczalnia wypozyczalnia;
        Form1 form1;
        public DodajPracownika(Wypozyczalnia obiekt, int id_pracownika, Form1 form)
        {
            wypozyczalnia = obiekt;
            form1 = form;
            InitializeComponent();
            id_klienta_label.Text = id_pracownika.ToString();
        }

        private void dodaj_button_Click(object sender, EventArgs e)
        {
            int dzien, miesiac, rok;
            if (wynagrodzenie_textBox.Text != "" && dzien_data_zatrudnienia_textBox6.Text != "" && imie_textBox.Text != "" && nazwisko_textBox.Text != "" && pesel_textBox.Text != "" && miejscowosc_textBox.Text != "" && ulica_textBox.Text != "" && nr_domu_textBox.Text != "" && kod_pocztowy_textBox.Text != "")
            {
                dzien = int.Parse(dzien_data_zatrudnienia_textBox6.Text);
                miesiac = int.Parse(miesiac_data_zatrudnienia_textBox6.Text);
                rok = int.Parse(rok_data_zatrudnienia_textBox6.Text);
                if (pesel_textBox.Text.Length == 11)
                {
                    if (dzien >= 1 && dzien <= 31 && miesiac >= 1 && miesiac <= 12 && rok >= 1900 && rok < 10000)
                    {
                        wypozyczalnia.DodajPracownika(float.Parse(wynagrodzenie_textBox.Text), new DateTime(int.Parse(rok_data_zatrudnienia_textBox6.Text), int.Parse(miesiac_data_zatrudnienia_textBox6.Text), int.Parse(dzien_data_zatrudnienia_textBox6.Text)), imie_textBox.Text, nazwisko_textBox.Text, pesel_textBox.Text, miejscowosc_textBox.Text, ulica_textBox.Text, nr_domu_textBox.Text, kod_pocztowy_textBox.Text);
                        wypozyczalnia.odswiezGridView(form1);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("wprowadziles niepoprawnie date ! poprawny format to (DD-MM-RRRR");
                    }
                }
                else
                {
                    MessageBox.Show("Niepoprawna dlugosc numeru PESEL !");
                }
            }
            else
            {
                MessageBox.Show("Uzupelnij wszystkie pola !");
            }
        }

        private void anuluj_button_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
