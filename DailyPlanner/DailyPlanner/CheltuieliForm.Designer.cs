namespace DailyPlanner
{
    partial class CheltuieliForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnRevenire = new System.Windows.Forms.Button();
            this.btnSterge = new System.Windows.Forms.Button();
            this.btnModifica = new System.Windows.Forms.Button();
            this.btnNoua = new System.Windows.Forms.Button();
            this.lblContinut = new System.Windows.Forms.Label();
            this.lblCheltuieli = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idCheltuialaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cheltuieliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new DailyPlanner.DataSet1();
            this.cheltuieliTableAdapter = new DailyPlanner.DataSet1TableAdapters.CheltuieliTableAdapter();
            this.cheltuieliBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cheltuieliContinutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cheltuieliContinutTableAdapter = new DailyPlanner.DataSet1TableAdapters.CheltuieliContinutTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.cheltuieliContinutBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idCheltuialaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrCrtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProdusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pretDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantitateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheltuieliBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheltuieliBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheltuieliContinutBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheltuieliContinutBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRevenire
            // 
            this.btnRevenire.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRevenire.ForeColor = System.Drawing.Color.HotPink;
            this.btnRevenire.Location = new System.Drawing.Point(442, 157);
            this.btnRevenire.Name = "btnRevenire";
            this.btnRevenire.Size = new System.Drawing.Size(154, 39);
            this.btnRevenire.TabIndex = 17;
            this.btnRevenire.Text = "Revenire";
            this.btnRevenire.UseVisualStyleBackColor = true;
            this.btnRevenire.Click += new System.EventHandler(this.btnRevenire_Click);
            // 
            // btnSterge
            // 
            this.btnSterge.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSterge.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.btnSterge.Location = new System.Drawing.Point(462, 472);
            this.btnSterge.Name = "btnSterge";
            this.btnSterge.Size = new System.Drawing.Size(134, 29);
            this.btnSterge.TabIndex = 16;
            this.btnSterge.Text = "Sterge Cheltuiala";
            this.btnSterge.UseVisualStyleBackColor = true;
            this.btnSterge.Click += new System.EventHandler(this.btnSterge_Click);
            // 
            // btnModifica
            // 
            this.btnModifica.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifica.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.btnModifica.Location = new System.Drawing.Point(248, 472);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(169, 29);
            this.btnModifica.TabIndex = 15;
            this.btnModifica.Text = "Modifica Cheltuiala";
            this.btnModifica.UseVisualStyleBackColor = true;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // btnNoua
            // 
            this.btnNoua.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNoua.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.btnNoua.Location = new System.Drawing.Point(56, 472);
            this.btnNoua.Name = "btnNoua";
            this.btnNoua.Size = new System.Drawing.Size(134, 29);
            this.btnNoua.TabIndex = 14;
            this.btnNoua.Text = "Cheltuiala Noua";
            this.btnNoua.UseVisualStyleBackColor = true;
            this.btnNoua.Click += new System.EventHandler(this.btnNoua_Click);
            // 
            // lblContinut
            // 
            this.lblContinut.AutoSize = true;
            this.lblContinut.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContinut.Location = new System.Drawing.Point(52, 238);
            this.lblContinut.Name = "lblContinut";
            this.lblContinut.Size = new System.Drawing.Size(232, 21);
            this.lblContinut.TabIndex = 12;
            this.lblContinut.Text = "Continut Cheltuiala Selectata";
            // 
            // lblCheltuieli
            // 
            this.lblCheltuieli.AutoSize = true;
            this.lblCheltuieli.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheltuieli.Location = new System.Drawing.Point(52, 7);
            this.lblCheltuieli.Name = "lblCheltuieli";
            this.lblCheltuieli.Size = new System.Drawing.Size(120, 21);
            this.lblCheltuieli.TabIndex = 10;
            this.lblCheltuieli.Text = "Lista Cheltuieli";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCheltuialaDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cheltuieliBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(56, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(344, 150);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // idCheltuialaDataGridViewTextBoxColumn
            // 
            this.idCheltuialaDataGridViewTextBoxColumn.DataPropertyName = "IdCheltuiala";
            this.idCheltuialaDataGridViewTextBoxColumn.HeaderText = "IdCheltuiala";
            this.idCheltuialaDataGridViewTextBoxColumn.Name = "idCheltuialaDataGridViewTextBoxColumn";
            this.idCheltuialaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cheltuieliBindingSource
            // 
            this.cheltuieliBindingSource.DataMember = "Cheltuieli";
            this.cheltuieliBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cheltuieliTableAdapter
            // 
            this.cheltuieliTableAdapter.ClearBeforeFill = true;
            // 
            // cheltuieliBindingSource1
            // 
            this.cheltuieliBindingSource1.DataMember = "Cheltuieli";
            this.cheltuieliBindingSource1.DataSource = this.dataSet1;
            // 
            // cheltuieliContinutBindingSource
            // 
            this.cheltuieliContinutBindingSource.DataMember = "CheltuieliContinut";
            this.cheltuieliContinutBindingSource.DataSource = this.dataSet1;
            // 
            // cheltuieliContinutTableAdapter
            // 
            this.cheltuieliContinutTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCheltuialaDataGridViewTextBoxColumn1,
            this.nrCrtDataGridViewTextBoxColumn,
            this.idProdusDataGridViewTextBoxColumn,
            this.pretDataGridViewTextBoxColumn,
            this.cantitateDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.cheltuieliContinutBindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(56, 301);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(540, 150);
            this.dataGridView2.TabIndex = 19;
            // 
            // cheltuieliContinutBindingSource1
            // 
            this.cheltuieliContinutBindingSource1.DataMember = "CheltuieliContinut";
            this.cheltuieliContinutBindingSource1.DataSource = this.dataSet1;
            // 
            // idCheltuialaDataGridViewTextBoxColumn1
            // 
            this.idCheltuialaDataGridViewTextBoxColumn1.DataPropertyName = "IdCheltuiala";
            this.idCheltuialaDataGridViewTextBoxColumn1.HeaderText = "IdCheltuiala";
            this.idCheltuialaDataGridViewTextBoxColumn1.Name = "idCheltuialaDataGridViewTextBoxColumn1";
            this.idCheltuialaDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nrCrtDataGridViewTextBoxColumn
            // 
            this.nrCrtDataGridViewTextBoxColumn.DataPropertyName = "NrCrt";
            this.nrCrtDataGridViewTextBoxColumn.HeaderText = "NrCrt";
            this.nrCrtDataGridViewTextBoxColumn.Name = "nrCrtDataGridViewTextBoxColumn";
            this.nrCrtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idProdusDataGridViewTextBoxColumn
            // 
            this.idProdusDataGridViewTextBoxColumn.DataPropertyName = "IdProdus";
            this.idProdusDataGridViewTextBoxColumn.HeaderText = "IdProdus";
            this.idProdusDataGridViewTextBoxColumn.Name = "idProdusDataGridViewTextBoxColumn";
            this.idProdusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pretDataGridViewTextBoxColumn
            // 
            this.pretDataGridViewTextBoxColumn.DataPropertyName = "Pret";
            this.pretDataGridViewTextBoxColumn.HeaderText = "Pret";
            this.pretDataGridViewTextBoxColumn.Name = "pretDataGridViewTextBoxColumn";
            this.pretDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cantitateDataGridViewTextBoxColumn
            // 
            this.cantitateDataGridViewTextBoxColumn.DataPropertyName = "Cantitate";
            this.cantitateDataGridViewTextBoxColumn.HeaderText = "Cantitate";
            this.cantitateDataGridViewTextBoxColumn.Name = "cantitateDataGridViewTextBoxColumn";
            this.cantitateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // CheltuieliForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(798, 549);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnRevenire);
            this.Controls.Add(this.btnSterge);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.btnNoua);
            this.Controls.Add(this.lblContinut);
            this.Controls.Add(this.lblCheltuieli);
            this.Name = "CheltuieliForm";
            this.Text = "CheltuieliForm";
            this.Load += new System.EventHandler(this.CheltuieliForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheltuieliBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheltuieliBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheltuieliContinutBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheltuieliContinutBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRevenire;
        private System.Windows.Forms.Button btnSterge;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Button btnNoua;
        private System.Windows.Forms.Label lblContinut;
        private System.Windows.Forms.Label lblCheltuieli;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource cheltuieliBindingSource;
        private DataSet1TableAdapters.CheltuieliTableAdapter cheltuieliTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCheltuialaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource cheltuieliBindingSource1;
        private System.Windows.Forms.BindingSource cheltuieliContinutBindingSource;
        private DataSet1TableAdapters.CheltuieliContinutTableAdapter cheltuieliContinutTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCheltuialaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrCrtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProdusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pretDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantitateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource cheltuieliContinutBindingSource1;
    }
}