namespace LocalDevicesDetection
{
    partial class frmIzbornik
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
            this.btnOdabirObjekta = new System.Windows.Forms.Button();
            this.btnDodajNoviObjekt = new System.Windows.Forms.Button();
            this.btnPovijestDogadaja = new System.Windows.Forms.Button();
            this.btnUpravljanjeUredajima = new System.Windows.Forms.Button();
            this.btnPozadina = new System.Windows.Forms.Button();
            this.btnNaslov = new System.Windows.Forms.Button();
            this.btnOdjava = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOdabirObjekta
            // 
            this.btnOdabirObjekta.Location = new System.Drawing.Point(242, 87);
            this.btnOdabirObjekta.Name = "btnOdabirObjekta";
            this.btnOdabirObjekta.Size = new System.Drawing.Size(139, 39);
            this.btnOdabirObjekta.TabIndex = 0;
            this.btnOdabirObjekta.Text = "Odabir objekta";
            this.btnOdabirObjekta.UseVisualStyleBackColor = true;
            this.btnOdabirObjekta.Click += new System.EventHandler(this.btnOdabirObjekta_Click);
            // 
            // btnDodajNoviObjekt
            // 
            this.btnDodajNoviObjekt.Location = new System.Drawing.Point(242, 132);
            this.btnDodajNoviObjekt.Name = "btnDodajNoviObjekt";
            this.btnDodajNoviObjekt.Size = new System.Drawing.Size(139, 39);
            this.btnDodajNoviObjekt.TabIndex = 1;
            this.btnDodajNoviObjekt.Text = "Dodaj novi objekt";
            this.btnDodajNoviObjekt.UseVisualStyleBackColor = true;
            // 
            // btnPovijestDogadaja
            // 
            this.btnPovijestDogadaja.Location = new System.Drawing.Point(242, 177);
            this.btnPovijestDogadaja.Name = "btnPovijestDogadaja";
            this.btnPovijestDogadaja.Size = new System.Drawing.Size(139, 39);
            this.btnPovijestDogadaja.TabIndex = 2;
            this.btnPovijestDogadaja.Text = "Povijest događaja";
            this.btnPovijestDogadaja.UseVisualStyleBackColor = true;
            // 
            // btnUpravljanjeUredajima
            // 
            this.btnUpravljanjeUredajima.Location = new System.Drawing.Point(242, 222);
            this.btnUpravljanjeUredajima.Name = "btnUpravljanjeUredajima";
            this.btnUpravljanjeUredajima.Size = new System.Drawing.Size(139, 39);
            this.btnUpravljanjeUredajima.TabIndex = 3;
            this.btnUpravljanjeUredajima.Text = "Upravljanje uređajima";
            this.btnUpravljanjeUredajima.UseVisualStyleBackColor = true;
            this.btnUpravljanjeUredajima.Click += new System.EventHandler(this.btnUpravljanjeUredajima_Click);
            // 
            // btnPozadina
            // 
            this.btnPozadina.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPozadina.Location = new System.Drawing.Point(230, 78);
            this.btnPozadina.Name = "btnPozadina";
            this.btnPozadina.Size = new System.Drawing.Size(163, 238);
            this.btnPozadina.TabIndex = 4;
            this.btnPozadina.UseVisualStyleBackColor = true;
            // 
            // btnNaslov
            // 
            this.btnNaslov.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnNaslov.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNaslov.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNaslov.Location = new System.Drawing.Point(230, 37);
            this.btnNaslov.Name = "btnNaslov";
            this.btnNaslov.Size = new System.Drawing.Size(163, 44);
            this.btnNaslov.TabIndex = 5;
            this.btnNaslov.Text = "Spojeni ste kao voditelj";
            this.btnNaslov.UseVisualStyleBackColor = false;
            // 
            // btnOdjava
            // 
            this.btnOdjava.Location = new System.Drawing.Point(242, 267);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(139, 39);
            this.btnOdjava.TabIndex = 6;
            this.btnOdjava.Text = "Odjava";
            this.btnOdjava.UseVisualStyleBackColor = true;
            this.btnOdjava.Click += new System.EventHandler(this.btnOdjava_Click);
            // 
            // frmIzbornik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 371);
            this.Controls.Add(this.btnOdjava);
            this.Controls.Add(this.btnNaslov);
            this.Controls.Add(this.btnUpravljanjeUredajima);
            this.Controls.Add(this.btnPovijestDogadaja);
            this.Controls.Add(this.btnDodajNoviObjekt);
            this.Controls.Add(this.btnOdabirObjekta);
            this.Controls.Add(this.btnPozadina);
            this.Name = "frmIzbornik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmIzbornik";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOdabirObjekta;
        private System.Windows.Forms.Button btnDodajNoviObjekt;
        private System.Windows.Forms.Button btnPovijestDogadaja;
        private System.Windows.Forms.Button btnUpravljanjeUredajima;
        private System.Windows.Forms.Button btnPozadina;
        private System.Windows.Forms.Button btnNaslov;
        private System.Windows.Forms.Button btnOdjava;
    }
}