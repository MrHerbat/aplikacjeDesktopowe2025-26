namespace Formularz
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ankietaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hasłoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox_ankieta = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_nazwisko = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Hobby = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox_ankieta.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ankietaToolStripMenuItem,
            this.hasłoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(318, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ankietaToolStripMenuItem
            // 
            this.ankietaToolStripMenuItem.Name = "ankietaToolStripMenuItem";
            this.ankietaToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.ankietaToolStripMenuItem.Text = "Ankieta";
            this.ankietaToolStripMenuItem.Click += new System.EventHandler(this.ankietaToolStripMenuItem_Click);
            // 
            // hasłoToolStripMenuItem
            // 
            this.hasłoToolStripMenuItem.Name = "hasłoToolStripMenuItem";
            this.hasłoToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.hasłoToolStripMenuItem.Text = "Hasło";
            this.hasłoToolStripMenuItem.Click += new System.EventHandler(this.hasłoToolStripMenuItem_Click);
            // 
            // groupBox_ankieta
            // 
            this.groupBox_ankieta.Controls.Add(this.button1);
            this.groupBox_ankieta.Controls.Add(this.Hobby);
            this.groupBox_ankieta.Controls.Add(this.listBox1);
            this.groupBox_ankieta.Controls.Add(this.radioButton3);
            this.groupBox_ankieta.Controls.Add(this.radioButton2);
            this.groupBox_ankieta.Controls.Add(this.radioButton1);
            this.groupBox_ankieta.Controls.Add(this.textBox_nazwisko);
            this.groupBox_ankieta.Controls.Add(this.label2);
            this.groupBox_ankieta.Controls.Add(this.label1);
            this.groupBox_ankieta.Location = new System.Drawing.Point(13, 28);
            this.groupBox_ankieta.Name = "groupBox_ankieta";
            this.groupBox_ankieta.Size = new System.Drawing.Size(230, 253);
            this.groupBox_ankieta.TabIndex = 1;
            this.groupBox_ankieta.TabStop = false;
            this.groupBox_ankieta.Text = "Ankieta";
            this.groupBox_ankieta.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Podaj swoje nazwisko: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ile masz lat?";
            // 
            // textBox_nazwisko
            // 
            this.textBox_nazwisko.Location = new System.Drawing.Point(119, 17);
            this.textBox_nazwisko.Name = "textBox_nazwisko";
            this.textBox_nazwisko.Size = new System.Drawing.Size(100, 20);
            this.textBox_nazwisko.TabIndex = 2;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(10, 61);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(46, 17);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "0-18";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(59, 60);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(52, 17);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "19-60";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(117, 60);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(46, 17);
            this.radioButton3.TabIndex = 5;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "61...";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Rysowanie",
            "Muzyka",
            "Bieganie",
            "Jazda na rowerze",
            "Sport",
            "Czytanie"});
            this.listBox1.Location = new System.Drawing.Point(10, 113);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 6;
            // 
            // Hobby
            // 
            this.Hobby.AutoSize = true;
            this.Hobby.Location = new System.Drawing.Point(6, 97);
            this.Hobby.Name = "Hobby";
            this.Hobby.Size = new System.Drawing.Size(38, 13);
            this.Hobby.TabIndex = 7;
            this.Hobby.Text = "Hobby";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(149, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Zatwierdź";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 365);
            this.Controls.Add(this.groupBox_ankieta);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox_ankieta.ResumeLayout(false);
            this.groupBox_ankieta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ankietaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hasłoToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox_ankieta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_nazwisko;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Hobby;
        private System.Windows.Forms.ListBox listBox1;
    }
}

