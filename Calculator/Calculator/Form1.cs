using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private float suma;
        private bool dzialaniaJednocyfrowe = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void listaDzialanJednocyfrowych()
        {
            przycisk_dodawanie.Visible = false;
            przycisk_odejmowanie.Visible = false;
            przycisk_mnozenie.Visible = false;
            przycisk_dzielenie.Visible = false;
            przycisk_nwd.Visible = false;
            przycisk_potega.Visible = false;

            przycisk_sumaCyfr.Visible = true;
            przycisk_silnia.Visible = true;
            przycisk_DecToBin.Visible = true;
            przycisk_DecToHex.Visible = true;

            liczbaB.Visible = false;
            liczbaB.Text = "";
            label3.Visible = false;
        }

        private void listaDzialanDwucyfrowych()
        {
            przycisk_dodawanie.Visible = true;
            przycisk_odejmowanie.Visible = true;
            przycisk_mnozenie.Visible = true;
            przycisk_dzielenie.Visible = true;
            przycisk_nwd.Visible = true;
            przycisk_potega.Visible = true;

            przycisk_sumaCyfr.Visible = false;
            przycisk_silnia.Visible = false;
            przycisk_DecToBin.Visible = false;
            przycisk_DecToHex.Visible = false;

            liczbaB.Visible = true;
            label3.Visible = true;
        }
        private void przycisk_zmienListeDzialan_Click(object sender, EventArgs e)
        {
            if (dzialaniaJednocyfrowe)
            {
                dzialaniaJednocyfrowe = false;
                listaDzialanDwucyfrowych();
            }
            else
            {
                dzialaniaJednocyfrowe = true;
                listaDzialanJednocyfrowych();
            }
        }

        private void przycisk_dodawanie_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(liczbaA.Text) && !String.IsNullOrEmpty(liczbaB.Text))
            {
                float? x = float.Parse(liczbaA.Text.Replace('.', ','));
                float? y = float.Parse(liczbaB.Text.Replace('.', ','));

                wynik.Text = (x + y).ToString();
            }
        }

        private void przycisk_odejmowanie_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(liczbaA.Text) && !String.IsNullOrEmpty(liczbaB.Text))
            {
                float x = float.Parse(liczbaA.Text.Replace('.', ','));
                float y = float.Parse(liczbaB.Text.Replace('.', ','));

                wynik.Text = (x - y).ToString();
            }
        }

        private void przycisk_mnozenie_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(liczbaA.Text) && !String.IsNullOrEmpty(liczbaB.Text))
            {
                float x = float.Parse(liczbaA.Text.Replace('.', ','));
                float y = float.Parse(liczbaB.Text.Replace('.', ','));

                wynik.Text = (x * y).ToString();
            }
        }

        private void przycisk_dzielenie_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(liczbaA.Text) && !String.IsNullOrEmpty(liczbaB.Text))
            {
                float x = float.Parse(liczbaA.Text.Replace('.', ','));
                float y = float.Parse(liczbaB.Text.Replace('.', ','));
                if (y == 0)
                {
                    wynik.Text = "Nie dzielimy przez zero!";
                }
                else
                {
                    wynik.Text = (x / y).ToString();
                }
            }   
        }

        private void przycisk_nwd_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(liczbaA.Text) && !String.IsNullOrEmpty(liczbaB.Text))
            {
                int x = (int)Math.Round(float.Parse(liczbaA.Text.Replace('.', ',')));
                int y = (int)Math.Round(float.Parse(liczbaB.Text.Replace('.', ',')));

                while (x != y)
                {
                    if (x > y)
                    {
                        x -= y;
                    }
                    else
                    {
                        y -= x;
                    }
                }
                wynik.Text = x.ToString();
            }
        }

        private void przycisk_sumaCyfr_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(liczbaA.Text))
            {
                int x = (int)Math.Round(float.Parse(liczbaA.Text.Replace('.', ',')));
                int temp = 0;
                if (x >= 0)
                {
                    suma = 0;
                    while (x >= temp)
                    {
                        suma += temp;
                        temp++;
                    }
                    wynik.Text = ((int)suma).ToString();
                }
            } 
        }
        private void przycisk_potega_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(liczbaA.Text) && !String.IsNullOrEmpty(liczbaB.Text))
            {
                float x = float.Parse(liczbaA.Text.Replace('.', ','));
                int y = (int)Math.Round(float.Parse(liczbaB.Text.Replace('.', ',')));

                suma = (float)Math.Pow(x,y);
                wynik.Text = suma.ToString();
            }
        }

        private void przycisk_silnia_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(liczbaA.Text))
            {
                int x = (int)Math.Round(float.Parse(liczbaA.Text.Replace('.', ',')));
                int temp = 1;
                if (x >= 0)
                {
                    suma = 1;
                    while (x >= temp)
                    {
                        suma *= temp;
                        temp++;
                    }
                    wynik.Text = ((int)suma).ToString();
                }
            }
        }

        private void przycisk_DecToHex_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(liczbaA.Text))
            {
                int x = (int)Math.Round(float.Parse(liczbaA.Text.Replace('.', ',')));

                wynik.Text = Convert.ToString(x, 16);
            }
        }

        private void przycisk_DecToBin_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(liczbaA.Text))
            {
                int x = (int)Math.Round(float.Parse(liczbaA.Text.Replace('.', ',')));

                wynik.Text = Convert.ToString(x, 2);
            }
        }
    }
}
