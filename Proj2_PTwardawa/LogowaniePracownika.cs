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
    public partial class LogowaniePracownika : Form
    {
        Wypozyczalnia wypozyczalnia;
        Form1 form1;
        int selectedId = -1;
        public LogowaniePracownika( Wypozyczalnia obiekt, Form1 form)
        {
            wypozyczalnia = obiekt;
            form1 = form;
            InitializeComponent();
             dataGridView1.DataSource = wypozyczalnia.PracownicyDataSource();


            dataGridView1.Columns["Data_zatrudnienia"].Visible = false;
            dataGridView1.Columns["wynagrodzenie"].Visible = false;
            dataGridView1.Columns["Nr_domu"].Visible = false;
            dataGridView1.Columns["Miejscowosc"].Visible = false;
            dataGridView1.Columns["Kod_pocztowy"].Visible = false;
            dataGridView1.Columns["Pesel"].Visible = false;
            dataGridView1.Columns["Ulica"].Visible = false;

            

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                label1.Text = dataGridView1.Rows[e.RowIndex].Cells["Imie"].Value.ToString() + " " + dataGridView1.Rows[e.RowIndex].Cells["Nazwisko"].Value.ToString();
                selectedId = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["Id_pracownika"].Value.ToString());
                dataGridView1.Rows[e.RowIndex].Selected = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
            form1.zamknij();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (selectedId != -1)
            {
                wypozyczalnia.aktualnyPracownik = selectedId;
                Close();
                form1.odsiwezLabel2();
 //               Form1 form = new Form1(wypozyczalnia);
  //              form.Show();
            }
            else
            {
                MessageBox.Show("Musisz zaznaczyc pracownika ! ");
            }
        }

        private void LogowaniePracownika_FormClosing(object sender, FormClosingEventArgs e)
        {
            form1.zamknij();
        }

    }
}
