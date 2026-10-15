using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DailyPlanner
{
    public partial class CheltuieliAct : Form
    {
        public string operatie = "";
        public int idCheltuiala = -1;

        private bool _loading = false;

        public CheltuieliAct()
        {
            InitializeComponent();
        }

        private void CheltuieliAct_Load(object sender, EventArgs e)
        {
            _loading = true;

            produseTableAdapter.Fill(dataSet1.Produse);
            cheltuieliTableAdapter.Fill(dataSet1.Cheltuieli);
            cheltuieliContinutTableAdapter.Fill(dataSet1.CheltuieliContinut);

            txtTotal.ReadOnly = true;

            var colPret = dataGridView1.Columns.Cast<DataGridViewColumn>()
                .FirstOrDefault(c => c.DataPropertyName == "Pret");
            if (colPret != null) colPret.ReadOnly = true;

            if (operatie == "CHELTUIALA NOUA" || idCheltuiala <= 0)
                initCheltuialaNoua();
            else
                initCheltuialaExistenta();

            _loading = false;

            calculeazaTotal();
        }

        private void initCheltuialaNoua()
        {
            var r = dataSet1.Cheltuieli.NewCheltuieliRow();
            r.Data = DateTime.Now;
            r.Total = 0m;

            dataSet1.Cheltuieli.AddCheltuieliRow(r);
            cheltuieliTableAdapter.Update(dataSet1.Cheltuieli);

            cheltuieliTableAdapter.Fill(dataSet1.Cheltuieli);

            idCheltuiala = Convert.ToInt32(dataSet1.Cheltuieli.Compute("MAX(IdCheltuiala)", ""));

            cheltuieliBindingSource.Position = cheltuieliBindingSource.Find("IdCheltuiala", idCheltuiala);
            cheltuieliContinutBindingSource.Filter = "IdCheltuiala=" + idCheltuiala;

            dateTimePicker1.Value = DateTime.Now;
            txtTotal.Text = "0.00";
        }

        private void initCheltuialaExistenta()
        {
            cheltuieliBindingSource.Position = cheltuieliBindingSource.Find("IdCheltuiala", idCheltuiala);
            cheltuieliContinutBindingSource.Filter = "IdCheltuiala=" + idCheltuiala;

            var r = dataSet1.Cheltuieli.Rows.Find(idCheltuiala);
            if (r == null)
            {
                operatie = "CHELTUIALA NOUA";
                idCheltuiala = -1;
                initCheltuialaNoua();
                return;
            }

            dateTimePicker1.Value = Convert.ToDateTime(r["Data"]);
            txtTotal.Text = Convert.ToDecimal(r["Total"]).ToString("0.00");
        }

        private int nextNrCrt()
        {
            int max = 0;

            foreach (DataRowView v in cheltuieliContinutBindingSource)
            {
                if (v.Row.RowState == DataRowState.Deleted) continue;
                if (v["NrCrt"] == DBNull.Value) continue;

                int nr = Convert.ToInt32(v["NrCrt"]);
                if (nr > max) max = nr;
            }

            return max + 1;
        }

        private void dataGridView1_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            var colIdCh = dataGridView1.Columns.Cast<DataGridViewColumn>().FirstOrDefault(c => c.DataPropertyName == "IdCheltuiala");
            var colNr = dataGridView1.Columns.Cast<DataGridViewColumn>().FirstOrDefault(c => c.DataPropertyName == "NrCrt");
            var colCant = dataGridView1.Columns.Cast<DataGridViewColumn>().FirstOrDefault(c => c.DataPropertyName == "Cantitate");
            var colPret = dataGridView1.Columns.Cast<DataGridViewColumn>().FirstOrDefault(c => c.DataPropertyName == "Pret");

            if (colIdCh != null) e.Row.Cells[colIdCh.Index].Value = idCheltuiala;
            if (colNr != null) e.Row.Cells[colNr.Index].Value = nextNrCrt();
            if (colCant != null) e.Row.Cells[colCant.Index].Value = 1;
            if (colPret != null) e.Row.Cells[colPret.Index].Value = 0m;
        }

        private void dataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridView1.IsCurrentCellDirty)
                dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (_loading) return;
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            var row = dataGridView1.Rows[e.RowIndex];
            if (row.IsNewRow) return;

            string prop = dataGridView1.Columns[e.ColumnIndex].DataPropertyName;

            if (prop == "IdProdus")
            {
                object idObj = row.Cells[e.ColumnIndex].Value;
                if (idObj == null || idObj == DBNull.Value) { calculeazaTotal(); return; }

                int idProdus = Convert.ToInt32(idObj);
                DataRow prod = dataSet1.Produse.Rows.Find(idProdus);

                var colPret = dataGridView1.Columns.Cast<DataGridViewColumn>().FirstOrDefault(c => c.DataPropertyName == "Pret");
                if (prod != null && colPret != null)
                    row.Cells[colPret.Index].Value = prod["Pret"];

                calculeazaTotal();
                return;
            }

            if (prop == "Cantitate")
            {
                calculeazaTotal();
                return;
            }
        }

        private void calculeazaTotal()
        {
            if (_loading) return;

            decimal total = 0m;

            foreach (DataRowView r in cheltuieliContinutBindingSource)
            {
                if (r.Row.RowState == DataRowState.Deleted) continue;
                if (r["Cantitate"] == DBNull.Value || r["Pret"] == DBNull.Value) continue;

                if (!decimal.TryParse(r["Cantitate"].ToString(), out decimal cant)) continue;
                if (!decimal.TryParse(r["Pret"].ToString(), out decimal pret)) continue;

                total += cant * pret;
            }

            txtTotal.Text = total.ToString("0.00");

            if (cheltuieliBindingSource.Current != null)
            {
                var ch = (DataRowView)cheltuieliBindingSource.Current;
                ch["Total"] = total;
                ch["Data"] = dateTimePicker1.Value;
            }
        }

        private bool completareCampuri()
        {
            foreach (DataRow r in dataSet1.CheltuieliContinut.Rows)
            {
                if (r.RowState == DataRowState.Deleted) continue;

                if (Convert.ToInt32(r["IdCheltuiala"]) != idCheltuiala) continue;

                if (r["NrCrt"] == DBNull.Value)
                    r["NrCrt"] = nextNrCrt();

                if (r["IdProdus"] == DBNull.Value)
                {
                    MessageBox.Show("Completati produsul!");
                    return false;
                }

                if (r["Cantitate"] == DBNull.Value || !decimal.TryParse(r["Cantitate"].ToString(), out decimal cant) || cant <= 0)
                {
                    MessageBox.Show("Cantitatea trebuie sa fie > 0!");
                    return false;
                }

                if (r["Pret"] == DBNull.Value)
                    r["Pret"] = 0m;
            }

            return true;
        }

        private void btnSalvare_Click(object sender, EventArgs e)
        {
            var rez = MessageBox.Show(
                "Salvati cheltuiala?",
                "Confirmare salvare",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (rez == DialogResult.No)
                return;

            if (!completareCampuri())
                return;

            try
            {
                dataGridView1.EndEdit();
                cheltuieliContinutBindingSource.EndEdit();
                cheltuieliBindingSource.EndEdit();

                calculeazaTotal();

                DataRowView chView = (DataRowView)cheltuieliBindingSource.Current;
                DataRow chRow = chView.Row;

                chRow["Data"] = dateTimePicker1.Value;
                chRow["Total"] = Convert.ToDecimal(txtTotal.Text);

                cheltuieliTableAdapter.Update(new DataRow[] { chRow });

                cheltuieliContinutTableAdapter.Update(dataSet1.CheltuieliContinut);

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnRenuntare_Click(object sender, EventArgs e)
        {
            var rez = MessageBox.Show(
                "Renuntati la modificarile facute?",
                "Renuntare",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (rez == DialogResult.No)
                return;

            try
            {
                try { dataGridView1.EndEdit(); } catch { }
                try { cheltuieliContinutBindingSource.EndEdit(); } catch { }
                try { cheltuieliBindingSource.EndEdit(); } catch { }

                if (operatie == "CHELTUIALA NOUA" && idCheltuiala > 0)
                {
                    var copii = dataSet1.CheltuieliContinut
                        .AsEnumerable()
                        .Where(r => r.RowState != DataRowState.Deleted &&
                                    r.Field<int>("IdCheltuiala") == idCheltuiala)
                        .ToList();

                    foreach (var r in copii)
                        r.Delete();

                    cheltuieliContinutTableAdapter.Update(dataSet1.CheltuieliContinut);

                    var ch = dataSet1.Cheltuieli.Rows.Find(idCheltuiala);
                    if (ch != null)
                        ch.Delete();

                    cheltuieliTableAdapter.Update(dataSet1.Cheltuieli);
                }
                else
                {
                    try { dataGridView1.CancelEdit(); } catch { }
                    try { cheltuieliContinutBindingSource.CancelEdit(); } catch { }
                    try { cheltuieliBindingSource.CancelEdit(); } catch { }
                }
            }
            catch { }

            DialogResult = DialogResult.Cancel;
            Close();
        }


        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            var rez = MessageBox.Show("Confirmati stergerea?", "Stergere produs",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (rez == DialogResult.No) e.Cancel = true;
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (btnRenuntare.Focused)
            {
                dataGridView1.CancelEdit();
                e.Cancel = true;
                return;
            }

            MessageBox.Show("Format eronat");
            e.Cancel = true;
        }
    }
}
