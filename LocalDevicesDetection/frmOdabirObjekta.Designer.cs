namespace LocalDevicesDetection
{
    partial class frmOdabirObjekta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOdabirObjekta));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnZatvorPrizemlje = new System.Windows.Forms.Button();
            this.btnZatvorPrvi = new System.Windows.Forms.Button();
            this.btnZatvorDrugi = new System.Windows.Forms.Button();
            this.btnKaznionica = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(22, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 30);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(317, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Odabir objekta";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Highlight;
            this.pictureBox1.Location = new System.Drawing.Point(12, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(789, 49);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnZatvorPrizemlje
            // 
            this.btnZatvorPrizemlje.Location = new System.Drawing.Point(77, 79);
            this.btnZatvorPrizemlje.Name = "btnZatvorPrizemlje";
            this.btnZatvorPrizemlje.Size = new System.Drawing.Size(120, 81);
            this.btnZatvorPrizemlje.TabIndex = 10;
            this.btnZatvorPrizemlje.Text = "Zatvor, prizemlje";
            this.btnZatvorPrizemlje.UseVisualStyleBackColor = true;
            this.btnZatvorPrizemlje.Click += new System.EventHandler(this.btnZatvorPrizemlje_Click);
            // 
            // btnZatvorPrvi
            // 
            this.btnZatvorPrvi.Location = new System.Drawing.Point(253, 79);
            this.btnZatvorPrvi.Name = "btnZatvorPrvi";
            this.btnZatvorPrvi.Size = new System.Drawing.Size(120, 81);
            this.btnZatvorPrvi.TabIndex = 11;
            this.btnZatvorPrvi.Text = "Zatvor 1. kat";
            this.btnZatvorPrvi.UseVisualStyleBackColor = true;
            // 
            // btnZatvorDrugi
            // 
            this.btnZatvorDrugi.Location = new System.Drawing.Point(430, 79);
            this.btnZatvorDrugi.Name = "btnZatvorDrugi";
            this.btnZatvorDrugi.Size = new System.Drawing.Size(120, 81);
            this.btnZatvorDrugi.TabIndex = 12;
            this.btnZatvorDrugi.Text = "Zatvor 2. kat";
            this.btnZatvorDrugi.UseVisualStyleBackColor = true;
            // 
            // btnKaznionica
            // 
            this.btnKaznionica.Location = new System.Drawing.Point(604, 79);
            this.btnKaznionica.Name = "btnKaznionica";
            this.btnKaznionica.Size = new System.Drawing.Size(120, 81);
            this.btnKaznionica.TabIndex = 13;
            this.btnKaznionica.Text = "Kaznionica";
            this.btnKaznionica.UseVisualStyleBackColor = true;
            // 
            // frmOdabirObjekta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKaznionica);
            this.Controls.Add(this.btnZatvorDrugi);
            this.Controls.Add(this.btnZatvorPrvi);
            this.Controls.Add(this.btnZatvorPrizemlje);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmOdabirObjekta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOdabirObjekta";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnZatvorPrizemlje;
        private System.Windows.Forms.Button btnZatvorPrvi;
        private System.Windows.Forms.Button btnZatvorDrugi;
        private System.Windows.Forms.Button btnKaznionica;
    }
}