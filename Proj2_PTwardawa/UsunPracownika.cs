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
    public partial class UsunPracownika : Form
    {
        Wypozyczalnia wypozyczalnia;
        Form1 form1;
        Pracownik pracownik;
        int selectedId;
        public UsunPracownika(Wypozyczalnia obiekt, Form1 form)
        {
            wypozyczalnia = obiekt;
            form1 = form;
            InitializeComponent();
            dataGridView1.DataSource = wypozyczalnia.PracownicyDataSource();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                pracownik = wypozyczalnia.zwrocPracownikaOId(int.Parse(dataGridView1.Rows[e.RowIndex].Cells["Id_pracownika"].Value.ToString()));
                selectedId = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["Id_pracownika"].Value.ToString());
                dataGridView1.Rows[e.RowIndex].Selected = true;
                label2.Text = pracownik.Imie + " " + pracownik.Nazwisko;
            }
        }

        private void usun_button_Click(object sender, EventArgs e)
        {
            if (pracownik != null)
            {
                //  wypozyczalnia.usunPracownika(selectedId);
                wypozyczalnia.Usun(pracownik);
                wypozyczalnia.odswiezGridView(form1);
                Close();
            }
            else
            {
                MessageBox.Show("nie zaznaczyles pracownika na liscie !");
            }
        }

        private void anuluj_button_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
