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
    public partial class ZwrotSamochodu : Form
    {
        Wypozyczalnia wypozyczalnia;
        Form1 form1;
        Klient klient;
        Samochody samochod;
        int selectedId;

        public ZwrotSamochodu(Wypozyczalnia obiekt, Form1 form)
        {
            wypozyczalnia = obiekt;
            form1 = form;
            InitializeComponent();
            dataGridView1.DataSource = (new List<Samochody>(wypozyczalnia.ZwrocSamochodyList().Where(p => !p.Id_klienta.ToString().Contains("-1")).ToList())).Select(samochody => new { samochody.Id_samochodu, samochody.Marka, samochody.Model, samochody.Rok_produkcji, samochody.Przebieg, samochody.Kolor, samochody.Id_klienta, samochody.Data_wypozyczenia, samochody.Id_pracownika }).ToList(); 
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                
                klient = wypozyczalnia.zwrocKlientaOId(int.Parse(dataGridView1.Rows[e.RowIndex].Cells["Id_klienta"].Value.ToString()));
                samochod = wypozyczalnia.zwrocSamochodOId(int.Parse(dataGridView1.Rows[e.RowIndex].Cells["Id_samochodu"].Value.ToString()));
                selectedId = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["Id_samochodu"].Value.ToString());
                dataGridView1.Rows[e.RowIndex].Selected = true;
                szczegoly();
                if (klient != null)
                {
                    label2.Text = klient.Imie + " " + klient.Nazwisko;
                }
                else
                {
                    label2.Text = "nie wypozyczony";
                }
            }
        }

        private void anuluj_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void zwroc_button_Click(object sender, EventArgs e)
        {
            if (klient != null)
            {
                if (wypozyczalnia.zwrotSamochodu(selectedId))
                {
                    Close();
                    wypozyczalnia.odswiezGridView(form1);
                }
                else
                {
                    MessageBox.Show("nie udalo sie zwrocic samochodu !");
                }
            }
            else
            {
                MessageBox.Show("Zaznaczony samochod nie zostal wypozyczony !");
            }
        }

        private void ZwrotSamochodu_Load(object sender, EventArgs e)
        {
            this.Size = new Size(676, 450);
            this.MaximumSize = new Size(676, 450);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (klient != null)
            {
                if (button1.Text == "Pokaz szczegoly")
                {
                    szczegoly();


                    this.MaximumSize = new Size(676, 608);
                    this.MinimumSize = new Size(676, 608);
                    this.Size = new Size(676, 608);
                    button1.Text = "Ukryj szczegoly";
                }
                else
                {
                    this.MaximumSize = new Size(676, 450);
                    this.Size = new Size(676, 450);
                    button1.Text = "Pokaz szczegoly";
                }
            }
        
            else
            {
                MessageBox.Show("Zaznacz samochod");
            }

}

        void szczegoly()
        {
            DateTime data = DateTime.Now;

            int dataWypozMin = (data - samochod.Data_wypozyczenia).Minutes;
            
            int czaswypozyczenia = (int)(data - samochod.Data_wypozyczenia).TotalHours;
            label9.Text = klient.Id_klienta + " " + klient.Imie + " " + klient.Nazwisko + " " + klient.Pesel + " " + klient.Adres.Miejscowosc + " " + klient.Adres.Kod_pocztowy + " " + klient.Adres.Ulica + " " + klient.Adres.Nr_domu;
            label10.Text = samochod.Data_wypozyczenia.Date.ToString();
            label11.Text = DateTime.Now.ToString();
            label12.Text = czaswypozyczenia.ToString() + ":" + dataWypozMin.ToString(); ;
            label14.Text = ((czaswypozyczenia+1) * numericUpDown1.Value).ToString();


                
            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            szczegoly();
        }
    }
}
