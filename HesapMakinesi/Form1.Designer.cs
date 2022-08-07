namespace HesapMakinesi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BtnBolumx = new System.Windows.Forms.Button();
            this.BtnKare = new System.Windows.Forms.Button();
            this.BtnKokAlma = new System.Windows.Forms.Button();
            this.BtnBolme = new System.Windows.Forms.Button();
            this.BtnCarpma = new System.Windows.Forms.Button();
            this.BtnUc = new System.Windows.Forms.Button();
            this.Btniki = new System.Windows.Forms.Button();
            this.BtnBir = new System.Windows.Forms.Button();
            this.BtnCikar = new System.Windows.Forms.Button();
            this.BtnAltı = new System.Windows.Forms.Button();
            this.BtnBes = new System.Windows.Forms.Button();
            this.BtnDort = new System.Windows.Forms.Button();
            this.BtnTopla = new System.Windows.Forms.Button();
            this.BtnDokuz = new System.Windows.Forms.Button();
            this.BtnSekiz = new System.Windows.Forms.Button();
            this.BtnYedi = new System.Windows.Forms.Button();
            this.BtnSıfır = new System.Windows.Forms.Button();
            this.BtnEsittir = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnMod = new System.Windows.Forms.Button();
            this.BtnTemizle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Corbel", 20F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(279, 68);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BtnBolumx
            // 
            this.BtnBolumx.BackColor = System.Drawing.Color.Transparent;
            this.BtnBolumx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBolumx.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.BtnBolumx.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnBolumx.Location = new System.Drawing.Point(57, 171);
            this.BtnBolumx.Name = "BtnBolumx";
            this.BtnBolumx.Size = new System.Drawing.Size(40, 40);
            this.BtnBolumx.TabIndex = 1;
            this.BtnBolumx.Text = "1/x";
            this.BtnBolumx.UseVisualStyleBackColor = false;
            this.BtnBolumx.Click += new System.EventHandler(this.BtnBolumx_Click);
            // 
            // BtnKare
            // 
            this.BtnKare.BackColor = System.Drawing.Color.Transparent;
            this.BtnKare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnKare.Font = new System.Drawing.Font("Corbel", 16F, System.Drawing.FontStyle.Bold);
            this.BtnKare.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnKare.Location = new System.Drawing.Point(103, 171);
            this.BtnKare.Name = "BtnKare";
            this.BtnKare.Size = new System.Drawing.Size(40, 40);
            this.BtnKare.TabIndex = 2;
            this.BtnKare.Text = "x²";
            this.BtnKare.UseVisualStyleBackColor = false;
            this.BtnKare.Click += new System.EventHandler(this.BtnKare_Click);
            // 
            // BtnKokAlma
            // 
            this.BtnKokAlma.BackColor = System.Drawing.Color.Transparent;
            this.BtnKokAlma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnKokAlma.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.BtnKokAlma.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnKokAlma.Location = new System.Drawing.Point(149, 171);
            this.BtnKokAlma.Name = "BtnKokAlma";
            this.BtnKokAlma.Size = new System.Drawing.Size(40, 40);
            this.BtnKokAlma.TabIndex = 3;
            this.BtnKokAlma.Text = "√x";
            this.BtnKokAlma.UseVisualStyleBackColor = false;
            this.BtnKokAlma.Click += new System.EventHandler(this.BtnKokAlma_Click);
            // 
            // BtnBolme
            // 
            this.BtnBolme.BackColor = System.Drawing.Color.Transparent;
            this.BtnBolme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBolme.Font = new System.Drawing.Font("Corbel", 16F, System.Drawing.FontStyle.Bold);
            this.BtnBolme.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnBolme.Location = new System.Drawing.Point(195, 171);
            this.BtnBolme.Name = "BtnBolme";
            this.BtnBolme.Size = new System.Drawing.Size(40, 40);
            this.BtnBolme.TabIndex = 4;
            this.BtnBolme.Text = "÷";
            this.BtnBolme.UseVisualStyleBackColor = false;
            this.BtnBolme.Click += new System.EventHandler(this.BtnBolme_Click);
            // 
            // BtnCarpma
            // 
            this.BtnCarpma.BackColor = System.Drawing.Color.Transparent;
            this.BtnCarpma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCarpma.Font = new System.Drawing.Font("Corbel", 16F, System.Drawing.FontStyle.Bold);
            this.BtnCarpma.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnCarpma.Location = new System.Drawing.Point(195, 217);
            this.BtnCarpma.Name = "BtnCarpma";
            this.BtnCarpma.Size = new System.Drawing.Size(40, 40);
            this.BtnCarpma.TabIndex = 8;
            this.BtnCarpma.Text = "×";
            this.BtnCarpma.UseVisualStyleBackColor = false;
            this.BtnCarpma.Click += new System.EventHandler(this.BtnCarpma_Click);
            // 
            // BtnUc
            // 
            this.BtnUc.BackColor = System.Drawing.Color.Transparent;
            this.BtnUc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUc.Font = new System.Drawing.Font("Corbel", 16F, System.Drawing.FontStyle.Bold);
            this.BtnUc.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnUc.Location = new System.Drawing.Point(149, 217);
            this.BtnUc.Name = "BtnUc";
            this.BtnUc.Size = new System.Drawing.Size(40, 40);
            this.BtnUc.TabIndex = 7;
            this.BtnUc.Text = "3";
            this.BtnUc.UseVisualStyleBackColor = false;
            this.BtnUc.Click += new System.EventHandler(this.BtnUc_Click);
            // 
            // Btniki
            // 
            this.Btniki.BackColor = System.Drawing.Color.Transparent;
            this.Btniki.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btniki.Font = new System.Drawing.Font("Corbel", 16F, System.Drawing.FontStyle.Bold);
            this.Btniki.ForeColor = System.Drawing.SystemColors.Control;
            this.Btniki.Location = new System.Drawing.Point(103, 217);
            this.Btniki.Name = "Btniki";
            this.Btniki.Size = new System.Drawing.Size(40, 40);
            this.Btniki.TabIndex = 6;
            this.Btniki.Text = "2";
            this.Btniki.UseVisualStyleBackColor = false;
            this.Btniki.Click += new System.EventHandler(this.Btniki_Click);
            // 
            // BtnBir
            // 
            this.BtnBir.BackColor = System.Drawing.Color.Transparent;
            this.BtnBir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBir.Font = new System.Drawing.Font("Corbel", 16F, System.Drawing.FontStyle.Bold);
            this.BtnBir.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnBir.Location = new System.Drawing.Point(57, 217);
            this.BtnBir.Name = "BtnBir";
            this.BtnBir.Size = new System.Drawing.Size(40, 40);
            this.BtnBir.TabIndex = 5;
            this.BtnBir.Text = "1";
            this.BtnBir.UseVisualStyleBackColor = false;
            this.BtnBir.Click += new System.EventHandler(this.BtnBir_Click);
            // 
            // BtnCikar
            // 
            this.BtnCikar.BackColor = System.Drawing.Color.Transparent;
            this.BtnCikar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCikar.Font = new System.Drawing.Font("Corbel", 16F, System.Drawing.FontStyle.Bold);
            this.BtnCikar.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnCikar.Location = new System.Drawing.Point(195, 263);
            this.BtnCikar.Name = "BtnCikar";
            this.BtnCikar.Size = new System.Drawing.Size(40, 40);
            this.BtnCikar.TabIndex = 12;
            this.BtnCikar.Text = "-";
            this.BtnCikar.UseVisualStyleBackColor = false;
            this.BtnCikar.Click += new System.EventHandler(this.BtnCikar_Click);
            // 
            // BtnAltı
            // 
            this.BtnAltı.BackColor = System.Drawing.Color.Transparent;
            this.BtnAltı.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAltı.Font = new System.Drawing.Font("Corbel", 16F, System.Drawing.FontStyle.Bold);
            this.BtnAltı.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnAltı.Location = new System.Drawing.Point(149, 263);
            this.BtnAltı.Name = "BtnAltı";
            this.BtnAltı.Size = new System.Drawing.Size(40, 40);
            this.BtnAltı.TabIndex = 11;
            this.BtnAltı.Text = "6";
            this.BtnAltı.UseVisualStyleBackColor = false;
            this.BtnAltı.Click += new System.EventHandler(this.BtnAltı_Click);
            // 
            // BtnBes
            // 
            this.BtnBes.BackColor = System.Drawing.Color.Transparent;
            this.BtnBes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBes.Font = new System.Drawing.Font("Corbel", 16F, System.Drawing.FontStyle.Bold);
            this.BtnBes.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnBes.Location = new System.Drawing.Point(103, 263);
            this.BtnBes.Name = "BtnBes";
            this.BtnBes.Size = new System.Drawing.Size(40, 40);
            this.BtnBes.TabIndex = 10;
            this.BtnBes.Text = "5";
            this.BtnBes.UseVisualStyleBackColor = false;
            this.BtnBes.Click += new System.EventHandler(this.BtnBes_Click);
            // 
            // BtnDort
            // 
            this.BtnDort.BackColor = System.Drawing.Color.Transparent;
            this.BtnDort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDort.Font = new System.Drawing.Font("Corbel", 16F, System.Drawing.FontStyle.Bold);
            this.BtnDort.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnDort.Location = new System.Drawing.Point(57, 263);
            this.BtnDort.Name = "BtnDort";
            this.BtnDort.Size = new System.Drawing.Size(40, 40);
            this.BtnDort.TabIndex = 9;
            this.BtnDort.Text = "4";
            this.BtnDort.UseVisualStyleBackColor = false;
            this.BtnDort.Click += new System.EventHandler(this.BtnDort_Click);
            // 
            // BtnTopla
            // 
            this.BtnTopla.BackColor = System.Drawing.Color.Transparent;
            this.BtnTopla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTopla.Font = new System.Drawing.Font("Corbel", 16F, System.Drawing.FontStyle.Bold);
            this.BtnTopla.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnTopla.Location = new System.Drawing.Point(195, 309);
            this.BtnTopla.Name = "BtnTopla";
            this.BtnTopla.Size = new System.Drawing.Size(40, 40);
            this.BtnTopla.TabIndex = 16;
            this.BtnTopla.Text = "+";
            this.BtnTopla.UseVisualStyleBackColor = false;
            this.BtnTopla.Click += new System.EventHandler(this.BtnTopla_Click);
            // 
            // BtnDokuz
            // 
            this.BtnDokuz.BackColor = System.Drawing.Color.Transparent;
            this.BtnDokuz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDokuz.Font = new System.Drawing.Font("Corbel", 16F, System.Drawing.FontStyle.Bold);
            this.BtnDokuz.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnDokuz.Location = new System.Drawing.Point(149, 309);
            this.BtnDokuz.Name = "BtnDokuz";
            this.BtnDokuz.Size = new System.Drawing.Size(40, 40);
            this.BtnDokuz.TabIndex = 15;
            this.BtnDokuz.Text = "9";
            this.BtnDokuz.UseVisualStyleBackColor = false;
            this.BtnDokuz.Click += new System.EventHandler(this.BtnDokuz_Click);
            // 
            // BtnSekiz
            // 
            this.BtnSekiz.BackColor = System.Drawing.Color.Transparent;
            this.BtnSekiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSekiz.Font = new System.Drawing.Font("Corbel", 16F, System.Drawing.FontStyle.Bold);
            this.BtnSekiz.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnSekiz.Location = new System.Drawing.Point(103, 309);
            this.BtnSekiz.Name = "BtnSekiz";
            this.BtnSekiz.Size = new System.Drawing.Size(40, 40);
            this.BtnSekiz.TabIndex = 14;
            this.BtnSekiz.Text = "8";
            this.BtnSekiz.UseVisualStyleBackColor = false;
            this.BtnSekiz.Click += new System.EventHandler(this.BtnSekiz_Click);
            // 
            // BtnYedi
            // 
            this.BtnYedi.BackColor = System.Drawing.Color.Transparent;
            this.BtnYedi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnYedi.Font = new System.Drawing.Font("Corbel", 16F, System.Drawing.FontStyle.Bold);
            this.BtnYedi.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnYedi.Location = new System.Drawing.Point(57, 309);
            this.BtnYedi.Name = "BtnYedi";
            this.BtnYedi.Size = new System.Drawing.Size(40, 40);
            this.BtnYedi.TabIndex = 13;
            this.BtnYedi.Text = "7";
            this.BtnYedi.UseVisualStyleBackColor = false;
            this.BtnYedi.Click += new System.EventHandler(this.BtnYedi_Click);
            // 
            // BtnSıfır
            // 
            this.BtnSıfır.BackColor = System.Drawing.Color.Transparent;
            this.BtnSıfır.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSıfır.Font = new System.Drawing.Font("Corbel", 16F, System.Drawing.FontStyle.Bold);
            this.BtnSıfır.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnSıfır.Location = new System.Drawing.Point(57, 355);
            this.BtnSıfır.Name = "BtnSıfır";
            this.BtnSıfır.Size = new System.Drawing.Size(86, 40);
            this.BtnSıfır.TabIndex = 18;
            this.BtnSıfır.Text = "0";
            this.BtnSıfır.UseVisualStyleBackColor = false;
            this.BtnSıfır.Click += new System.EventHandler(this.BtnSıfır_Click);
            // 
            // BtnEsittir
            // 
            this.BtnEsittir.BackColor = System.Drawing.Color.Transparent;
            this.BtnEsittir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEsittir.Font = new System.Drawing.Font("Corbel", 16F, System.Drawing.FontStyle.Bold);
            this.BtnEsittir.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnEsittir.Location = new System.Drawing.Point(149, 355);
            this.BtnEsittir.Name = "BtnEsittir";
            this.BtnEsittir.Size = new System.Drawing.Size(86, 40);
            this.BtnEsittir.TabIndex = 20;
            this.BtnEsittir.Text = "=";
            this.BtnEsittir.UseVisualStyleBackColor = false;
            this.BtnEsittir.Click += new System.EventHandler(this.BtnEsittir_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.BackColor = System.Drawing.Color.Transparent;
            this.BtnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSil.Font = new System.Drawing.Font("Corbel", 20F, System.Drawing.FontStyle.Bold);
            this.BtnSil.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnSil.Location = new System.Drawing.Point(149, 125);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(86, 40);
            this.BtnSil.TabIndex = 23;
            this.BtnSil.Text = "←";
            this.BtnSil.UseVisualStyleBackColor = false;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnMod
            // 
            this.BtnMod.BackColor = System.Drawing.Color.Transparent;
            this.BtnMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMod.Font = new System.Drawing.Font("Corbel", 16F, System.Drawing.FontStyle.Bold);
            this.BtnMod.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnMod.Location = new System.Drawing.Point(103, 125);
            this.BtnMod.Name = "BtnMod";
            this.BtnMod.Size = new System.Drawing.Size(40, 40);
            this.BtnMod.TabIndex = 22;
            this.BtnMod.Text = "%";
            this.BtnMod.UseVisualStyleBackColor = false;
            this.BtnMod.Click += new System.EventHandler(this.BtnMod_Click);
            // 
            // BtnTemizle
            // 
            this.BtnTemizle.BackColor = System.Drawing.Color.Transparent;
            this.BtnTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTemizle.Font = new System.Drawing.Font("Corbel", 16F, System.Drawing.FontStyle.Bold);
            this.BtnTemizle.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnTemizle.Location = new System.Drawing.Point(57, 125);
            this.BtnTemizle.Name = "BtnTemizle";
            this.BtnTemizle.Size = new System.Drawing.Size(40, 40);
            this.BtnTemizle.TabIndex = 21;
            this.BtnTemizle.Text = "C";
            this.BtnTemizle.UseVisualStyleBackColor = false;
            this.BtnTemizle.Click += new System.EventHandler(this.BtnTemizle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(28, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 19);
            this.label1.TabIndex = 24;
            this.label1.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(303, 433);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnMod);
            this.Controls.Add(this.BtnTemizle);
            this.Controls.Add(this.BtnEsittir);
            this.Controls.Add(this.BtnSıfır);
            this.Controls.Add(this.BtnTopla);
            this.Controls.Add(this.BtnDokuz);
            this.Controls.Add(this.BtnSekiz);
            this.Controls.Add(this.BtnYedi);
            this.Controls.Add(this.BtnCikar);
            this.Controls.Add(this.BtnAltı);
            this.Controls.Add(this.BtnBes);
            this.Controls.Add(this.BtnDort);
            this.Controls.Add(this.BtnCarpma);
            this.Controls.Add(this.BtnUc);
            this.Controls.Add(this.Btniki);
            this.Controls.Add(this.BtnBir);
            this.Controls.Add(this.BtnBolme);
            this.Controls.Add(this.BtnKokAlma);
            this.Controls.Add(this.BtnKare);
            this.Controls.Add(this.BtnBolumx);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hesap Makinesi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BtnBolumx;
        private System.Windows.Forms.Button BtnKare;
        private System.Windows.Forms.Button BtnKokAlma;
        private System.Windows.Forms.Button BtnBolme;
        private System.Windows.Forms.Button BtnCarpma;
        private System.Windows.Forms.Button BtnUc;
        private System.Windows.Forms.Button Btniki;
        private System.Windows.Forms.Button BtnBir;
        private System.Windows.Forms.Button BtnCikar;
        private System.Windows.Forms.Button BtnAltı;
        private System.Windows.Forms.Button BtnBes;
        private System.Windows.Forms.Button BtnDort;
        private System.Windows.Forms.Button BtnTopla;
        private System.Windows.Forms.Button BtnDokuz;
        private System.Windows.Forms.Button BtnSekiz;
        private System.Windows.Forms.Button BtnYedi;
        private System.Windows.Forms.Button BtnSıfır;
        private System.Windows.Forms.Button BtnEsittir;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnMod;
        private System.Windows.Forms.Button BtnTemizle;
        private System.Windows.Forms.Label label1;
    }
}

