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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void categoriiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoriiForm f = new CategoriiForm();
            f.ShowDialog();
        }

        private void produseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProduseForm f = new ProduseForm();
            f.ShowDialog();
        }

        private void listaCheltuieliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheltuieliForm f = new CheltuieliForm();
            f.ShowDialog();
        }

        private void înregistrareCheltuialăNouăToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheltuieliAct f = new CheltuieliAct();
            f.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
