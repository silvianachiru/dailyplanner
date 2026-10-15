namespace DailyPlanner
{
    partial class CheltuieliAct
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
            this.btnRenuntare = new System.Windows.Forms.Button();
            this.btnSalvare = new System.Windows.Forms.Button();
            this.gbContinut = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idProdusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.produseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new DailyPlanner.DataSet1();
            this.cantitateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pretDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NrCrt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCheltuialaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cheltuieliContinutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblCheltuieli = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.gbCheltuiala = new System.Windows.Forms.GroupBox();
            this.cheltuieliContinutTableAdapter = new DailyPlanner.DataSet1TableAdapters.CheltuieliContinutTableAdapter();
            this.produseTableAdapter = new DailyPlanner.DataSet1TableAdapters.ProduseTableAdapter();
            this.cheltuieliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cheltuieliTableAdapter = new DailyPlanner.DataSet1TableAdapters.CheltuieliTableAdapter();
            this.tableAdapterManager = new DailyPlanner.DataSet1TableAdapters.TableAdapterManager();
            this.gbContinut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheltuieliContinutBindingSource)).BeginInit();
            this.gbCheltuiala.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cheltuieliBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRenuntare
            // 
            this.btnRenuntare.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRenuntare.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.btnRenuntare.Location = new System.Drawing.Point(633, 386);
            this.btnRenuntare.Name = "btnRenuntare";
            this.btnRenuntare.Size = new System.Drawing.Size(112, 39);
            this.btnRenuntare.TabIndex = 15;
            this.btnRenuntare.Text = "Renuntare";
            this.btnRenuntare.UseVisualStyleBackColor = true;
            this.btnRenuntare.Click += new System.EventHandler(this.btnRenuntare_Click);
            // 
            // btnSalvare
            // 
            this.btnSalvare.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvare.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.btnSalvare.Location = new System.Drawing.Point(494, 386);
            this.btnSalvare.Name = "btnSalvare";
            this.btnSalvare.Size = new System.Drawing.Size(109, 39);
            this.btnSalvare.TabIndex = 14;
            this.btnSalvare.Text = "Salvare";
            this.btnSalvare.UseVisualStyleBackColor = true;
            this.btnSalvare.Click += new System.EventHandler(this.btnSalvare_Click);
            // 
            // gbContinut
            // 
            this.gbContinut.BackColor = System.Drawing.Color.Pink;
            this.gbContinut.Controls.Add(this.dataGridView1);
            this.gbContinut.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbContinut.Location = new System.Drawing.Point(55, 255);
            this.gbContinut.Name = "gbContinut";
            this.gbContinut.Size = new System.Drawing.Size(394, 176);
            this.gbContinut.TabIndex = 13;
            this.gbContinut.TabStop = false;
            this.gbContinut.Text = "Continut";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProdusDataGridViewTextBoxColumn,
            this.cantitateDataGridViewTextBoxColumn,
            this.pretDataGridViewTextBoxColumn,
            this.NrCrt,
            this.idCheltuialaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cheltuieliContinutBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(16, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(344, 137);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridView1_CurrentCellDirtyStateChanged);
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            this.dataGridView1.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_DefaultValuesNeeded);
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // idProdusDataGridViewTextBoxColumn
            // 
            this.idProdusDataGridViewTextBoxColumn.DataPropertyName = "IdProdus";
            this.idProdusDataGridViewTextBoxColumn.DataSource = this.produseBindingSource;
            this.idProdusDataGridViewTextBoxColumn.DisplayMember = "DenumireProdus";
            this.idProdusDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.idProdusDataGridViewTextBoxColumn.HeaderText = "IdProdus";
            this.idProdusDataGridViewTextBoxColumn.Name = "idProdusDataGridViewTextBoxColumn";
            this.idProdusDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idProdusDataGridViewTextBoxColumn.ValueMember = "IdProdus";
            // 
            // produseBindingSource
            // 
            this.produseBindingSource.DataMember = "Produse";
            this.produseBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cantitateDataGridViewTextBoxColumn
            // 
            this.cantitateDataGridViewTextBoxColumn.DataPropertyName = "Cantitate";
            this.cantitateDataGridViewTextBoxColumn.HeaderText = "Cantitate";
            this.cantitateDataGridViewTextBoxColumn.Name = "cantitateDataGridViewTextBoxColumn";
            // 
            // pretDataGridViewTextBoxColumn
            // 
            this.pretDataGridViewTextBoxColumn.DataPropertyName = "Pret";
            this.pretDataGridViewTextBoxColumn.HeaderText = "Pret";
            this.pretDataGridViewTextBoxColumn.Name = "pretDataGridViewTextBoxColumn";
            this.pretDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // NrCrt
            // 
            this.NrCrt.DataPropertyName = "NrCrt";
            this.NrCrt.HeaderText = "NrCrt";
            this.NrCrt.Name = "NrCrt";
            this.NrCrt.ReadOnly = true;
            this.NrCrt.Visible = false;
            // 
            // idCheltuialaDataGridViewTextBoxColumn
            // 
            this.idCheltuialaDataGridViewTextBoxColumn.DataPropertyName = "IdCheltuiala";
            this.idCheltuialaDataGridViewTextBoxColumn.HeaderText = "IdCheltuiala";
            this.idCheltuialaDataGridViewTextBoxColumn.Name = "idCheltuialaDataGridViewTextBoxColumn";
            this.idCheltuialaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idCheltuialaDataGridViewTextBoxColumn.Visible = false;
            // 
            // cheltuieliContinutBindingSource
            // 
            this.cheltuieliContinutBindingSource.DataMember = "CheltuieliContinut";
            this.cheltuieliContinutBindingSource.DataSource = this.dataSet1;
            // 
            // lblCheltuieli
            // 
            this.lblCheltuieli.AutoSize = true;
            this.lblCheltuieli.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheltuieli.Location = new System.Drawing.Point(304, 20);
            this.lblCheltuieli.Name = "lblCheltuieli";
            this.lblCheltuieli.Size = new System.Drawing.Size(209, 25);
            this.lblCheltuieli.TabIndex = 12;
            this.lblCheltuieli.Text = "Cheltuieli Inregistrare";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.LightGray;
            this.txtTotal.Location = new System.Drawing.Point(73, 103);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 28);
            this.txtTotal.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(73, 30);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(287, 28);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(12, 106);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(48, 21);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "Total";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(12, 36);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(46, 21);
            this.lblData.TabIndex = 0;
            this.lblData.Text = "Data";
            // 
            // gbCheltuiala
            // 
            this.gbCheltuiala.BackColor = System.Drawing.Color.Pink;
            this.gbCheltuiala.Controls.Add(this.txtTotal);
            this.gbCheltuiala.Controls.Add(this.dateTimePicker1);
            this.gbCheltuiala.Controls.Add(this.lblTotal);
            this.gbCheltuiala.Controls.Add(this.lblData);
            this.gbCheltuiala.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCheltuiala.Location = new System.Drawing.Point(55, 63);
            this.gbCheltuiala.Name = "gbCheltuiala";
            this.gbCheltuiala.Size = new System.Drawing.Size(394, 167);
            this.gbCheltuiala.TabIndex = 11;
            this.gbCheltuiala.TabStop = false;
            this.gbCheltuiala.Text = "Cheltuiala";
            // 
            // cheltuieliContinutTableAdapter
            // 
            this.cheltuieliContinutTableAdapter.ClearBeforeFill = true;
            // 
            // produseTableAdapter
            // 
            this.produseTableAdapter.ClearBeforeFill = true;
            // 
            // cheltuieliBindingSource
            // 
            this.cheltuieliBindingSource.DataMember = "Cheltuieli";
            this.cheltuieliBindingSource.DataSource = this.dataSet1;
            // 
            // cheltuieliTableAdapter
            // 
            this.cheltuieliTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategorieTableAdapter = null;
            this.tableAdapterManager.CheltuieliContinutTableAdapter = this.cheltuieliContinutTableAdapter;
            this.tableAdapterManager.CheltuieliTableAdapter = this.cheltuieliTableAdapter;
            this.tableAdapterManager.ProduseTableAdapter = this.produseTableAdapter;
            this.tableAdapterManager.UpdateOrder = DailyPlanner.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UtilizatoriTableAdapter = null;
            // 
            // CheltuieliAct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(787, 462);
            this.Controls.Add(this.btnRenuntare);
            this.Controls.Add(this.btnSalvare);
            this.Controls.Add(this.gbContinut);
            this.Controls.Add(this.lblCheltuieli);
            this.Controls.Add(this.gbCheltuiala);
            this.Name = "CheltuieliAct";
            this.Text = "CheltuieliAct";
            this.Load += new System.EventHandler(this.CheltuieliAct_Load);
            this.gbContinut.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheltuieliContinutBindingSource)).EndInit();
            this.gbCheltuiala.ResumeLayout(false);
            this.gbCheltuiala.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cheltuieliBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRenuntare;
        private System.Windows.Forms.Button btnSalvare;
        private System.Windows.Forms.GroupBox gbContinut;
        private System.Windows.Forms.Label lblCheltuieli;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.GroupBox gbCheltuiala;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource cheltuieliContinutBindingSource;
        private DataSet1TableAdapters.CheltuieliContinutTableAdapter cheltuieliContinutTableAdapter;
        private System.Windows.Forms.BindingSource produseBindingSource;
        private DataSet1TableAdapters.ProduseTableAdapter produseTableAdapter;
        private System.Windows.Forms.BindingSource cheltuieliBindingSource;
        private DataSet1TableAdapters.CheltuieliTableAdapter cheltuieliTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewComboBoxColumn idProdusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantitateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pretDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NrCrt;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCheltuialaDataGridViewTextBoxColumn;
    }
}