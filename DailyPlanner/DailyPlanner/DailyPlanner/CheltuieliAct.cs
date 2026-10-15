using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DailyPlanner
{
    public partial class CheltuieliAct : Form
    {
        public string operatie = "";   // "CHELTUIALA NOUA" / "MODIFICARE"
        public int idCheltuiala = -1;

        private BindingSource bsContinut;

        public CheltuieliAct()
        {
            InitializeComponent();
        }

        private void CheltuieliAct_Load(object sender, EventArgs e)
        {
            cheltuieliTableAdapter.Fill(dataSet1.Cheltuieli);
            produseTableAdapter.Fill(dataSet1.Produse);
            cheltuieliContinutTableAdapter.Fill(dataSet1.CheltuieliContinut);

            txtTotal.ReadOnly = true;

            bsContinut = dataGridView1.DataSource as BindingSource;

            dataGridView1.CurrentCellDirtyStateChanged += dataGridView1_CurrentCellDirtyStateChanged;
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            dataGridView1.DefaultValuesNeeded += dataGridView1_DefaultValuesNeeded;
            dataGridView1.DataError += dataGridView1_DataError;

            if (operatie == "MODIFICARE" && idCheltuiala > 0)
                IncarcaExistenta();
            else
                PregatireNoua();

            CalculeazaTotalSiAfiseaza();
        }

        private void PregatireNoua()
        {
            idCheltuiala = -1;
            dateTimePicker1.Value = DateTime.Now;
            txtTotal.Text = "0.00";

            if (bsContinut != null)
            {
                bsContinut.Filter = "IdCheltuiala = 0";
                bsContinut.Position = 0;
            }
        }

        private void IncarcaExistenta()
        {
            DataRow ch = dataSet1.Cheltuieli.Rows.Find(idCheltuiala);
            if (ch != null)
            {
                dateTimePicker1.Value = Convert.ToDateTime(ch["Data"]);
                txtTotal.Text = Convert.ToDecimal(ch["Total"]).ToString("0.00");
            }

            if (bsContinut != null)
            {
                bsContinut.Filter = "IdCheltuiala = " + idCheltuiala;
                bsContinut.Position = 0;
            }
        }

        private void dataGridView1_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            var colIdChelt = dataGridView1.Columns.Cast<DataGridViewColumn>()
                .First(c => c.DataPropertyName == "IdCheltuiala");

            var colCant = dataGridView1.Columns.Cast<DataGridViewColumn>()
                .First(c => c.DataPropertyName == "Cantitate");

            var colPret = dataGridView1.Columns.Cast<DataGridViewColumn>()
                .First(c => c.DataPropertyName == "Pret");

            e.Row.Cells[colIdChelt.Index].Value = (idCheltuiala > 0) ? idCheltuiala : 0;
            e.Row.Cells[colCant.Index].Value = 1;
            e.Row.Cells[colPret.Index].Value = 0m;
        }

        private void dataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridView1.IsCurrentCellDirty)
                dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (dataGridView1.Rows[e.RowIndex].IsNewRow) return;
            if (bsContinut == null) return;
            if (e.RowIndex >= bsContinut.Count) return;

            string prop = dataGridView1.Columns[e.ColumnIndex].DataPropertyName;

            if (prop == "IdProdus")
            {
                DataRowView det = (DataRowView)bsContinut[e.RowIndex];

                if (det["IdProdus"] != DBNull.Value)
                {
                    int idProdus = Convert.ToInt32(det["IdProdus"]);
                    DataRow prod = dataSet1.Produse.Rows.Find(idProdus);
                    if (prod != null)
                        det["Pret"] = prod["Pret"];
                }

                CalculeazaTotalSiAfiseaza();
                return;
            }

            if (prop == "Cantitate" || prop == "Pret")
                CalculeazaTotalSiAfiseaza();
        }

        private void CalculeazaTotalSiAfiseaza()
        {
            if (bsContinut == null)
            {
                txtTotal.Text = "0.00";
                return;
            }

            decimal total = 0m;

            foreach (DataRowView r in bsContinut)
            {
                if (r.Row.RowState == DataRowState.Deleted) continue;

                if (r["Cantitate"] == DBNull.Value || r["Pret"] == DBNull.Value) continue;

                if (!decimal.TryParse(r["Cantitate"].ToString(), out decimal cant)) continue;
                if (!decimal.TryParse(r["Pret"].ToString(), out decimal pret)) continue;

                total += cant * pret;
            }

            txtTotal.Text = total.ToString("0.00");
        }

        private void GenereazaNrCrt()
        {
            if (bsContinut == null) return;

            int i = 1;
            foreach (DataRowView r in bsContinut)
            {
                if (r.Row.RowState == DataRowState.Deleted) continue;
                r["NrCrt"] = i++;
            }
        }

        private void btnSalvare_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.EndEdit();
                bsContinut?.EndEdit();

                StergeRanduriInvalide();

                GenereazaNrCrt();
                CalculeazaTotalSiAfiseaza();

                if (operatie == "CHELTUIALA NOUA" || idCheltuiala <= 0)
                {
                    DataRow chNou = dataSet1.Cheltuieli.NewRow();
                    chNou["Data"] = dateTimePicker1.Value;
                    chNou["Total"] = Convert.ToDecimal(txtTotal.Text);

                    dataSet1.Cheltuieli.Rows.Add(chNou);
                    cheltuieliTableAdapter.Update(dataSet1.Cheltuieli);

                    idCheltuiala = Convert.ToInt32(chNou["IdCheltuiala"]);

                    if (bsContinut != null)
                    {
                        foreach (DataRowView det in bsContinut)
                        {
                            if (det.Row.RowState == DataRowState.Deleted) continue;
                            det["IdCheltuiala"] = idCheltuiala;
                        }

                        cheltuieliContinutTableAdapter.Update(dataSet1.CheltuieliContinut);

                        bsContinut.Filter = "IdCheltuiala = " + idCheltuiala;
                        bsContinut.Position = 0;
                    }
                }
                else
                {
                    DataRow ch = dataSet1.Cheltuieli.Rows.Find(idCheltuiala);
                    if (ch != null)
                    {
                        ch["Data"] = dateTimePicker1.Value;
                        ch["Total"] = Convert.ToDecimal(txtTotal.Text);
                    }

                    cheltuieliContinutTableAdapter.Update(dataSet1.CheltuieliContinut);
                    cheltuieliTableAdapter.Update(dataSet1.Cheltuieli);
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la salvare:\n" + ex.Message);
            }
        }

        private void StergeRanduriInvalide()
        {
            if (bsContinut == null) return;

            for (int i = bsContinut.Count - 1; i >= 0; i--)
            {
                var r = (DataRowView)bsContinut[i];
                if (r.Row.RowState == DataRowState.Deleted) continue;

                bool idProdusGol = (r["IdProdus"] == DBNull.Value);
                if (idProdusGol)
                    r.Delete();
            }
        }

        private void btnRenuntare_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            string col = (e.ColumnIndex >= 0) ? dataGridView1.Columns[e.ColumnIndex].HeaderText : "coloana";
            MessageBox.Show("Format eronat la: " + col);
            e.ThrowException = false;
            e.Cancel = true;
        }

        private void dataGridView1_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {

        }
    }
}
