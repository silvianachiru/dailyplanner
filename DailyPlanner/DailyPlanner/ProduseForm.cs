using DailyPlanner.DataSet1TableAdapters;
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
    public partial class ProduseForm : Form
    {
        const int IdProdusIndex = 0;
        const int DenumireProdusIndex = 1;
        const int UMIndex = 2;
        const int PretIndex = 3;
        const int SpImagineIndex = 4;
        const int IdCategorieIndex = 5;
        const int DCategorieIndex = 6;

        public ProduseForm()
        {
            InitializeComponent();
        }
        private void config(bool v)
        {
            dataGridView1.AllowUserToAddRows = !v;
            dataGridView1.AllowUserToDeleteRows = !v;

            dataGridView1.Columns[DenumireProdusIndex].ReadOnly = v;
            dataGridView1.Columns[UMIndex].ReadOnly = v;
            dataGridView1.Columns[PretIndex].ReadOnly = v;
            dataGridView1.Columns[SpImagineIndex].ReadOnly = v;
            dataGridView1.Columns[DCategorieIndex].ReadOnly = v;

            btnActualizare.Enabled = v;
            btnSalvare.Visible = !v;
            btnRenuntare.Visible = !v;
        }

        private void ProduseForm_Load(object sender, EventArgs e)
        {
            this.produseTableAdapter.Fill(this.dataSet1.Produse);
            this.categorieTableAdapter.Fill(this.dataSet1.Categorie);

            config(true);
            refresh();
        }

        private void refresh()
        {
            produseTableAdapter.Fill(dataSet1.Produse);
            categorieTableAdapter.Fill(dataSet1.Categorie);
            completeazaCategorie();
        }

        private void completeazaCategorie()
        {
            String idCateg;
            int idCategorie;
            DataRow r;

            foreach (DataRowView x in produseBindingSource)
            {
                idCateg = x["IdCategorie"].ToString();
                idCategorie = Convert.ToInt32(idCateg);

                r = dataSet1.Tables["Categorie"].Rows.Find(idCategorie);

                if (r != null)
                {
                    x["DCategorie"] = r["DenumireCategorie"].ToString();
                }
                else
                {
                    MessageBox.Show("Nu exista categorie cu id " + idCategorie);
                }
            }
        }
        private void btnActualizare_Click(object sender, EventArgs e)
        {
            config(false);
        }

        private void btnSalvare_Click(object sender, EventArgs e)
        {
            if (!completareCampuri()) return;

            try
            {
                produseTableAdapter.Update(dataSet1.Produse);
                config(true);
                refresh();
            }
            catch (Exception exc)
            {
                string s = exc.Message;
                if (s.Contains("duplicate values"))
                    MessageBox.Show("Inregistrare deja existenta !");
                else if (s.Contains("cannot be deleted"))
                    MessageBox.Show("Ati sters inregistrari referite in alte tabele !");
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

        private bool completareCampuri()
        {
            bool raspuns = true;
            foreach (DataRow r in dataSet1.Produse)
            {
                if (r.RowState == DataRowState.Deleted) continue;

                if (r["DenumireProdus"] == DBNull.Value)
                {
                    MessageBox.Show("Completati DenumireProdus la Id " + r["IdProdus"]);
                    raspuns = false;
                }

                if (r["Pret"] == DBNull.Value)
                {
                    MessageBox.Show("Completati Pret la Id " + r["IdProdus"]);
                    raspuns = false;
                }
            }
            return raspuns;
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            const string mesaj = "Confirmati stergerea";
            const string titlu = "Stergere produs";
            var rezultat = MessageBox.Show(mesaj, titlu, MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);
            if (rezultat == DialogResult.No) e.Cancel = true;
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (btnActualizare.Enabled) return;

            if (dataGridView1.CurrentCell.ColumnIndex == SpImagineIndex)
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string s = openFileDialog1.FileName;
                    dataGridView1.CurrentRow.Cells[SpImagineIndex].Value = s;
                    pictureBox1.ImageLocation = s;
                }
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

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataRowView crt;
            try
            {
                if (dataGridView1.CurrentCell?.ColumnIndex == DCategorieIndex)
                {
                    crt = (DataRowView)categorieBindingSource.Current;
                    dataGridView1.CurrentRow.Cells[IdCategorieIndex].Value = crt["IdCategorie"];
                }
            }
            catch { }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            afiseazaImagine();
        }

        private void afiseazaImagine()
        {
            if (dataGridView1.CurrentRow == null) return;

            try
            {
                string path = dataGridView1.CurrentRow.Cells[SpImagineIndex].Value?.ToString();

                if (!string.IsNullOrEmpty(path) && System.IO.File.Exists(path))
                {
                    pictureBox1.ImageLocation = path;
                }
                else
                {
                    pictureBox1.Image = null;
                }
            }
            catch
            {
                pictureBox1.Image = null;
            }
        }

    }
}
