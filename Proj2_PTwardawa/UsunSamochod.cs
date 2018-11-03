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
    public partial class UsunSamochod : Form
    {
        Wypozyczalnia wypozyczalnia;
        Form1 form1;
        Samochody samochody;
        int selectedId;
        public UsunSamochod(Wypozyczalnia obiekt, Form1 form)
        {
            wypozyczalnia = obiekt;
            form1 = form;
            InitializeComponent();
            dataGridView1.DataSource = wypozyczalnia.SamochodyDataSource();
        }

        private void anuluj_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void usun_button_Click(object sender, EventArgs e)
        {
            if (samochody != null)
            {
                if (samochody.Id_klienta == -1)
                {

                    //  wypozyczalnia.usunSamochod(selectedId);
                    wypozyczalnia.Usun(samochody);
                    wypozyczalnia.odswiezGridView(form1);
                    Close();
                }
                else
                {
                    MessageBox.Show("Nie mozesz usunac wypozyczonego samochodu !");
                }
            }
            else
            {
                MessageBox.Show("nie zaznaczyles samochodu na liscie !");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                samochody = wypozyczalnia.zwrocSamochodOId(int.Parse(dataGridView1.Rows[e.RowIndex].Cells["Id_samochodu"].Value.ToString()));
                selectedId = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["Id_samochodu"].Value.ToString());
                dataGridView1.Rows[e.RowIndex].Selected = true;
                label2.Text = samochody.Marka + " " + samochody.Model;
            }
        }
    }
}
