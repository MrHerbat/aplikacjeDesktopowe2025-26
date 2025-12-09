namespace Formularz4
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
            this.obliczeniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.energiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.potencjalnaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kinetycznaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ruchJednostajnyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prędkośćToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drogaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.czasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.potential_groupBox = new System.Windows.Forms.GroupBox();
            this.potential = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.potential_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.height_textBox = new System.Windows.Forms.TextBox();
            this.mass_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.mass_textBox2 = new System.Windows.Forms.TextBox();
            this.velocity_textBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.kinetic_textBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.kinetyczna = new System.Windows.Forms.Button();
            this.kinetic_groupBox = new System.Windows.Forms.GroupBox();
            this.jednostajny_groupBox = new System.Windows.Forms.GroupBox();
            this.rjp = new System.Windows.Forms.Button();
            this.rjp_wynik_label = new System.Windows.Forms.Label();
            this.rjp_b_label = new System.Windows.Forms.Label();
            this.rjp_a_label = new System.Windows.Forms.Label();
            this.rjp_wynik_textBox = new System.Windows.Forms.TextBox();
            this.rjp_wynik = new System.Windows.Forms.Label();
            this.rjp_textBox2 = new System.Windows.Forms.TextBox();
            this.rjp_textBox1 = new System.Windows.Forms.TextBox();
            this.rjp_b = new System.Windows.Forms.Label();
            this.rjp_a = new System.Windows.Forms.Label();
            this.test_wyniki = new System.Windows.Forms.GroupBox();
            this.nazwisko_textBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.Button();
            this.wynik_textBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.potential_groupBox.SuspendLayout();
            this.kinetic_groupBox.SuspendLayout();
            this.jednostajny_groupBox.SuspendLayout();
            this.test_wyniki.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.obliczeniaToolStripMenuItem,
            this.testToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(355, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // obliczeniaToolStripMenuItem
            // 
            this.obliczeniaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.energiaToolStripMenuItem,
            this.ruchJednostajnyToolStripMenuItem});
            this.obliczeniaToolStripMenuItem.Name = "obliczeniaToolStripMenuItem";
            this.obliczeniaToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.obliczeniaToolStripMenuItem.Text = "Obliczenia";
            // 
            // energiaToolStripMenuItem
            // 
            this.energiaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.potencjalnaToolStripMenuItem,
            this.kinetycznaToolStripMenuItem});
            this.energiaToolStripMenuItem.Name = "energiaToolStripMenuItem";
            this.energiaToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.energiaToolStripMenuItem.Text = "Energia";
            // 
            // potencjalnaToolStripMenuItem
            // 
            this.potencjalnaToolStripMenuItem.Name = "potencjalnaToolStripMenuItem";
            this.potencjalnaToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.potencjalnaToolStripMenuItem.Text = "Potencjalna";
            this.potencjalnaToolStripMenuItem.Click += new System.EventHandler(this.potencjalnaToolStripMenuItem_Click);
            // 
            // kinetycznaToolStripMenuItem
            // 
            this.kinetycznaToolStripMenuItem.Name = "kinetycznaToolStripMenuItem";
            this.kinetycznaToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.kinetycznaToolStripMenuItem.Text = "Kinetyczna";
            this.kinetycznaToolStripMenuItem.Click += new System.EventHandler(this.kinetycznaToolStripMenuItem_Click);
            // 
            // ruchJednostajnyToolStripMenuItem
            // 
            this.ruchJednostajnyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prędkośćToolStripMenuItem,
            this.drogaToolStripMenuItem,
            this.czasToolStripMenuItem});
            this.ruchJednostajnyToolStripMenuItem.Name = "ruchJednostajnyToolStripMenuItem";
            this.ruchJednostajnyToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.ruchJednostajnyToolStripMenuItem.Text = "Ruch Jednostajny Prostoliniowy";
            // 
            // prędkośćToolStripMenuItem
            // 
            this.prędkośćToolStripMenuItem.Name = "prędkośćToolStripMenuItem";
            this.prędkośćToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.prędkośćToolStripMenuItem.Text = "Prędkość";
            this.prędkośćToolStripMenuItem.Click += new System.EventHandler(this.prędkośćToolStripMenuItem_Click);
            // 
            // drogaToolStripMenuItem
            // 
            this.drogaToolStripMenuItem.Name = "drogaToolStripMenuItem";
            this.drogaToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.drogaToolStripMenuItem.Text = "Droga";
            this.drogaToolStripMenuItem.Click += new System.EventHandler(this.drogaToolStripMenuItem_Click);
            // 
            // czasToolStripMenuItem
            // 
            this.czasToolStripMenuItem.Name = "czasToolStripMenuItem";
            this.czasToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.czasToolStripMenuItem.Text = "Czas";
            this.czasToolStripMenuItem.Click += new System.EventHandler(this.czasToolStripMenuItem_Click);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.testToolStripMenuItem.Text = "Test";
            this.testToolStripMenuItem.Click += new System.EventHandler(this.testToolStripMenuItem_Click);
            // 
            // potential_groupBox
            // 
            this.potential_groupBox.Controls.Add(this.potential);
            this.potential_groupBox.Controls.Add(this.label6);
            this.potential_groupBox.Controls.Add(this.label5);
            this.potential_groupBox.Controls.Add(this.label4);
            this.potential_groupBox.Controls.Add(this.potential_textBox);
            this.potential_groupBox.Controls.Add(this.label3);
            this.potential_groupBox.Controls.Add(this.height_textBox);
            this.potential_groupBox.Controls.Add(this.mass_textBox);
            this.potential_groupBox.Controls.Add(this.label2);
            this.potential_groupBox.Controls.Add(this.label1);
            this.potential_groupBox.Location = new System.Drawing.Point(13, 28);
            this.potential_groupBox.Name = "potential_groupBox";
            this.potential_groupBox.Size = new System.Drawing.Size(263, 149);
            this.potential_groupBox.TabIndex = 1;
            this.potential_groupBox.TabStop = false;
            this.potential_groupBox.Text = "Energia Potencjalna";
            this.potential_groupBox.Visible = false;
            // 
            // potential
            // 
            this.potential.Location = new System.Drawing.Point(76, 66);
            this.potential.Name = "potential";
            this.potential.Size = new System.Drawing.Size(75, 23);
            this.potential.TabIndex = 9;
            this.potential.Text = "Oblicz";
            this.potential.UseVisualStyleBackColor = true;
            this.potential.Click += new System.EventHandler(this.potencjalna_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(245, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "J";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(151, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "m";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(151, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "kg";
            // 
            // potential_textBox
            // 
            this.potential_textBox.Location = new System.Drawing.Point(76, 95);
            this.potential_textBox.Name = "potential_textBox";
            this.potential_textBox.ReadOnly = true;
            this.potential_textBox.Size = new System.Drawing.Size(163, 20);
            this.potential_textBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "wynik";
            // 
            // height_textBox
            // 
            this.height_textBox.Location = new System.Drawing.Point(76, 40);
            this.height_textBox.Name = "height_textBox";
            this.height_textBox.Size = new System.Drawing.Size(78, 20);
            this.height_textBox.TabIndex = 3;
            // 
            // mass_textBox
            // 
            this.mass_textBox.Location = new System.Drawing.Point(76, 17);
            this.mass_textBox.Name = "mass_textBox";
            this.mass_textBox.Size = new System.Drawing.Size(78, 20);
            this.mass_textBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Wysokość:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Masa ciała:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Masa ciała:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 43);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Prędkość:";
            // 
            // mass_textBox2
            // 
            this.mass_textBox2.Location = new System.Drawing.Point(76, 17);
            this.mass_textBox2.Name = "mass_textBox2";
            this.mass_textBox2.Size = new System.Drawing.Size(78, 20);
            this.mass_textBox2.TabIndex = 2;
            // 
            // velocity_textBox
            // 
            this.velocity_textBox.Location = new System.Drawing.Point(76, 40);
            this.velocity_textBox.Name = "velocity_textBox";
            this.velocity_textBox.Size = new System.Drawing.Size(78, 20);
            this.velocity_textBox.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 98);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "wynik";
            // 
            // kinetic_textBox
            // 
            this.kinetic_textBox.Location = new System.Drawing.Point(76, 95);
            this.kinetic_textBox.Name = "kinetic_textBox";
            this.kinetic_textBox.ReadOnly = true;
            this.kinetic_textBox.Size = new System.Drawing.Size(100, 20);
            this.kinetic_textBox.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(151, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "kg";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(151, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "m/s";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(173, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(12, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "J";
            // 
            // kinetyczna
            // 
            this.kinetyczna.Location = new System.Drawing.Point(76, 66);
            this.kinetyczna.Name = "kinetyczna";
            this.kinetyczna.Size = new System.Drawing.Size(75, 23);
            this.kinetyczna.TabIndex = 9;
            this.kinetyczna.Text = "Oblicz";
            this.kinetyczna.UseVisualStyleBackColor = true;
            this.kinetyczna.Click += new System.EventHandler(this.kinetyczna_Click);
            // 
            // kinetic_groupBox
            // 
            this.kinetic_groupBox.Controls.Add(this.kinetyczna);
            this.kinetic_groupBox.Controls.Add(this.label8);
            this.kinetic_groupBox.Controls.Add(this.label9);
            this.kinetic_groupBox.Controls.Add(this.label10);
            this.kinetic_groupBox.Controls.Add(this.kinetic_textBox);
            this.kinetic_groupBox.Controls.Add(this.label11);
            this.kinetic_groupBox.Controls.Add(this.velocity_textBox);
            this.kinetic_groupBox.Controls.Add(this.mass_textBox2);
            this.kinetic_groupBox.Controls.Add(this.label12);
            this.kinetic_groupBox.Controls.Add(this.label13);
            this.kinetic_groupBox.Location = new System.Drawing.Point(12, 28);
            this.kinetic_groupBox.Name = "kinetic_groupBox";
            this.kinetic_groupBox.Size = new System.Drawing.Size(263, 149);
            this.kinetic_groupBox.TabIndex = 10;
            this.kinetic_groupBox.TabStop = false;
            this.kinetic_groupBox.Text = "Energia Kinetyczna";
            this.kinetic_groupBox.Visible = false;
            // 
            // jednostajny_groupBox
            // 
            this.jednostajny_groupBox.Controls.Add(this.rjp);
            this.jednostajny_groupBox.Controls.Add(this.rjp_wynik_label);
            this.jednostajny_groupBox.Controls.Add(this.rjp_b_label);
            this.jednostajny_groupBox.Controls.Add(this.rjp_a_label);
            this.jednostajny_groupBox.Controls.Add(this.rjp_wynik_textBox);
            this.jednostajny_groupBox.Controls.Add(this.rjp_wynik);
            this.jednostajny_groupBox.Controls.Add(this.rjp_textBox2);
            this.jednostajny_groupBox.Controls.Add(this.rjp_textBox1);
            this.jednostajny_groupBox.Controls.Add(this.rjp_b);
            this.jednostajny_groupBox.Controls.Add(this.rjp_a);
            this.jednostajny_groupBox.Location = new System.Drawing.Point(12, 28);
            this.jednostajny_groupBox.Name = "jednostajny_groupBox";
            this.jednostajny_groupBox.Size = new System.Drawing.Size(263, 149);
            this.jednostajny_groupBox.TabIndex = 11;
            this.jednostajny_groupBox.TabStop = false;
            this.jednostajny_groupBox.Text = "Ruch jednostajny prostoliniowy";
            this.jednostajny_groupBox.Visible = false;
            // 
            // rjp
            // 
            this.rjp.Location = new System.Drawing.Point(76, 66);
            this.rjp.Name = "rjp";
            this.rjp.Size = new System.Drawing.Size(75, 23);
            this.rjp.TabIndex = 9;
            this.rjp.Text = "Oblicz";
            this.rjp.UseVisualStyleBackColor = true;
            this.rjp.Click += new System.EventHandler(this.rjp_Click);
            // 
            // rjp_wynik_label
            // 
            this.rjp_wynik_label.AutoSize = true;
            this.rjp_wynik_label.Location = new System.Drawing.Point(173, 98);
            this.rjp_wynik_label.Name = "rjp_wynik_label";
            this.rjp_wynik_label.Size = new System.Drawing.Size(12, 13);
            this.rjp_wynik_label.TabIndex = 8;
            this.rjp_wynik_label.Text = "J";
            // 
            // rjp_b_label
            // 
            this.rjp_b_label.AutoSize = true;
            this.rjp_b_label.Location = new System.Drawing.Point(151, 43);
            this.rjp_b_label.Name = "rjp_b_label";
            this.rjp_b_label.Size = new System.Drawing.Size(25, 13);
            this.rjp_b_label.TabIndex = 7;
            this.rjp_b_label.Text = "m/s";
            // 
            // rjp_a_label
            // 
            this.rjp_a_label.AutoSize = true;
            this.rjp_a_label.Location = new System.Drawing.Point(151, 20);
            this.rjp_a_label.Name = "rjp_a_label";
            this.rjp_a_label.Size = new System.Drawing.Size(19, 13);
            this.rjp_a_label.TabIndex = 6;
            this.rjp_a_label.Text = "kg";
            // 
            // rjp_wynik_textBox
            // 
            this.rjp_wynik_textBox.Location = new System.Drawing.Point(76, 95);
            this.rjp_wynik_textBox.Name = "rjp_wynik_textBox";
            this.rjp_wynik_textBox.ReadOnly = true;
            this.rjp_wynik_textBox.Size = new System.Drawing.Size(100, 20);
            this.rjp_wynik_textBox.TabIndex = 5;
            // 
            // rjp_wynik
            // 
            this.rjp_wynik.AutoSize = true;
            this.rjp_wynik.Location = new System.Drawing.Point(10, 98);
            this.rjp_wynik.Name = "rjp_wynik";
            this.rjp_wynik.Size = new System.Drawing.Size(52, 13);
            this.rjp_wynik.TabIndex = 4;
            this.rjp_wynik.Text = "Prędkość";
            // 
            // rjp_textBox2
            // 
            this.rjp_textBox2.Location = new System.Drawing.Point(76, 40);
            this.rjp_textBox2.Name = "rjp_textBox2";
            this.rjp_textBox2.Size = new System.Drawing.Size(78, 20);
            this.rjp_textBox2.TabIndex = 3;
            // 
            // rjp_textBox1
            // 
            this.rjp_textBox1.Location = new System.Drawing.Point(76, 17);
            this.rjp_textBox1.Name = "rjp_textBox1";
            this.rjp_textBox1.Size = new System.Drawing.Size(78, 20);
            this.rjp_textBox1.TabIndex = 2;
            // 
            // rjp_b
            // 
            this.rjp_b.AutoSize = true;
            this.rjp_b.Location = new System.Drawing.Point(7, 43);
            this.rjp_b.Name = "rjp_b";
            this.rjp_b.Size = new System.Drawing.Size(39, 13);
            this.rjp_b.TabIndex = 1;
            this.rjp_b.Text = "Droga:";
            // 
            // rjp_a
            // 
            this.rjp_a.AutoSize = true;
            this.rjp_a.Location = new System.Drawing.Point(7, 20);
            this.rjp_a.Name = "rjp_a";
            this.rjp_a.Size = new System.Drawing.Size(33, 13);
            this.rjp_a.TabIndex = 0;
            this.rjp_a.Text = "Czas:";
            // 
            // test_wyniki
            // 
            this.test_wyniki.Controls.Add(this.wynik_textBox);
            this.test_wyniki.Controls.Add(this.search);
            this.test_wyniki.Controls.Add(this.label7);
            this.test_wyniki.Controls.Add(this.nazwisko_textBox);
            this.test_wyniki.Location = new System.Drawing.Point(13, 205);
            this.test_wyniki.Name = "test_wyniki";
            this.test_wyniki.Size = new System.Drawing.Size(263, 107);
            this.test_wyniki.TabIndex = 13;
            this.test_wyniki.TabStop = false;
            this.test_wyniki.Text = "Wyniki";
            this.test_wyniki.Visible = false;
            // 
            // nazwisko_textBox
            // 
            this.nazwisko_textBox.Location = new System.Drawing.Point(157, 19);
            this.nazwisko_textBox.Name = "nazwisko_textBox";
            this.nazwisko_textBox.Size = new System.Drawing.Size(100, 20);
            this.nazwisko_textBox.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoEllipsis = true;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Wyszukaj nazwisko:";
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(157, 45);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 2;
            this.search.Text = "Szukaj";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // wynik_textBox
            // 
            this.wynik_textBox.Location = new System.Drawing.Point(18, 74);
            this.wynik_textBox.Name = "wynik_textBox";
            this.wynik_textBox.ReadOnly = true;
            this.wynik_textBox.Size = new System.Drawing.Size(239, 20);
            this.wynik_textBox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 380);
            this.Controls.Add(this.test_wyniki);
            this.Controls.Add(this.jednostajny_groupBox);
            this.Controls.Add(this.kinetic_groupBox);
            this.Controls.Add(this.potential_groupBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Fizyka";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.potential_groupBox.ResumeLayout(false);
            this.potential_groupBox.PerformLayout();
            this.kinetic_groupBox.ResumeLayout(false);
            this.kinetic_groupBox.PerformLayout();
            this.jednostajny_groupBox.ResumeLayout(false);
            this.jednostajny_groupBox.PerformLayout();
            this.test_wyniki.ResumeLayout(false);
            this.test_wyniki.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem obliczeniaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem energiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem potencjalnaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kinetycznaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ruchJednostajnyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prędkośćToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drogaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem czasToolStripMenuItem;
        private System.Windows.Forms.GroupBox potential_groupBox;
        private System.Windows.Forms.TextBox height_textBox;
        private System.Windows.Forms.TextBox mass_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox potential_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button potential;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox mass_textBox2;
        private System.Windows.Forms.TextBox velocity_textBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox kinetic_textBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button kinetyczna;
        private System.Windows.Forms.GroupBox kinetic_groupBox;
        private System.Windows.Forms.GroupBox jednostajny_groupBox;
        private System.Windows.Forms.Button rjp;
        private System.Windows.Forms.Label rjp_wynik_label;
        private System.Windows.Forms.Label rjp_b_label;
        private System.Windows.Forms.Label rjp_a_label;
        private System.Windows.Forms.TextBox rjp_wynik_textBox;
        private System.Windows.Forms.Label rjp_wynik;
        private System.Windows.Forms.TextBox rjp_textBox2;
        private System.Windows.Forms.TextBox rjp_textBox1;
        private System.Windows.Forms.Label rjp_b;
        private System.Windows.Forms.Label rjp_a;
        private System.Windows.Forms.GroupBox test_wyniki;
        private System.Windows.Forms.TextBox wynik_textBox;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox nazwisko_textBox;
    }
}

