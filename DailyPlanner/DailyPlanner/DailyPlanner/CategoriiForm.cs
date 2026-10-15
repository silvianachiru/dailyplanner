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
    public partial class CategoriiForm : Form
    {
        const int IdCategorieIndex = 0;
        const int DenumireCategorieIndex = 1;
        public CategoriiForm()
        {
            InitializeComponent();
        }

        private void CategoriiForm_Load(object sender, EventArgs e)
        {
            categorieTableAdapter.Fill(dataSet1.Categorie);
            config(true);
        }
        private void config(bool v)
        {
            dataGridView1.AllowUserToAddRows = !v;
            dataGridView1.AllowUserToDeleteRows = !v;

            dataGridView1.Columns[IdCategorieIndex].ReadOnly = true;
            dataGridView1.Columns[DenumireCategorieIndex].ReadOnly = v;

            btnActualizare.Enabled = v;
            btnSalvare.Visible = !v;
            btnRenuntare.Visible = !v;
        }
        private void refresh()
        {
            categorieTableAdapter.Fill(dataSet1.Categorie);
        }

        private void btnActualizare_Click(object sender, EventArgs e)
        {
            config(false);
        }

        private void btnSalvare_Click(object sender, EventArgs e)
        {
            if (!completareCampuri())
                return;

            try
            {
                categorieTableAdapter.Update(dataSet1.Categorie);
                config(true);
                refresh();
            }
            catch (Exception ex)
            {
                string s = ex.Message;

                if (s.Contains("duplicate values"))
                    MessageBox.Show("Aceasta categorie exista deja !");
                else if (s.Contains("cannot be deleted"))
                    MessageBox.Show("Nu puteti sterge categorii folosite in produse !");
                else
                    MessageBox.Show(s);
            }
        }

        private void btnRenuntare_Click(object sender, EventArgs e)
        {
            config(true);
            refresh();
        }

        private void btnRevenire_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            var rezultat = MessageBox.Show(
                "Confirmati stergerea?",
                "Stergere categorie",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (rezultat == DialogResult.No)
                e.Cancel = true;
        }

        private bool completareCampuri()
        {
            foreach (DataRow r in dataSet1.Categorie)
            {
                if (r.RowState == DataRowState.Deleted)
                    continue;

                if (r["DenumireCategorie"] == DBNull.Value)
                {
                    MessageBox.Show("Completati DenumireCategorie pentru Id " + r["IdCategorie"]);
                    return false;
                }
            }

            return true;
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

            if (btnRenuntare.Focused)
            {
                dataGridView1.CancelEdit();
                config(true);
                refresh();
                return;
            }

            MessageBox.Show("Format eronat");
        }
    }
}
