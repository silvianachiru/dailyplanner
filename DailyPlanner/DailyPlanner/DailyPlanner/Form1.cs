using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DailyPlanner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtParola.PasswordChar = '*';
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "" || txtParola.Text == "")
            {
                MessageBox.Show("Completati user si parola!");
                return;
            }

            var dt = utilizatoriTableAdapter.GetData();

            var rows = dt.Where(r =>
                r.Nume.Equals(txtUser.Text, StringComparison.OrdinalIgnoreCase)
                && r.Parola == txtParola.Text
            );

            if (rows.Any())
            {
                this.Hide();
                MainForm f = new MainForm();
                f.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("User sau parola gresita!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Utilizatori' table. You can move, or remove it, as needed.
            this.utilizatoriTableAdapter.Fill(this.dataSet1.Utilizatori);

        }
    }
}
