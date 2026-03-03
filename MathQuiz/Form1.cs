using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace MathQuiz
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        int addend1, addend2;
        int minuend, subtrahend;
        int multiplicand, multiplier;
        int dividend, divisor;
        int timeLeft;

        bool[] answers = new bool[4];

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (checkAnswers())
            {
                timer1.Stop();
                MessageBox.Show("You got all the answers right!",
                        "Congratulations!");
                startQuizButton.Enabled = true;
                timeLabel.BackColor = default;
            }
            else if (timeLeft > 0)
            {
                // If CheckTheAnswer() returns false, keep counting
                // down. Decrease the time left by one second and 
                // display the new time left by updating the 
                // Time Left label.
                timeLeft = timeLeft - 1;
                timeLabel.Text = timeLeft + " seconds";
                if (timeLeft <= 5)
                {
                    timeLabel.BackColor = Color.Red;
                }
            }
            else
            {
                // If the user ran out of time, stop the timer, show
                // a MessageBox, and fill in the answers.
                timer1.Stop();
                timeLabel.Text = "Time's up!";
                MessageBox.Show("You didn't finish in time.", "Sorry!");
                answer1.Value = addend1 + addend2;
                answer2.Value = minuend - subtrahend;
                answer3.Value = multiplicand * multiplier;
                answer4.Value = dividend / divisor;
                startQuizButton.Enabled = true;
                timeLabel.BackColor = default;
            }
        }

        void startQuiz()
        {
            addend1 = rand.Next(51);
            addend2 = rand.Next(51);

            plusLeftLabel.Text = addend1.ToString();
            plusRightLabel.Text = addend2.ToString();
            answer1.Value = 0;

            minuend = rand.Next(1,101);
            subtrahend = rand.Next(1, minuend);
        
            minusLeftLabel.Text = minuend.ToString();
            minusRightLabel.Text = subtrahend.ToString();
            answer2.Value = 0;


            multiplicand = rand.Next(2, 11);
            multiplier = rand.Next(2, 11);

            multiplierLeftLabel.Text = multiplicand.ToString();
            multiplierRightLabel.Text = multiplier.ToString();
            answer3.Value = 0;


            divisor = rand.Next(2, 11);
            int temporaryQuotient = rand.Next(2, 11);
            dividend = divisor * temporaryQuotient;

            divideLeftLabel.Text = dividend.ToString();
            divideRightLabel.Text = divisor.ToString();
            answer4.Value = 0;


            timeLeft = 20;
            timeLabel.Text = "20 seconds";
            timer1.Start();
        }

        public bool checkAnswers()
        {
            if ((addend1 + addend2 == answer1.Value)
        && (minuend - subtrahend == answer2.Value)
        && (multiplicand * multiplier == answer3.Value)
        && (dividend / divisor == answer4.Value))
                return true;
            else
                return false;
        }
       
        private void startQuiz_Click(object sender, EventArgs e)
        {
            startQuiz();
            startQuizButton.Enabled = false;
        }

    }
}
