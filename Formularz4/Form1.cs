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

namespace Formularz4
{
    public partial class Form1 : Form
    {
        private readonly float g = 9.81f;
        private int ruchChoice;
        public Form1()
        {
            InitializeComponent();
        }

        private void potencjalnaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            potential_groupBox.Visible = true;
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

        private void obliczeniaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void kinetycznaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            potential_groupBox.Visible = false;
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
        
    }
}
