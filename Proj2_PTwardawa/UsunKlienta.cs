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
    public partial class UsunKlienta : Form
    {
        Wypozyczalnia wypozyczalnia;
        Form1 form1;
        Klient klient;
        int selectedId;

        public UsunKlienta(Wypozyczalnia obiekt, Form1 form)
        {
            wypozyczalnia = obiekt;
            form1 = form;
            InitializeComponent();
            dataGridView1.DataSource = wypozyczalnia.klienciDataSource();
        }

        private void anuluj_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void usun_button_Click(object sender, EventArgs e)
        {
            if (klient != null)
            {
                //    wypozyczalnia.usunKlienta(selectedId);
                wypozyczalnia.Usun(klient);
                wypozyczalnia.odswiezGridView(form1);
                Close();
            }
            else
            {
                MessageBox.Show("nie zaznaczyles klienta na liscie !");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                klient = wypozyczalnia.zwrocKlientaOId(int.Parse(dataGridView1.Rows[e.RowIndex].Cells["Id_klienta"].Value.ToString()));
                selectedId = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["Id_klienta"].Value.ToString());
                dataGridView1.Rows[e.RowIndex].Selected = true;
                label2.Text = klient.Imie + " " + klient.Nazwisko;
            }
        }
    }
}
