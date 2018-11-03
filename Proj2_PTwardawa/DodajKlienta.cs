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
    public partial class DodajKlienta : Form
    {
        Wypozyczalnia wypozyczalnia;
        Form1 form1;
        public DodajKlienta(Wypozyczalnia obiekt, int id_klienta, Form1 form)
        {
            wypozyczalnia = obiekt;
            form1 = form;
            InitializeComponent();
            id_klienta_label.Text = id_klienta.ToString();
        }

        private void dodaj_button_Click(object sender, EventArgs e)
        {
            if (imie_textBox.Text != "" && nazwisko_textBox.Text != "" && pesel_textBox.Text != "" && miejscowosc_textBox.Text != "" && ulica_textBox.Text != "" && nr_domu_textBox.Text != "" && kod_pocztowy_textBox.Text != "")
            {
                if (pesel_textBox.Text.Length == 11)
                {
                    wypozyczalnia.DodajKlienta(imie_textBox.Text, nazwisko_textBox.Text, pesel_textBox.Text, miejscowosc_textBox.Text, ulica_textBox.Text, nr_domu_textBox.Text, kod_pocztowy_textBox.Text);
                    wypozyczalnia.odswiezGridView(form1);
                    Close();
                }
                else
                {
                    MessageBox.Show("Niepoprawna dlugosc numeru PESEL !");
                }
            }else
            {
                MessageBox.Show("Uzupelnij wszystkie pola !");
            }
        }

        private void anuluj_button_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
