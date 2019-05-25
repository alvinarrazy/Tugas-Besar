namespace KalkulatorZakat
{
    partial class Form1
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
            this.penghasilanperbulan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pengeluaranperbulan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.hargaberas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.zakatyangdibayar = new System.Windows.Forms.TextBox();
            this.wajibtidak = new System.Windows.Forms.TextBox();
            this.besarnishab = new System.Windows.Forms.TextBox();
            this.hitung = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // penghasilanperbulan
            // 
            this.penghasilanperbulan.Location = new System.Drawing.Point(143, 160);
            this.penghasilanperbulan.Name = "penghasilanperbulan";
            this.penghasilanperbulan.Size = new System.Drawing.Size(185, 20);
            this.penghasilanperbulan.TabIndex = 0;
            this.penghasilanperbulan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Penghasilanperbulan_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Penghasilan Perbulan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pengeluaran Perbulan";
            // 
            // pengeluaranperbulan
            // 
            this.pengeluaranperbulan.Location = new System.Drawing.Point(143, 200);
            this.pengeluaranperbulan.Name = "pengeluaranperbulan";
            this.pengeluaranperbulan.Size = new System.Drawing.Size(185, 20);
            this.pengeluaranperbulan.TabIndex = 3;
            this.pengeluaranperbulan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Pengeluaranperbulan_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Harga beras per Kilogram";
            // 
            // hargaberas
            // 
            this.hargaberas.Location = new System.Drawing.Point(143, 119);
            this.hargaberas.Name = "hargaberas";
            this.hargaberas.Size = new System.Drawing.Size(185, 20);
            this.hargaberas.TabIndex = 5;
            this.hargaberas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Hargaberas_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(361, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Besar Nishab zakat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(361, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Zakat yang harus dibayar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(361, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Apakah wajib membayar zakat?";
            // 
            // zakatyangdibayar
            // 
            this.zakatyangdibayar.Location = new System.Drawing.Point(524, 200);
            this.zakatyangdibayar.Name = "zakatyangdibayar";
            this.zakatyangdibayar.Size = new System.Drawing.Size(185, 20);
            this.zakatyangdibayar.TabIndex = 9;
            // 
            // wajibtidak
            // 
            this.wajibtidak.Location = new System.Drawing.Point(524, 160);
            this.wajibtidak.Name = "wajibtidak";
            this.wajibtidak.Size = new System.Drawing.Size(185, 20);
            this.wajibtidak.TabIndex = 10;
            // 
            // besarnishab
            // 
            this.besarnishab.Location = new System.Drawing.Point(524, 119);
            this.besarnishab.Name = "besarnishab";
            this.besarnishab.Size = new System.Drawing.Size(185, 20);
            this.besarnishab.TabIndex = 11;
            this.besarnishab.TextChanged += new System.EventHandler(this.Besarnishab_TextChanged);
            // 
            // hitung
            // 
            this.hitung.Location = new System.Drawing.Point(577, 259);
            this.hitung.Name = "hitung";
            this.hitung.Size = new System.Drawing.Size(106, 42);
            this.hitung.TabIndex = 12;
            this.hitung.Text = "Hitung";
            this.hitung.UseVisualStyleBackColor = true;
            this.hitung.Click += new System.EventHandler(this.Hitung_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(35, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(648, 55);
            this.label7.TabIndex = 13;
            this.label7.Text = "Kalkulator Zakat Penghasilan";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 313);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.hitung);
            this.Controls.Add(this.besarnishab);
            this.Controls.Add(this.wajibtidak);
            this.Controls.Add(this.zakatyangdibayar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.hargaberas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pengeluaranperbulan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.penghasilanperbulan);
            this.Name = "Form1";
            this.Text = "Kalkulator Zakat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox penghasilanperbulan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pengeluaranperbulan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox hargaberas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox zakatyangdibayar;
        private System.Windows.Forms.TextBox wajibtidak;
        private System.Windows.Forms.TextBox besarnishab;
        private System.Windows.Forms.Button hitung;
        private System.Windows.Forms.Label label7;
    }
}

