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
    public partial class DodajSamochod : Form
    {
        Wypozyczalnia wypozyczalnia;
        Form1 form1;
        public DodajSamochod(Wypozyczalnia obiekt, int id_samochodu, Form1 form)
        {
            wypozyczalnia = obiekt;
            form1 = form;
            InitializeComponent();
            id_samochodu_label.Text = id_samochodu.ToString();
        }

        private void dodaj_button_Click(object sender, EventArgs e)
        {
            if (marka_textBox.Text != "" && model_textBox.Text != "" && rok_produkcji_textBox.Text != "" && przebieg_textBox.Text != "" && kolor_textBox.Text != "")
            {
                wypozyczalnia.DodajSamochod(marka_textBox.Text, model_textBox.Text, int.Parse(rok_produkcji_textBox.Text), int.Parse(przebieg_textBox.Text), kolor_textBox.Text);
                wypozyczalnia.odswiezGridView(form1);
                Close();
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
    }
}
