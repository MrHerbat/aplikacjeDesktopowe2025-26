namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.liczbaA = new System.Windows.Forms.TextBox();
            this.liczbaB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.przycisk_dodawanie = new System.Windows.Forms.Button();
            this.przycisk_odejmowanie = new System.Windows.Forms.Button();
            this.przycisk_mnozenie = new System.Windows.Forms.Button();
            this.przycisk_dzielenie = new System.Windows.Forms.Button();
            this.przycisk_nwd = new System.Windows.Forms.Button();
            this.przycisk_sumaCyfr = new System.Windows.Forms.Button();
            this.wynik = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.przycisk_DecToBin = new System.Windows.Forms.Button();
            this.przycisk_silnia = new System.Windows.Forms.Button();
            this.przycisk_odblokujB = new System.Windows.Forms.Button();
            this.przycisk_potega = new System.Windows.Forms.Button();
            this.przycisk_DecToHex = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(112, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kalkulator";
            // 
            // liczbaA
            // 
            this.liczbaA.Location = new System.Drawing.Point(112, 52);
            this.liczbaA.Name = "liczbaA";
            this.liczbaA.Size = new System.Drawing.Size(136, 20);
            this.liczbaA.TabIndex = 1;
            // 
            // liczbaB
            // 
            this.liczbaB.Location = new System.Drawing.Point(112, 78);
            this.liczbaB.Name = "liczbaB";
            this.liczbaB.Size = new System.Drawing.Size(136, 20);
            this.liczbaB.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(44, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "liczba a:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(44, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "liczba b:";
            // 
            // przycisk_dodawanie
            // 
            this.przycisk_dodawanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.przycisk_dodawanie.Location = new System.Drawing.Point(94, 114);
            this.przycisk_dodawanie.Name = "przycisk_dodawanie";
            this.przycisk_dodawanie.Size = new System.Drawing.Size(33, 32);
            this.przycisk_dodawanie.TabIndex = 5;
            this.przycisk_dodawanie.Text = "+";
            this.przycisk_dodawanie.UseVisualStyleBackColor = true;
            this.przycisk_dodawanie.Click += new System.EventHandler(this.przycisk_dodawanie_Click);
            // 
            // przycisk_odejmowanie
            // 
            this.przycisk_odejmowanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.przycisk_odejmowanie.Location = new System.Drawing.Point(133, 114);
            this.przycisk_odejmowanie.Name = "przycisk_odejmowanie";
            this.przycisk_odejmowanie.Size = new System.Drawing.Size(33, 32);
            this.przycisk_odejmowanie.TabIndex = 6;
            this.przycisk_odejmowanie.Text = "-";
            this.przycisk_odejmowanie.UseVisualStyleBackColor = true;
            this.przycisk_odejmowanie.Click += new System.EventHandler(this.przycisk_odejmowanie_Click);
            // 
            // przycisk_mnozenie
            // 
            this.przycisk_mnozenie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.przycisk_mnozenie.Location = new System.Drawing.Point(172, 114);
            this.przycisk_mnozenie.Name = "przycisk_mnozenie";
            this.przycisk_mnozenie.Size = new System.Drawing.Size(35, 32);
            this.przycisk_mnozenie.TabIndex = 7;
            this.przycisk_mnozenie.Text = "*";
            this.przycisk_mnozenie.UseVisualStyleBackColor = true;
            this.przycisk_mnozenie.Click += new System.EventHandler(this.przycisk_mnozenie_Click);
            // 
            // przycisk_dzielenie
            // 
            this.przycisk_dzielenie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.przycisk_dzielenie.Location = new System.Drawing.Point(211, 114);
            this.przycisk_dzielenie.Name = "przycisk_dzielenie";
            this.przycisk_dzielenie.Size = new System.Drawing.Size(35, 32);
            this.przycisk_dzielenie.TabIndex = 8;
            this.przycisk_dzielenie.Text = "/";
            this.przycisk_dzielenie.UseVisualStyleBackColor = true;
            this.przycisk_dzielenie.Click += new System.EventHandler(this.przycisk_dzielenie_Click);
            // 
            // przycisk_nwd
            // 
            this.przycisk_nwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.przycisk_nwd.Location = new System.Drawing.Point(94, 152);
            this.przycisk_nwd.Name = "przycisk_nwd";
            this.przycisk_nwd.Size = new System.Drawing.Size(74, 32);
            this.przycisk_nwd.TabIndex = 9;
            this.przycisk_nwd.Text = "NWD";
            this.przycisk_nwd.UseVisualStyleBackColor = true;
            this.przycisk_nwd.Click += new System.EventHandler(this.przycisk_nwd_Click);
            // 
            // przycisk_sumaCyfr
            // 
            this.przycisk_sumaCyfr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.przycisk_sumaCyfr.Location = new System.Drawing.Point(172, 114);
            this.przycisk_sumaCyfr.Name = "przycisk_sumaCyfr";
            this.przycisk_sumaCyfr.Size = new System.Drawing.Size(74, 32);
            this.przycisk_sumaCyfr.TabIndex = 10;
            this.przycisk_sumaCyfr.Text = "Suma";
            this.przycisk_sumaCyfr.UseVisualStyleBackColor = true;
            this.przycisk_sumaCyfr.Visible = false;
            this.przycisk_sumaCyfr.Click += new System.EventHandler(this.przycisk_sumaCyfr_Click);
            // 
            // wynik
            // 
            this.wynik.Enabled = false;
            this.wynik.ForeColor = System.Drawing.Color.Black;
            this.wynik.Location = new System.Drawing.Point(112, 238);
            this.wynik.Name = "wynik";
            this.wynik.Size = new System.Drawing.Size(136, 20);
            this.wynik.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(57, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "wynik:";
            // 
            // przycisk_DecToBin
            // 
            this.przycisk_DecToBin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.przycisk_DecToBin.Location = new System.Drawing.Point(172, 153);
            this.przycisk_DecToBin.Name = "przycisk_DecToBin";
            this.przycisk_DecToBin.Size = new System.Drawing.Size(74, 32);
            this.przycisk_DecToBin.TabIndex = 13;
            this.przycisk_DecToBin.Text = "Bin";
            this.przycisk_DecToBin.UseVisualStyleBackColor = true;
            this.przycisk_DecToBin.Visible = false;
            this.przycisk_DecToBin.Click += new System.EventHandler(this.przycisk_DecToBin_Click);
            // 
            // przycisk_silnia
            // 
            this.przycisk_silnia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.przycisk_silnia.Location = new System.Drawing.Point(94, 114);
            this.przycisk_silnia.Name = "przycisk_silnia";
            this.przycisk_silnia.Size = new System.Drawing.Size(74, 32);
            this.przycisk_silnia.TabIndex = 14;
            this.przycisk_silnia.Text = "x!";
            this.przycisk_silnia.UseVisualStyleBackColor = true;
            this.przycisk_silnia.Visible = false;
            this.przycisk_silnia.Click += new System.EventHandler(this.przycisk_silnia_Click);
            // 
            // przycisk_odblokujB
            // 
            this.przycisk_odblokujB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.przycisk_odblokujB.Location = new System.Drawing.Point(236, 7);
            this.przycisk_odblokujB.Name = "przycisk_odblokujB";
            this.przycisk_odblokujB.Size = new System.Drawing.Size(93, 34);
            this.przycisk_odblokujB.TabIndex = 15;
            this.przycisk_odblokujB.Text = "Zmień listę działan";
            this.przycisk_odblokujB.UseVisualStyleBackColor = true;
            this.przycisk_odblokujB.Click += new System.EventHandler(this.przycisk_zmienListeDzialan_Click);
            // 
            // przycisk_potega
            // 
            this.przycisk_potega.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.przycisk_potega.Location = new System.Drawing.Point(172, 153);
            this.przycisk_potega.Name = "przycisk_potega";
            this.przycisk_potega.Size = new System.Drawing.Size(74, 32);
            this.przycisk_potega.TabIndex = 16;
            this.przycisk_potega.Text = "x^y";
            this.przycisk_potega.UseVisualStyleBackColor = true;
            this.przycisk_potega.Click += new System.EventHandler(this.przycisk_potega_Click);
            // 
            // przycisk_DecToHex
            // 
            this.przycisk_DecToHex.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.przycisk_DecToHex.Location = new System.Drawing.Point(94, 153);
            this.przycisk_DecToHex.Name = "przycisk_DecToHex";
            this.przycisk_DecToHex.Size = new System.Drawing.Size(74, 32);
            this.przycisk_DecToHex.TabIndex = 17;
            this.przycisk_DecToHex.Text = "Hex";
            this.przycisk_DecToHex.UseVisualStyleBackColor = true;
            this.przycisk_DecToHex.Visible = false;
            this.przycisk_DecToHex.Click += new System.EventHandler(this.przycisk_DecToHex_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 343);
            this.Controls.Add(this.przycisk_DecToHex);
            this.Controls.Add(this.przycisk_potega);
            this.Controls.Add(this.przycisk_odblokujB);
            this.Controls.Add(this.przycisk_silnia);
            this.Controls.Add(this.przycisk_DecToBin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.wynik);
            this.Controls.Add(this.przycisk_sumaCyfr);
            this.Controls.Add(this.przycisk_nwd);
            this.Controls.Add(this.przycisk_dzielenie);
            this.Controls.Add(this.przycisk_mnozenie);
            this.Controls.Add(this.przycisk_odejmowanie);
            this.Controls.Add(this.przycisk_dodawanie);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.liczbaB);
            this.Controls.Add(this.liczbaA);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Kalkulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox liczbaA;
        private System.Windows.Forms.TextBox liczbaB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button przycisk_dodawanie;
        private System.Windows.Forms.Button przycisk_odejmowanie;
        private System.Windows.Forms.Button przycisk_mnozenie;
        private System.Windows.Forms.Button przycisk_dzielenie;
        private System.Windows.Forms.Button przycisk_nwd;
        private System.Windows.Forms.Button przycisk_sumaCyfr;
        private System.Windows.Forms.TextBox wynik;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button przycisk_DecToBin;
        private System.Windows.Forms.Button przycisk_silnia;
        private System.Windows.Forms.Button przycisk_odblokujB;
        private System.Windows.Forms.Button przycisk_potega;
        private System.Windows.Forms.Button przycisk_DecToHex;
    }
}

