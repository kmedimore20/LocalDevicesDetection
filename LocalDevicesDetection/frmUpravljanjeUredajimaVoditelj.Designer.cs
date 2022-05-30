namespace LocalDevicesDetection
{
    partial class frmUpravljanjeUredajimaVoditelj
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
            this.dgvDopusteniUredaji = new System.Windows.Forms.DataGridView();
            this.iDuredajaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimevlasnikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imevlasnikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ulogaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dopusteniuredajiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kmedimore20_DBDataSet = new LocalDevicesDetection.kmedimore20_DBDataSet();
            this.dopusteni_uredajiTableAdapter = new LocalDevicesDetection.kmedimore20_DBDataSetTableAdapters.Dopusteni_uredajiTableAdapter();
            this.btnDodajNoviUredaj = new System.Windows.Forms.Button();
            this.btnPovratak = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDopusteniUredaji)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dopusteniuredajiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kmedimore20_DBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDopusteniUredaji
            // 
            this.dgvDopusteniUredaji.AutoGenerateColumns = false;
            this.dgvDopusteniUredaji.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDopusteniUredaji.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDuredajaDataGridViewTextBoxColumn,
            this.prezimevlasnikaDataGridViewTextBoxColumn,
            this.imevlasnikaDataGridViewTextBoxColumn,
            this.ulogaDataGridViewTextBoxColumn});
            this.dgvDopusteniUredaji.DataSource = this.dopusteniuredajiBindingSource;
            this.dgvDopusteniUredaji.Location = new System.Drawing.Point(76, 46);
            this.dgvDopusteniUredaji.Name = "dgvDopusteniUredaji";
            this.dgvDopusteniUredaji.Size = new System.Drawing.Size(448, 206);
            this.dgvDopusteniUredaji.TabIndex = 0;
            // 
            // iDuredajaDataGridViewTextBoxColumn
            // 
            this.iDuredajaDataGridViewTextBoxColumn.DataPropertyName = "ID_uredaja";
            this.iDuredajaDataGridViewTextBoxColumn.HeaderText = "ID_uredaja";
            this.iDuredajaDataGridViewTextBoxColumn.Name = "iDuredajaDataGridViewTextBoxColumn";
            // 
            // prezimevlasnikaDataGridViewTextBoxColumn
            // 
            this.prezimevlasnikaDataGridViewTextBoxColumn.DataPropertyName = "Prezime_vlasnika";
            this.prezimevlasnikaDataGridViewTextBoxColumn.HeaderText = "Prezime_vlasnika";
            this.prezimevlasnikaDataGridViewTextBoxColumn.Name = "prezimevlasnikaDataGridViewTextBoxColumn";
            // 
            // imevlasnikaDataGridViewTextBoxColumn
            // 
            this.imevlasnikaDataGridViewTextBoxColumn.DataPropertyName = "Ime_vlasnika";
            this.imevlasnikaDataGridViewTextBoxColumn.HeaderText = "Ime_vlasnika";
            this.imevlasnikaDataGridViewTextBoxColumn.Name = "imevlasnikaDataGridViewTextBoxColumn";
            // 
            // ulogaDataGridViewTextBoxColumn
            // 
            this.ulogaDataGridViewTextBoxColumn.DataPropertyName = "Uloga";
            this.ulogaDataGridViewTextBoxColumn.HeaderText = "Uloga";
            this.ulogaDataGridViewTextBoxColumn.Name = "ulogaDataGridViewTextBoxColumn";
            // 
            // dopusteniuredajiBindingSource
            // 
            this.dopusteniuredajiBindingSource.DataMember = "Dopusteni_uredaji";
            this.dopusteniuredajiBindingSource.DataSource = this.kmedimore20_DBDataSet;
            // 
            // kmedimore20_DBDataSet
            // 
            this.kmedimore20_DBDataSet.DataSetName = "kmedimore20_DBDataSet";
            this.kmedimore20_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dopusteni_uredajiTableAdapter
            // 
            this.dopusteni_uredajiTableAdapter.ClearBeforeFill = true;
            // 
            // btnDodajNoviUredaj
            // 
            this.btnDodajNoviUredaj.Location = new System.Drawing.Point(422, 288);
            this.btnDodajNoviUredaj.Name = "btnDodajNoviUredaj";
            this.btnDodajNoviUredaj.Size = new System.Drawing.Size(102, 29);
            this.btnDodajNoviUredaj.TabIndex = 1;
            this.btnDodajNoviUredaj.Text = "Dodaj novi uređaj";
            this.btnDodajNoviUredaj.UseVisualStyleBackColor = true;
            this.btnDodajNoviUredaj.Click += new System.EventHandler(this.btnDodajNoviUredaj_Click);
            // 
            // btnPovratak
            // 
            this.btnPovratak.Location = new System.Drawing.Point(76, 288);
            this.btnPovratak.Name = "btnPovratak";
            this.btnPovratak.Size = new System.Drawing.Size(112, 29);
            this.btnPovratak.TabIndex = 2;
            this.btnPovratak.Text = "Povratak na izbornik";
            this.btnPovratak.UseVisualStyleBackColor = true;
            this.btnPovratak.Click += new System.EventHandler(this.btnPovratak_Click);
            // 
            // frmUpravljanjeUredajimaVoditelj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 371);
            this.Controls.Add(this.btnPovratak);
            this.Controls.Add(this.btnDodajNoviUredaj);
            this.Controls.Add(this.dgvDopusteniUredaji);
            this.Name = "frmUpravljanjeUredajimaVoditelj";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUpravljanjeUredajima";
            this.Load += new System.EventHandler(this.frmUpravljanjeUredajima_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDopusteniUredaji)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dopusteniuredajiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kmedimore20_DBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDopusteniUredaji;
        private kmedimore20_DBDataSet kmedimore20_DBDataSet;
        private System.Windows.Forms.BindingSource dopusteniuredajiBindingSource;
        private kmedimore20_DBDataSetTableAdapters.Dopusteni_uredajiTableAdapter dopusteni_uredajiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDuredajaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimevlasnikaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imevlasnikaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ulogaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnDodajNoviUredaj;
        private System.Windows.Forms.Button btnPovratak;
    }
}