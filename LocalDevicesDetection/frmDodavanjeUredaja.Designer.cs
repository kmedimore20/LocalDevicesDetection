namespace LocalDevicesDetection
{
    partial class frmDodavanjeUredaja
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
            this.txtIDuredaja = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtUloga = new System.Windows.Forms.TextBox();
            this.lblIDuredaja = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblIme = new System.Windows.Forms.Label();
            this.lblUloga = new System.Windows.Forms.Label();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtIDuredaja
            // 
            this.txtIDuredaja.Location = new System.Drawing.Point(219, 72);
            this.txtIDuredaja.Name = "txtIDuredaja";
            this.txtIDuredaja.Size = new System.Drawing.Size(130, 20);
            this.txtIDuredaja.TabIndex = 0;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(219, 118);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(130, 20);
            this.txtPrezime.TabIndex = 1;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(219, 164);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(130, 20);
            this.txtIme.TabIndex = 2;
            // 
            // txtUloga
            // 
            this.txtUloga.Location = new System.Drawing.Point(219, 210);
            this.txtUloga.Name = "txtUloga";
            this.txtUloga.Size = new System.Drawing.Size(130, 20);
            this.txtUloga.TabIndex = 3;
            // 
            // lblIDuredaja
            // 
            this.lblIDuredaja.AutoSize = true;
            this.lblIDuredaja.Location = new System.Drawing.Point(216, 56);
            this.lblIDuredaja.Name = "lblIDuredaja";
            this.lblIDuredaja.Size = new System.Drawing.Size(60, 13);
            this.lblIDuredaja.TabIndex = 4;
            this.lblIDuredaja.Text = "ID uređaja:";
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Location = new System.Drawing.Point(216, 102);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(86, 13);
            this.lblPrezime.TabIndex = 5;
            this.lblPrezime.Text = "Prezime vlasnika";
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(216, 148);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(69, 13);
            this.lblIme.TabIndex = 6;
            this.lblIme.Text = "Ime vlasnika:";
            // 
            // lblUloga
            // 
            this.lblUloga.AutoSize = true;
            this.lblUloga.Location = new System.Drawing.Point(216, 194);
            this.lblUloga.Name = "lblUloga";
            this.lblUloga.Size = new System.Drawing.Size(75, 13);
            this.lblUloga.TabIndex = 7;
            this.lblUloga.Text = "Radno mjesto:";
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(196, 269);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(80, 38);
            this.btnOdustani.TabIndex = 8;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(305, 269);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(80, 38);
            this.btnSpremi.TabIndex = 9;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // frmDodavanjeUredaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 371);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.lblUloga);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.lblIDuredaja);
            this.Controls.Add(this.txtUloga);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIDuredaja);
            this.Name = "frmDodavanjeUredaja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDodavanjeUredaja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIDuredaja;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtUloga;
        private System.Windows.Forms.Label lblIDuredaja;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblUloga;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnSpremi;
    }
}