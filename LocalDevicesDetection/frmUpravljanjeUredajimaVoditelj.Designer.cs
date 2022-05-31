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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpravljanjeUredajimaVoditelj));
            this.dgvDopusteniUredaji = new System.Windows.Forms.DataGridView();
            this.dopusteniuredajiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kmedimore20_DBDataSet = new LocalDevicesDetection.kmedimore20_DBDataSet();
            this.dopusteni_uredajiTableAdapter = new LocalDevicesDetection.kmedimore20_DBDataSetTableAdapters.Dopusteni_uredajiTableAdapter();
            this.btnDodajNoviUredaj = new System.Windows.Forms.Button();
            this.btnBrisanje = new System.Windows.Forms.Button();
            this.btnIzbornik = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAzuriraj = new System.Windows.Forms.Button();
            this.txtPretrazivanje = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.iDuredajaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimevlasnikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imevlasnikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ulogaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDopusteniUredaji)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dopusteniuredajiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kmedimore20_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.dgvDopusteniUredaji.Location = new System.Drawing.Point(32, 112);
            this.dgvDopusteniUredaji.Name = "dgvDopusteniUredaji";
            this.dgvDopusteniUredaji.ReadOnly = true;
            this.dgvDopusteniUredaji.Size = new System.Drawing.Size(472, 206);
            this.dgvDopusteniUredaji.TabIndex = 0;
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
            this.btnDodajNoviUredaj.Location = new System.Drawing.Point(64, 336);
            this.btnDodajNoviUredaj.Name = "btnDodajNoviUredaj";
            this.btnDodajNoviUredaj.Size = new System.Drawing.Size(102, 29);
            this.btnDodajNoviUredaj.TabIndex = 1;
            this.btnDodajNoviUredaj.Text = "Dodaj novi uređaj";
            this.btnDodajNoviUredaj.UseVisualStyleBackColor = true;
            this.btnDodajNoviUredaj.Click += new System.EventHandler(this.btnDodajNoviUredaj_Click);
            // 
            // btnBrisanje
            // 
            this.btnBrisanje.Location = new System.Drawing.Point(220, 336);
            this.btnBrisanje.Name = "btnBrisanje";
            this.btnBrisanje.Size = new System.Drawing.Size(102, 29);
            this.btnBrisanje.TabIndex = 3;
            this.btnBrisanje.Text = "Obriši uređaj";
            this.btnBrisanje.UseVisualStyleBackColor = true;
            this.btnBrisanje.Click += new System.EventHandler(this.btnBrisanje_Click);
            // 
            // btnIzbornik
            // 
            this.btnIzbornik.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnIzbornik.Image = ((System.Drawing.Image)(resources.GetObject("btnIzbornik.Image")));
            this.btnIzbornik.Location = new System.Drawing.Point(21, 18);
            this.btnIzbornik.Name = "btnIzbornik";
            this.btnIzbornik.Size = new System.Drawing.Size(37, 34);
            this.btnIzbornik.TabIndex = 9;
            this.btnIzbornik.UseVisualStyleBackColor = false;
            this.btnIzbornik.Click += new System.EventHandler(this.btnIzbornik_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(124, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Upravljanje poznatim uređajima";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Highlight;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(526, 49);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.Location = new System.Drawing.Point(369, 338);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(102, 29);
            this.btnAzuriraj.TabIndex = 10;
            this.btnAzuriraj.Text = "Ažuriraj podatke";
            this.btnAzuriraj.UseVisualStyleBackColor = true;
            this.btnAzuriraj.Click += new System.EventHandler(this.btnAzuriraj_Click);
            // 
            // txtPretrazivanje
            // 
            this.txtPretrazivanje.Location = new System.Drawing.Point(363, 77);
            this.txtPretrazivanje.Name = "txtPretrazivanje";
            this.txtPretrazivanje.Size = new System.Drawing.Size(141, 20);
            this.txtPretrazivanje.TabIndex = 12;
            this.txtPretrazivanje.TextChanged += new System.EventHandler(this.txtPretrazivanje_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Pretraživanje po prezimenu:";
            // 
            // iDuredajaDataGridViewTextBoxColumn
            // 
            this.iDuredajaDataGridViewTextBoxColumn.DataPropertyName = "ID_uredaja";
            this.iDuredajaDataGridViewTextBoxColumn.HeaderText = "ID uređaja";
            this.iDuredajaDataGridViewTextBoxColumn.Name = "iDuredajaDataGridViewTextBoxColumn";
            this.iDuredajaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prezimevlasnikaDataGridViewTextBoxColumn
            // 
            this.prezimevlasnikaDataGridViewTextBoxColumn.DataPropertyName = "Prezime_vlasnika";
            this.prezimevlasnikaDataGridViewTextBoxColumn.HeaderText = "Prezime vlasnika";
            this.prezimevlasnikaDataGridViewTextBoxColumn.Name = "prezimevlasnikaDataGridViewTextBoxColumn";
            this.prezimevlasnikaDataGridViewTextBoxColumn.ReadOnly = true;
            this.prezimevlasnikaDataGridViewTextBoxColumn.Width = 120;
            // 
            // imevlasnikaDataGridViewTextBoxColumn
            // 
            this.imevlasnikaDataGridViewTextBoxColumn.DataPropertyName = "Ime_vlasnika";
            this.imevlasnikaDataGridViewTextBoxColumn.HeaderText = "Ime vlasnika";
            this.imevlasnikaDataGridViewTextBoxColumn.Name = "imevlasnikaDataGridViewTextBoxColumn";
            this.imevlasnikaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ulogaDataGridViewTextBoxColumn
            // 
            this.ulogaDataGridViewTextBoxColumn.DataPropertyName = "Uloga";
            this.ulogaDataGridViewTextBoxColumn.HeaderText = "Radno mjesto";
            this.ulogaDataGridViewTextBoxColumn.Name = "ulogaDataGridViewTextBoxColumn";
            this.ulogaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmUpravljanjeUredajimaVoditelj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 379);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPretrazivanje);
            this.Controls.Add(this.btnAzuriraj);
            this.Controls.Add(this.btnIzbornik);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnBrisanje);
            this.Controls.Add(this.btnDodajNoviUredaj);
            this.Controls.Add(this.dgvDopusteniUredaji);
            this.Name = "frmUpravljanjeUredajimaVoditelj";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Upravljanje uređajima";
            this.Load += new System.EventHandler(this.frmUpravljanjeUredajima_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDopusteniUredaji)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dopusteniuredajiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kmedimore20_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDopusteniUredaji;
        private kmedimore20_DBDataSet kmedimore20_DBDataSet;
        private System.Windows.Forms.BindingSource dopusteniuredajiBindingSource;
        private kmedimore20_DBDataSetTableAdapters.Dopusteni_uredajiTableAdapter dopusteni_uredajiTableAdapter;
        private System.Windows.Forms.Button btnDodajNoviUredaj;
        private System.Windows.Forms.Button btnBrisanje;
        private System.Windows.Forms.Button btnIzbornik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAzuriraj;
        private System.Windows.Forms.TextBox txtPretrazivanje;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDuredajaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimevlasnikaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imevlasnikaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ulogaDataGridViewTextBoxColumn;
    }
}