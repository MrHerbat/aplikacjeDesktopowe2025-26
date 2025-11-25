namespace zadanie1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.liczba_a = new System.Windows.Forms.TextBox();
            this.liczba_b = new System.Windows.Forms.TextBox();
            this.liczba_c = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.suma = new System.Windows.Forms.TextBox();
            this.kwadrat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "liczba 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "liczba 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "liczba 3";
            // 
            // liczba_a
            // 
            this.liczba_a.Location = new System.Drawing.Point(158, 12);
            this.liczba_a.Name = "liczba_a";
            this.liczba_a.Size = new System.Drawing.Size(100, 20);
            this.liczba_a.TabIndex = 3;
            // 
            // liczba_b
            // 
            this.liczba_b.Location = new System.Drawing.Point(158, 38);
            this.liczba_b.Name = "liczba_b";
            this.liczba_b.Size = new System.Drawing.Size(100, 20);
            this.liczba_b.TabIndex = 4;
            // 
            // liczba_c
            // 
            this.liczba_c.Location = new System.Drawing.Point(158, 64);
            this.liczba_c.Name = "liczba_c";
            this.liczba_c.Size = new System.Drawing.Size(100, 20);
            this.liczba_c.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(285, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Suma";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(360, 158);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Sprawdź";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // suma
            // 
            this.suma.Location = new System.Drawing.Point(77, 130);
            this.suma.Multiline = true;
            this.suma.Name = "suma";
            this.suma.ReadOnly = true;
            this.suma.Size = new System.Drawing.Size(206, 20);
            this.suma.TabIndex = 8;
            // 
            // kwadrat
            // 
            this.kwadrat.Location = new System.Drawing.Point(148, 160);
            this.kwadrat.Multiline = true;
            this.kwadrat.Name = "kwadrat";
            this.kwadrat.ReadOnly = true;
            this.kwadrat.Size = new System.Drawing.Size(206, 20);
            this.kwadrat.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Suma liczb:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Czy suma jest kwadratem?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 192);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.kwadrat);
            this.Controls.Add(this.suma);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.liczba_c);
            this.Controls.Add(this.liczba_b);
            this.Controls.Add(this.liczba_a);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Zadanie 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox liczba_a;
        private System.Windows.Forms.TextBox liczba_b;
        private System.Windows.Forms.TextBox liczba_c;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox suma;
        private System.Windows.Forms.TextBox kwadrat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

