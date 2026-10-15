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
    public partial class CheltuieliForm : Form
    {
        public CheltuieliForm()
        {
            InitializeComponent();
        }

        private void CheltuieliForm_Load(object sender, EventArgs e)
        {
            Incarca();
            AfiseazaContinutSelectie();
        }

        private void Incarca()
        {
            cheltuieliTableAdapter.Fill(dataSet1.Cheltuieli);
            cheltuieliContinutTableAdapter.Fill(dataSet1.CheltuieliContinut);
        }

        private int IdCheltuialaCurenta()
        {
            if (cheltuieliBindingSource.Current == null) return -1;
            return Convert.ToInt32(((DataRowView)cheltuieliBindingSource.Current)["IdCheltuiala"]);
        }

        private BindingSource BindingContinut()
        {
            return dataGridView2.DataSource as BindingSource;
        }

        private void AfiseazaContinutSelectie()
        {
            int id = IdCheltuialaCurenta();
            var bs = BindingContinut();
            if (bs == null) return;

            if (id < 0)
                bs.Filter = "1=0";
            else
                bs.Filter = "IdCheltuiala = " + id;
        }

        private void btnNoua_Click(object sender, EventArgs e)
        {
            using (var f = new CheltuieliAct())
            {
                f.operatie = "CHELTUIALA NOUA";
                if (f.ShowDialog() == DialogResult.OK)
                    Incarca();
            }
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            int id = IdCheltuialaCurenta();
            if (id < 0) return;

            using (var f = new CheltuieliAct())
            {
                f.operatie = "MODIFICARE";
                f.idCheltuiala = id;

                if (f.ShowDialog() == DialogResult.OK)
                {
                    Incarca();
                    AfiseazaContinutSelectie();
                }
            }
        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            int id = IdCheltuialaCurenta();
            if (id < 0) return;

            if (MessageBox.Show("Confirmati stergerea cheltuielii?", "Stergere",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                return;

            StergeCheltuiala(id);

            Incarca();
            AfiseazaContinutSelectie();
        }

        private void StergeCheltuiala(int id)
        {
            for (int i = dataSet1.CheltuieliContinut.Rows.Count - 1; i >= 0; i--)
            {
                DataRow r = dataSet1.CheltuieliContinut.Rows[i];
                if (Convert.ToInt32(r["IdCheltuiala"]) == id)
                    r.Delete();
            }

            cheltuieliContinutTableAdapter.Update(dataSet1.CheltuieliContinut);

            DataRow ch = dataSet1.Cheltuieli.Rows.Find(id);
            if (ch != null) ch.Delete();

            cheltuieliTableAdapter.Update(dataSet1.Cheltuieli);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            AfiseazaContinutSelectie();
        }

        private void btnRevenire_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}