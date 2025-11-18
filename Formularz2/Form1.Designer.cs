namespace Formularz2
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
            this.comboBox_zamieszkanie = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.button_zatwierdz = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.textBox_output = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // comboBox_zamieszkanie
            // 
            this.comboBox_zamieszkanie.FormattingEnabled = true;
            this.comboBox_zamieszkanie.Items.AddRange(new object[] {
            "Wieś",
            "Miasteczko <10 tyś.",
            "Miasto 10-100 tyś.",
            "Miasto >100 tyś."});
            this.comboBox_zamieszkanie.Location = new System.Drawing.Point(49, 38);
            this.comboBox_zamieszkanie.Name = "comboBox_zamieszkanie";
            this.comboBox_zamieszkanie.Size = new System.Drawing.Size(121, 21);
            this.comboBox_zamieszkanie.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Miejsce zamieszkania:";
            // 
            // button_zatwierdz
            // 
            this.button_zatwierdz.Location = new System.Drawing.Point(83, 214);
            this.button_zatwierdz.Name = "button_zatwierdz";
            this.button_zatwierdz.Size = new System.Drawing.Size(75, 23);
            this.button_zatwierdz.TabIndex = 2;
            this.button_zatwierdz.Text = "zatwierdź";
            this.button_zatwierdz.UseVisualStyleBackColor = true;
            this.button_zatwierdz.Click += new System.EventHandler(this.button_zatwierdz_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Szkoła podstawowa",
            "Liceum",
            "Technikum",
            "Szkoła Branżowa",
            "Studia"});
            this.listBox1.Location = new System.Drawing.Point(49, 104);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(141, 95);
            this.listBox1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "W jakiej szkole się uczysz:";
            // 
            // textBox_output
            // 
            this.textBox_output.Enabled = false;
            this.textBox_output.Location = new System.Drawing.Point(12, 243);
            this.textBox_output.Name = "textBox_output";
            this.textBox_output.Size = new System.Drawing.Size(225, 96);
            this.textBox_output.TabIndex = 6;
            this.textBox_output.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 376);
            this.Controls.Add(this.textBox_output);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button_zatwierdz);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_zamieszkanie);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_zamieszkanie;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_zatwierdz;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.RichTextBox textBox_output;
    }
}

