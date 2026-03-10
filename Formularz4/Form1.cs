using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace Formularz4
{
    public partial class Form1 : Form
    {
        private readonly float g = 9.81f;
        private int ruchChoice;
        Form2 form = new Form2();
        private int ballY = 50;
        private System.Windows.Forms.Timer animationFallTimer,animationDriveTimer;

        private float blockX = 50f;    
        private float velocity = 0f;  
        private float acceleration = 0.5f; 
        private bool isAnimating = true;
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.Cornsilk;
            redScroll.Value = 255;
            greenScroll.Value = 255;
            blueScroll.Value = 255;
            redValue.Text = redScroll.Value.ToString();
            greenValue.Text = greenScroll.Value.ToString();
            blueValue.Text = blueScroll.Value.ToString();

            animationFallTimer = new System.Windows.Forms.Timer();
            animationFallTimer.Interval = 31;
            animationFallTimer.Tick += AnimationFallTimer_Tick;
            animationDriveTimer = new System.Windows.Forms.Timer();
            animationDriveTimer.Interval = 31;
            animationDriveTimer.Tick += AnimationDriveTimer_Tick;
            panel2.Paint += panel2_Paint;
            panel3.Paint += panel3_Paint;
        }
        private void AnimationFallTimer_Tick(object sender, EventArgs e)
        {
            if (ballY <= 300)
            {
                ballY += 5; 
                panel2.Invalidate(); 
            }
            else
            {
                animationFallTimer.Stop();
            }
        }
        private void AnimationDriveTimer_Tick(object sender, EventArgs e)
        {
            if (!isAnimating) return;

            int midpoint = panel3.Width / 2;
            int targetX = panel3.Width - 60;

            if (blockX < midpoint)
            {
                velocity += acceleration;
            }
            else
            {
                velocity -= acceleration;

                if (velocity < 0.5f) velocity = 0.5f;
            }

            blockX += velocity;

            if (blockX >= targetX)
            {
                blockX = targetX;
                isAnimating = false;
                animationDriveTimer.Stop();
            }

            panel3.Invalidate();
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            g.DrawLine(Pens.Black, 0, 300, 400, 300);

            int ballX = (panel2.Width / 2) - 20;
            g.FillEllipse(Brushes.Blue, ballX, ballY - 45, 40, 40);
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            int blockWidth = 40;
            int yPos = (panel3.Height/2)-(blockWidth/2);

            using (SolidBrush brush = new SolidBrush(Color.RoyalBlue))
            {
                e.Graphics.FillRectangle(brush, (int)blockX, yPos, blockWidth, blockWidth);
            }
        }
        private void graphicButton_Click(object sender, EventArgs e)
        {
            ballY = 50;
            animationFallTimer.Start();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            blockX = 50f;
            isAnimating = true;
            animationDriveTimer.Start();
        }

        private void potencjalnaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            potential_groupBox.Visible = true;
            colorGroupBox.Visible = false;
            kinetic_groupBox.Visible = false;
            jednostajny_groupBox.Visible = false;
        }

        private void potencjalna_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(mass_textBox.Text) || string.IsNullOrWhiteSpace(height_textBox.Text))
                return;
            bool boolM = float.TryParse(mass_textBox.Text.Replace('.', ','), out float m),
                boolH = float.TryParse(height_textBox.Text.Replace('.',','), out float h);
            if (boolM && boolH){
                if(m<0 || h < 0)
                {
                    potential_textBox.Text = "Wartości nie mogą być ujemne";
                }
                else
                {
                    float ep = m * h * g;
                    potential_textBox.Text = ep.ToString();
                }
                    
            }
        }

        private void kinetycznaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            potential_groupBox.Visible = false;
            colorGroupBox.Visible = false;
            kinetic_groupBox.Visible = true;
            jednostajny_groupBox.Visible = false;
        }

        private void kinetyczna_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(mass_textBox2.Text) || string.IsNullOrWhiteSpace(velocity_textBox.Text))
                return;
            bool boolM = float.TryParse(mass_textBox2.Text.Replace('.', ','), out float m),
                boolV = float.TryParse(velocity_textBox.Text.Replace('.', ','), out float v);
            if (boolM && boolV)
            {
                if(v < 0 || m < 0)
                {
                    kinetic_textBox.Text = "Wartości nie mogą być ujemne";
                }
                else
                {
                    float ek = (m * (v * v)) / 2;
                    kinetic_textBox.Text = ek.ToString();
                }
                    
            }
        }

        private void prędkośćToolStripMenuItem_Click(object sender, EventArgs e)
        {
            potential_groupBox.Visible = false;
            kinetic_groupBox.Visible = false;
            colorGroupBox.Visible = false;
            jednostajny_groupBox.Visible = true;
            ruchChoice = 1;
            rjp_a.Text = "Czas:";
            rjp_a_label.Text = "s";
            rjp_b.Text = "Droga:";
            rjp_b_label.Text = "m";
            rjp_wynik.Text = "Prędkość:";
            rjp_wynik_label.Text = "m/s";
        }

        private void drogaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            potential_groupBox.Visible = false;
            kinetic_groupBox.Visible = false;
            jednostajny_groupBox.Visible = true;
            colorGroupBox.Visible = false;
            ruchChoice = 2;
            rjp_a.Text = "Czas:";
            rjp_a_label.Text = "s";
            rjp_b.Text = "Prędkość:";
            rjp_b_label.Text = "m/s";
            rjp_wynik.Text = "Droga:";
            rjp_wynik_label.Text = "m";
        }

        private void czasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            potential_groupBox.Visible = false;
            kinetic_groupBox.Visible = false;
            jednostajny_groupBox.Visible = true;
            colorGroupBox.Visible = false;
            ruchChoice = 3;
            rjp_a.Text = "Prędkość:";
            rjp_a_label.Text = "m/s";
            rjp_b.Text = "Droga:";
            rjp_b_label.Text = "m";
            rjp_wynik.Text = "Czas:";
            rjp_wynik_label.Text = "s";
        }

        private void rjp_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(rjp_textBox1.Text) || string.IsNullOrWhiteSpace(rjp_textBox2.Text))
                return;
            bool boolA = float.TryParse(rjp_textBox1.Text.Replace('.', ','), out float a),
                boolB = float.TryParse(rjp_textBox2.Text.Replace('.', ','), out float b);
            if (boolA && boolB)
            {
                if (a < 0 || b < 0)
                {
                    rjp_wynik_textBox.Text = "Wartości nie mogą być ujemne";
                }
                else
                {
                    float wynik = 0;
                    switch (ruchChoice)
                    {
                        case 1:
                            wynik = b / a;
                            break;
                        case 2:
                            wynik = a*b;
                            break;
                        case 3:
                            wynik = a / b;
                            break;
                        default:
                            break;
                    }
                    rjp_wynik_textBox.Text = wynik.ToString();
                }
            }
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            test_wyniki.Visible = true;
            nazwisko_textBox.Enabled = true;
            search.Enabled = true;
        }

        public void search_Click(object sender, EventArgs e)
        {
            string nazwisko = nazwisko_textBox.Text;
            string found = searchFile(nazwisko);
            if (!string.IsNullOrEmpty(found)){
                wynik_textBox.Text = found;
            }
            else
            {
                wynik_textBox.Text = "Jeszcze nie ukończyłeś testu!";
                Form2 form = new Form2();
                form.surname = nazwisko;
                form.Show();
            }
        }
        public string searchFile(string surname)
        {
            var file = File.OpenRead("../../wyniki.txt");
            var sr = new StreamReader(file);
            string line = sr.ReadLine();
            while (line != null)
            {
                string temp = line.Split(' ')[0];
                if (temp.Equals(surname))
                {
                    wynik_textBox.Text = line;
                    sr.Close();
                    return line;
                }
                line = sr.ReadLine();
            }
            sr.Close();
            return null;
        }

        private void wybórKoloruToolStripMenuItem_Click(object sender, EventArgs e)
        {
            potential_groupBox.Visible = false;
            kinetic_groupBox.Visible = false;
            jednostajny_groupBox.Visible = false;
            colorGroupBox.Visible = true;
            panelColorChange(255,255,255);
        }
        private void scrollValueChanged(object sender, EventArgs e)
        {
            redValue.Text = redScroll.Value.ToString();
            greenValue.Text = greenScroll.Value.ToString();
            blueValue.Text = blueScroll.Value.ToString();
        }
        private void numericValueChanged(object sender, EventArgs e)
        {
            redScroll.Value = Int16.Parse(redValue.Value.ToString());
            greenScroll.Value = Int16.Parse(greenValue.Value.ToString());
            blueScroll.Value = Int16.Parse(blueValue.Value.ToString());
        }
        private void setPanelColor(object sender,EventArgs e)
        {
            panelColorChange(redScroll.Value, greenScroll.Value, blueScroll.Value);
            label14.BackColor = Color.FromArgb(redScroll.Value, greenScroll.Value, blueScroll.Value);
            label14.Text = (redScroll.Value.ToString()+", "+greenScroll.Value.ToString()+", "+blueScroll.Value.ToString());
        }
        private void panelColorChange(int r, int g, int b)
        {
            Color color = Color.FromArgb(r, g, b);
            panel1.BackColor = color;
        }
        
        private void drawRect(int xPos, int yPos, PaintEventArgs e)
        {
            var d = e.Graphics;
            Brush b = new SolidBrush(Color.Black);
            d.FillRectangle(b, new Rectangle(xPos, yPos,40,40));
            b.Dispose();
        }
        private void drawLine(int xPos1, int yPos1,int xPos2, int yPos2, PaintEventArgs e)
        {
            var d = e.Graphics;
            Pen p = new Pen(Color.Black,2);
            d.DrawLine(p, new Point(xPos1, yPos1), new Point(xPos2, yPos2));
        }
        private void drawStaticPanel(object sender, PaintEventArgs e)
        {
            drawRect((panel2.Width/2)-20, 10,e);
            drawLine(0, 300, 400, 300, e);
        }
        private void drawAnimatedPanel(object sender, PaintEventArgs e)
        {
            var d = e.Graphics;
            int height = 50;
            drawRect((panel2.Width / 2) - 20, height-40, e);
            drawLine(0, 300, 400, 300, e);
            d.Clear(Color.White);
            height += 25;
            Thread.Sleep(100);
            panel2.Refresh();
        }

        private void energiaKinetycznaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
        }

        private void energiaPotencjalnaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }
    }
}
