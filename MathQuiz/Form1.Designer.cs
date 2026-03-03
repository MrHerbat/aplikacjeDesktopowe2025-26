namespace MathQuiz
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.plusLeftLabel = new System.Windows.Forms.Label();
            this.plusRightLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.answer1 = new System.Windows.Forms.NumericUpDown();
            this.answer2 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.minusRightLabel = new System.Windows.Forms.Label();
            this.minusLeftLabel = new System.Windows.Forms.Label();
            this.answer3 = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.multiplierRightLabel = new System.Windows.Forms.Label();
            this.multiplierLeftLabel = new System.Windows.Forms.Label();
            this.answer4 = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.divideRightLabel = new System.Windows.Forms.Label();
            this.divideLeftLabel = new System.Windows.Forms.Label();
            this.startQuizButton = new System.Windows.Forms.Button();
            this.timeLabel = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.answer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.answer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.answer3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.answer4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(216, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Time Left: ";
            // 
            // plusLeftLabel
            // 
            this.plusLeftLabel.AutoSize = true;
            this.plusLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.plusLeftLabel.Location = new System.Drawing.Point(155, 107);
            this.plusLeftLabel.Name = "plusLeftLabel";
            this.plusLeftLabel.Size = new System.Drawing.Size(25, 29);
            this.plusLeftLabel.TabIndex = 2;
            this.plusLeftLabel.Text = "?";
            // 
            // plusRightLabel
            // 
            this.plusRightLabel.AutoSize = true;
            this.plusRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.plusRightLabel.Location = new System.Drawing.Point(288, 107);
            this.plusRightLabel.Name = "plusRightLabel";
            this.plusRightLabel.Size = new System.Drawing.Size(25, 29);
            this.plusRightLabel.TabIndex = 3;
            this.plusRightLabel.Text = "?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label3.Location = new System.Drawing.Point(212, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "+";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label4.Location = new System.Drawing.Point(359, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "=";
            // 
            // answer1
            // 
            this.answer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.answer1.Location = new System.Drawing.Point(413, 105);
            this.answer1.Name = "answer1";
            this.answer1.Size = new System.Drawing.Size(100, 35);
            this.answer1.TabIndex = 6;
            // 
            // answer2
            // 
            this.answer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.answer2.Location = new System.Drawing.Point(413, 146);
            this.answer2.Name = "answer2";
            this.answer2.Size = new System.Drawing.Size(100, 35);
            this.answer2.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label5.Location = new System.Drawing.Point(359, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "=";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label6.Location = new System.Drawing.Point(212, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 29);
            this.label6.TabIndex = 9;
            this.label6.Text = "-";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // minusRightLabel
            // 
            this.minusRightLabel.AutoSize = true;
            this.minusRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.minusRightLabel.Location = new System.Drawing.Point(288, 148);
            this.minusRightLabel.Name = "minusRightLabel";
            this.minusRightLabel.Size = new System.Drawing.Size(25, 29);
            this.minusRightLabel.TabIndex = 8;
            this.minusRightLabel.Text = "?";
            // 
            // minusLeftLabel
            // 
            this.minusLeftLabel.AutoSize = true;
            this.minusLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.minusLeftLabel.Location = new System.Drawing.Point(155, 148);
            this.minusLeftLabel.Name = "minusLeftLabel";
            this.minusLeftLabel.Size = new System.Drawing.Size(25, 29);
            this.minusLeftLabel.TabIndex = 7;
            this.minusLeftLabel.Text = "?";
            // 
            // answer3
            // 
            this.answer3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.answer3.Location = new System.Drawing.Point(413, 187);
            this.answer3.Name = "answer3";
            this.answer3.Size = new System.Drawing.Size(100, 35);
            this.answer3.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label9.Location = new System.Drawing.Point(359, 189);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 29);
            this.label9.TabIndex = 15;
            this.label9.Text = "=";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label10.Location = new System.Drawing.Point(212, 189);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 29);
            this.label10.TabIndex = 14;
            this.label10.Text = "×";
            // 
            // multiplierRightLabel
            // 
            this.multiplierRightLabel.AutoSize = true;
            this.multiplierRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.multiplierRightLabel.Location = new System.Drawing.Point(288, 189);
            this.multiplierRightLabel.Name = "multiplierRightLabel";
            this.multiplierRightLabel.Size = new System.Drawing.Size(25, 29);
            this.multiplierRightLabel.TabIndex = 13;
            this.multiplierRightLabel.Text = "?";
            // 
            // multiplierLeftLabel
            // 
            this.multiplierLeftLabel.AutoSize = true;
            this.multiplierLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.multiplierLeftLabel.Location = new System.Drawing.Point(155, 189);
            this.multiplierLeftLabel.Name = "multiplierLeftLabel";
            this.multiplierLeftLabel.Size = new System.Drawing.Size(25, 29);
            this.multiplierLeftLabel.TabIndex = 12;
            this.multiplierLeftLabel.Text = "?";
            // 
            // answer4
            // 
            this.answer4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.answer4.Location = new System.Drawing.Point(413, 228);
            this.answer4.Name = "answer4";
            this.answer4.Size = new System.Drawing.Size(100, 35);
            this.answer4.TabIndex = 21;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label13.Location = new System.Drawing.Point(359, 230);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(27, 29);
            this.label13.TabIndex = 20;
            this.label13.Text = "=";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label14.Location = new System.Drawing.Point(212, 230);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(27, 29);
            this.label14.TabIndex = 19;
            this.label14.Text = "÷";
            // 
            // divideRightLabel
            // 
            this.divideRightLabel.AutoSize = true;
            this.divideRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.divideRightLabel.Location = new System.Drawing.Point(288, 230);
            this.divideRightLabel.Name = "divideRightLabel";
            this.divideRightLabel.Size = new System.Drawing.Size(25, 29);
            this.divideRightLabel.TabIndex = 18;
            this.divideRightLabel.Text = "?";
            // 
            // divideLeftLabel
            // 
            this.divideLeftLabel.AutoSize = true;
            this.divideLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.divideLeftLabel.Location = new System.Drawing.Point(155, 230);
            this.divideLeftLabel.Name = "divideLeftLabel";
            this.divideLeftLabel.Size = new System.Drawing.Size(25, 29);
            this.divideLeftLabel.TabIndex = 17;
            this.divideLeftLabel.Text = "?";
            // 
            // startQuizButton
            // 
            this.startQuizButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.startQuizButton.Location = new System.Drawing.Point(222, 291);
            this.startQuizButton.Name = "startQuizButton";
            this.startQuizButton.Size = new System.Drawing.Size(208, 42);
            this.startQuizButton.TabIndex = 22;
            this.startQuizButton.Text = "Start the quiz";
            this.startQuizButton.UseVisualStyleBackColor = true;
            this.startQuizButton.Click += new System.EventHandler(this.startQuiz_Click);
            // 
            // timeLabel
            // 
            this.timeLabel.Enabled = false;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.timeLabel.Location = new System.Drawing.Point(364, 7);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.ReadOnly = true;
            this.timeLabel.Size = new System.Drawing.Size(149, 35);
            this.timeLabel.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 397);
            this.Controls.Add(this.startQuizButton);
            this.Controls.Add(this.answer4);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.divideRightLabel);
            this.Controls.Add(this.divideLeftLabel);
            this.Controls.Add(this.answer3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.multiplierRightLabel);
            this.Controls.Add(this.multiplierLeftLabel);
            this.Controls.Add(this.answer2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.minusRightLabel);
            this.Controls.Add(this.minusLeftLabel);
            this.Controls.Add(this.answer1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.plusRightLabel);
            this.Controls.Add(this.plusLeftLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.answer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.answer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.answer3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.answer4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label plusLeftLabel;
        private System.Windows.Forms.Label plusRightLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown answer1;
        private System.Windows.Forms.NumericUpDown answer2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label minusRightLabel;
        private System.Windows.Forms.Label minusLeftLabel;
        private System.Windows.Forms.NumericUpDown answer3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label multiplierRightLabel;
        private System.Windows.Forms.Label multiplierLeftLabel;
        private System.Windows.Forms.NumericUpDown answer4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label divideRightLabel;
        private System.Windows.Forms.Label divideLeftLabel;
        private System.Windows.Forms.Button startQuizButton;
        private System.Windows.Forms.TextBox timeLabel;
        private System.Windows.Forms.Timer timer1;
    }
}

