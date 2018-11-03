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
    public partial class NoweWypozyczenie : Form
    {
        Wypozyczalnia wypozyczalnia;
        Form1 form1;
        private int id_samochodu = -1;
        private int id_klienta = -1;
        public NoweWypozyczenie(Wypozyczalnia objekt, Form1 form)
        {
            wypozyczalnia = objekt;
            form1 = form;
            InitializeComponent();
            dataGridView1.DataSource = wypozyczalnia.klienciDataSource();
            //      dataGridView2.DataSource = wypozyczalnia.SamochodyDataSource();
            //nowy = wypozyczalnia.SamochodyDataSource();
            // var bindingList = new BindingList<Samochody>(wypozyczalnia.SamochodyDataSource());
            // BindingList<Samochody> binding = new BindingList<Samochody>(bindingList.Where(p => p.Marka.Contains("opel")).ToList());
            //  List<Samochody> nowa = new List<Samochody>(wypozyczalnia.SamochodyDataSource().Where(p => p.Marka.Contains("opel")).ToList());

            //  dataGridView2.DataSource = wypozyczalnia.ZwrocSamochodyList().Where(p => !p.Id_klienta.ToString().Contains("-1")).ToList();
            //return samochody.Select(samochody => new { samochody.Id_samochodu, samochody.Marka, samochody.Model, samochody.Rok_produkcji, samochody.Przebieg, samochody.Kolor, samochody.Id_klienta, samochody.Data_wypozyczenia, samochody.Id_pracownika }).ToList();
            dataGridView2.DataSource = (wypozyczalnia.ZwrocSamochodyList().Where(p => p.Id_klienta.ToString().Contains("-1")).ToList()).Select(samochody => new { samochody.Id_samochodu, samochody.Marka, samochody.Model, samochody.Rok_produkcji, samochody.Przebieg, samochody.Kolor, samochody.Id_klienta, samochody.Data_wypozyczenia, samochody.Id_pracownika }).ToList();

            //BindingList<Samochody> lista = new BindingList<Samochody>()


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                klient_label.Text = dataGridView1.Rows[e.RowIndex].Cells["Id_klienta"].Value.ToString() + "  " + dataGridView1.Rows[e.RowIndex].Cells["Imie"].Value.ToString() + "  " + dataGridView1.Rows[e.RowIndex].Cells["Nazwisko"].Value.ToString() + "  " + dataGridView1.Rows[e.RowIndex].Cells["Pesel"].Value.ToString();
                id_klienta = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["Id_klienta"].Value.ToString());
                dataGridView1.Rows[e.RowIndex].Selected = true;
                
                
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                samochod_label.Text = dataGridView2.Rows[e.RowIndex].Cells["Id_samochodu"].Value.ToString() + "  " + dataGridView2.Rows[e.RowIndex].Cells["Marka"].Value.ToString() + "  " + dataGridView2.Rows[e.RowIndex].Cells["Model"].Value.ToString() + "  " + dataGridView2.Rows[e.RowIndex].Cells["Rok_produkcji"].Value.ToString();
                id_samochodu = int.Parse(dataGridView2.Rows[e.RowIndex].Cells["Id_samochodu"].Value.ToString());
                dataGridView2.Rows[e.RowIndex].Selected = true;
            }
        }

        private void wypozycz_button_Click(object sender, EventArgs e)
        {
            if (klient_label.Text != "" && samochod_label.Text != "")
            {
                if (!wypozyczalnia.Wypozycz(id_klienta, id_samochodu))
                {
                    MessageBox.Show("Samochod zostal juz wypozyczony !");
                }
                else
                {
                    Close();
                    wypozyczalnia.odswiezGridView(form1);
                }
            }
            else
            {
                MessageBox.Show("musisz zaznaczyc klienta oraz samochod !");
            }
        }

        private void Anuluj_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
