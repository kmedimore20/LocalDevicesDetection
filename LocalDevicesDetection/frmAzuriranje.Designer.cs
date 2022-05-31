namespace LocalDevicesDetection
{
    partial class frmAzuriranje
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
            this.txtIDstarog = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNovi = new System.Windows.Forms.Label();
            this.txtIDnovi = new System.Windows.Forms.TextBox();
            this.txtRadnoMjesto = new System.Windows.Forms.TextBox();
            this.txtImeNovo = new System.Windows.Forms.TextBox();
            this.txtPrezimeNovo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtIDstarog
            // 
            this.txtIDstarog.Location = new System.Drawing.Point(92, 45);
            this.txtIDstarog.Name = "txtIDstarog";
            this.txtIDstarog.Size = new System.Drawing.Size(150, 20);
            this.txtIDstarog.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID uređaja koji želite promjeniti:";
            // 
            // lblNovi
            // 
            this.lblNovi.AutoSize = true;
            this.lblNovi.Location = new System.Drawing.Point(89, 68);
            this.lblNovi.Name = "lblNovi";
            this.lblNovi.Size = new System.Drawing.Size(85, 13);
            this.lblNovi.TabIndex = 2;
            this.lblNovi.Text = "Novi ID uređaja:";
            // 
            // txtIDnovi
            // 
            this.txtIDnovi.Location = new System.Drawing.Point(92, 84);
            this.txtIDnovi.Name = "txtIDnovi";
            this.txtIDnovi.Size = new System.Drawing.Size(150, 20);
            this.txtIDnovi.TabIndex = 3;
            // 
            // txtRadnoMjesto
            // 
            this.txtRadnoMjesto.Location = new System.Drawing.Point(92, 201);
            this.txtRadnoMjesto.Name = "txtRadnoMjesto";
            this.txtRadnoMjesto.Size = new System.Drawing.Size(150, 20);
            this.txtRadnoMjesto.TabIndex = 4;
            // 
            // txtImeNovo
            // 
            this.txtImeNovo.Location = new System.Drawing.Point(92, 162);
            this.txtImeNovo.Name = "txtImeNovo";
            this.txtImeNovo.Size = new System.Drawing.Size(150, 20);
            this.txtImeNovo.TabIndex = 5;
            // 
            // txtPrezimeNovo
            // 
            this.txtPrezimeNovo.Location = new System.Drawing.Point(92, 123);
            this.txtPrezimeNovo.Name = "txtPrezimeNovo";
            this.txtPrezimeNovo.Size = new System.Drawing.Size(150, 20);
            this.txtPrezimeNovo.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Radno mjesto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Novi ime:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(89, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Novo prezime:";
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(66, 247);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(84, 39);
            this.btnOdustani.TabIndex = 11;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(178, 247);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(84, 39);
            this.btnSpremi.TabIndex = 12;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // frmAzuriranje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 325);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrezimeNovo);
            this.Controls.Add(this.txtImeNovo);
            this.Controls.Add(this.txtRadnoMjesto);
            this.Controls.Add(this.txtIDnovi);
            this.Controls.Add(this.lblNovi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIDstarog);
            this.Name = "frmAzuriranje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ažuriranje";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIDstarog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNovi;
        private System.Windows.Forms.TextBox txtIDnovi;
        private System.Windows.Forms.TextBox txtRadnoMjesto;
        private System.Windows.Forms.TextBox txtImeNovo;
        private System.Windows.Forms.TextBox txtPrezimeNovo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnSpremi;
    }
}