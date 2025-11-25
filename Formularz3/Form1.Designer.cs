namespace Formularz3
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.position_comboBox = new System.Windows.Forms.ComboBox();
            this.surname_textBox = new System.Windows.Forms.TextBox();
            this.firstName_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.generatePass_button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.passLength_textBox = new System.Windows.Forms.TextBox();
            this.specialCharacters_checkBox = new System.Windows.Forms.CheckBox();
            this.numbers_checkBox = new System.Windows.Forms.CheckBox();
            this.letters_checkBox = new System.Windows.Forms.CheckBox();
            this.complete_button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.position_comboBox);
            this.groupBox1.Controls.Add(this.surname_textBox);
            this.groupBox1.Controls.Add(this.firstName_textBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 173);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dane pracownika";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Stanowisko";
            // 
            // position_comboBox
            // 
            this.position_comboBox.FormattingEnabled = true;
            this.position_comboBox.Items.AddRange(new object[] {
            "Kierownik",
            "Starszy programista",
            "Młodszy programista",
            "Tester"});
            this.position_comboBox.Location = new System.Drawing.Point(97, 100);
            this.position_comboBox.Name = "position_comboBox";
            this.position_comboBox.Size = new System.Drawing.Size(121, 21);
            this.position_comboBox.TabIndex = 4;
            // 
            // surname_textBox
            // 
            this.surname_textBox.Location = new System.Drawing.Point(97, 64);
            this.surname_textBox.Name = "surname_textBox";
            this.surname_textBox.Size = new System.Drawing.Size(121, 20);
            this.surname_textBox.TabIndex = 3;
            // 
            // firstName_textBox
            // 
            this.firstName_textBox.Location = new System.Drawing.Point(97, 30);
            this.firstName_textBox.Name = "firstName_textBox";
            this.firstName_textBox.Size = new System.Drawing.Size(121, 20);
            this.firstName_textBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nazwisko";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Imię";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.generatePass_button);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.passLength_textBox);
            this.groupBox2.Controls.Add(this.specialCharacters_checkBox);
            this.groupBox2.Controls.Add(this.numbers_checkBox);
            this.groupBox2.Controls.Add(this.letters_checkBox);
            this.groupBox2.Location = new System.Drawing.Point(291, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(231, 173);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Generowanie hasła";
            // 
            // generatePass_button
            // 
            this.generatePass_button.BackColor = System.Drawing.Color.SteelBlue;
            this.generatePass_button.ForeColor = System.Drawing.Color.White;
            this.generatePass_button.Location = new System.Drawing.Point(67, 142);
            this.generatePass_button.Name = "generatePass_button";
            this.generatePass_button.Size = new System.Drawing.Size(112, 25);
            this.generatePass_button.TabIndex = 3;
            this.generatePass_button.Text = "Generuj hasło";
            this.generatePass_button.UseVisualStyleBackColor = false;
            this.generatePass_button.Click += new System.EventHandler(this.generatePass_button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ile znaków?";
            // 
            // passLength_textBox
            // 
            this.passLength_textBox.Location = new System.Drawing.Point(114, 29);
            this.passLength_textBox.Name = "passLength_textBox";
            this.passLength_textBox.Size = new System.Drawing.Size(107, 20);
            this.passLength_textBox.TabIndex = 3;
            // 
            // specialCharacters_checkBox
            // 
            this.specialCharacters_checkBox.AutoSize = true;
            this.specialCharacters_checkBox.Location = new System.Drawing.Point(9, 105);
            this.specialCharacters_checkBox.Name = "specialCharacters_checkBox";
            this.specialCharacters_checkBox.Size = new System.Drawing.Size(101, 17);
            this.specialCharacters_checkBox.TabIndex = 2;
            this.specialCharacters_checkBox.Text = "Znaki specjalne";
            this.specialCharacters_checkBox.UseVisualStyleBackColor = true;
            // 
            // numbers_checkBox
            // 
            this.numbers_checkBox.AutoSize = true;
            this.numbers_checkBox.Location = new System.Drawing.Point(9, 82);
            this.numbers_checkBox.Name = "numbers_checkBox";
            this.numbers_checkBox.Size = new System.Drawing.Size(49, 17);
            this.numbers_checkBox.TabIndex = 1;
            this.numbers_checkBox.Text = "Cyfry";
            this.numbers_checkBox.UseVisualStyleBackColor = true;
            // 
            // letters_checkBox
            // 
            this.letters_checkBox.AutoSize = true;
            this.letters_checkBox.Checked = true;
            this.letters_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.letters_checkBox.Location = new System.Drawing.Point(9, 59);
            this.letters_checkBox.Name = "letters_checkBox";
            this.letters_checkBox.Size = new System.Drawing.Size(115, 17);
            this.letters_checkBox.TabIndex = 0;
            this.letters_checkBox.Text = "Małe i wielkie litery";
            this.letters_checkBox.UseVisualStyleBackColor = true;
            // 
            // complete_button
            // 
            this.complete_button.BackColor = System.Drawing.Color.SteelBlue;
            this.complete_button.ForeColor = System.Drawing.Color.White;
            this.complete_button.Location = new System.Drawing.Point(176, 191);
            this.complete_button.Name = "complete_button";
            this.complete_button.Size = new System.Drawing.Size(214, 25);
            this.complete_button.TabIndex = 2;
            this.complete_button.Text = "Zatwierdź";
            this.complete_button.UseVisualStyleBackColor = false;
            this.complete_button.Click += new System.EventHandler(this.complete_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(539, 240);
            this.Controls.Add(this.complete_button);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Dodaj pracownika";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox position_comboBox;
        private System.Windows.Forms.TextBox surname_textBox;
        private System.Windows.Forms.TextBox firstName_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox specialCharacters_checkBox;
        private System.Windows.Forms.CheckBox numbers_checkBox;
        private System.Windows.Forms.CheckBox letters_checkBox;
        private System.Windows.Forms.Button complete_button;
        private System.Windows.Forms.Button generatePass_button;
        private System.Windows.Forms.TextBox passLength_textBox;
    }
}

