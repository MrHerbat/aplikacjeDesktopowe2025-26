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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_nazwisko = new System.Windows.Forms.TextBox();
            this.textBox_wiek = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_accept = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.RichTextBox();
            this.checkedList_jezyki = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkedList_hobby = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_hobby = new System.Windows.Forms.RichTextBox();
            this.textBox_jezyki = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_m = new System.Windows.Forms.RadioButton();
            this.radioButton_k = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(133, 83);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(61, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "student";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Podaj Nazwisko:";
            // 
            // textBox_nazwisko
            // 
            this.textBox_nazwisko.Location = new System.Drawing.Point(195, 22);
            this.textBox_nazwisko.Name = "textBox_nazwisko";
            this.textBox_nazwisko.Size = new System.Drawing.Size(100, 20);
            this.textBox_nazwisko.TabIndex = 2;
            // 
            // textBox_wiek
            // 
            this.textBox_wiek.Location = new System.Drawing.Point(195, 48);
            this.textBox_wiek.Name = "textBox_wiek";
            this.textBox_wiek.Size = new System.Drawing.Size(100, 20);
            this.textBox_wiek.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Podaj Wiek:";
            // 
            // button_accept
            // 
            this.button_accept.Location = new System.Drawing.Point(164, 329);
            this.button_accept.Name = "button_accept";
            this.button_accept.Size = new System.Drawing.Size(75, 23);
            this.button_accept.TabIndex = 5;
            this.button_accept.Text = "zatwierdź";
            this.button_accept.UseVisualStyleBackColor = true;
            this.button_accept.Click += new System.EventHandler(this.button_accept_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(23, 367);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 133);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "";
            // 
            // checkedList_jezyki
            // 
            this.checkedList_jezyki.FormattingEnabled = true;
            this.checkedList_jezyki.Items.AddRange(new object[] {
            "Angielski",
            "Niemiecki",
            "Francuski",
            "Norweski",
            "Japoński"});
            this.checkedList_jezyki.Location = new System.Drawing.Point(226, 212);
            this.checkedList_jezyki.Name = "checkedList_jezyki";
            this.checkedList_jezyki.Size = new System.Drawing.Size(163, 94);
            this.checkedList_jezyki.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Jakie znasz języki obce:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Jakie masz zainteresowania:";
            // 
            // checkedList_hobby
            // 
            this.checkedList_hobby.FormattingEnabled = true;
            this.checkedList_hobby.Items.AddRange(new object[] {
            "Sport",
            "Muzyka",
            "Rysowanie",
            "Czytanie książek",
            "Granie na komputerze"});
            this.checkedList_hobby.Location = new System.Drawing.Point(22, 212);
            this.checkedList_hobby.Name = "checkedList_hobby";
            this.checkedList_hobby.Size = new System.Drawing.Size(163, 94);
            this.checkedList_hobby.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(182, 367);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Twoje zainteresowania:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(182, 435);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Twoje języki obce:";
            // 
            // textBox_hobby
            // 
            this.textBox_hobby.Enabled = false;
            this.textBox_hobby.Location = new System.Drawing.Point(185, 383);
            this.textBox_hobby.Name = "textBox_hobby";
            this.textBox_hobby.Size = new System.Drawing.Size(204, 49);
            this.textBox_hobby.TabIndex = 14;
            this.textBox_hobby.Text = "";
            // 
            // textBox_jezyki
            // 
            this.textBox_jezyki.Enabled = false;
            this.textBox_jezyki.Location = new System.Drawing.Point(185, 451);
            this.textBox_jezyki.Name = "textBox_jezyki";
            this.textBox_jezyki.Size = new System.Drawing.Size(204, 49);
            this.textBox_jezyki.TabIndex = 15;
            this.textBox_jezyki.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_k);
            this.groupBox1.Controls.Add(this.radioButton_m);
            this.groupBox1.Location = new System.Drawing.Point(145, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(113, 74);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wybierz płeć:";
            // 
            // radioButton_m
            // 
            this.radioButton_m.AutoSize = true;
            this.radioButton_m.Location = new System.Drawing.Point(7, 20);
            this.radioButton_m.Name = "radioButton_m";
            this.radioButton_m.Size = new System.Drawing.Size(78, 17);
            this.radioButton_m.TabIndex = 0;
            this.radioButton_m.TabStop = true;
            this.radioButton_m.Text = "Mężczyzna";
            this.radioButton_m.UseVisualStyleBackColor = true;
            // 
            // radioButton_k
            // 
            this.radioButton_k.AutoSize = true;
            this.radioButton_k.Location = new System.Drawing.Point(6, 43);
            this.radioButton_k.Name = "radioButton_k";
            this.radioButton_k.Size = new System.Drawing.Size(61, 17);
            this.radioButton_k.TabIndex = 1;
            this.radioButton_k.TabStop = true;
            this.radioButton_k.Text = "Kobieta";
            this.radioButton_k.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 522);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox_jezyki);
            this.Controls.Add(this.textBox_hobby);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkedList_hobby);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkedList_jezyki);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_accept);
            this.Controls.Add(this.textBox_wiek);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_nazwisko);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox1);
            this.Name = "Form1";
            this.Text = "Dane osobowe";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_nazwisko;
        private System.Windows.Forms.TextBox textBox_wiek;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_accept;
        private System.Windows.Forms.RichTextBox textBox1;
        private System.Windows.Forms.CheckedListBox checkedList_jezyki;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox checkedList_hobby;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox textBox_hobby;
        private System.Windows.Forms.RichTextBox textBox_jezyki;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_k;
        private System.Windows.Forms.RadioButton radioButton_m;
    }
}

