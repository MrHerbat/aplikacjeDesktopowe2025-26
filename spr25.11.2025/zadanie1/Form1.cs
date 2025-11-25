using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadanie1
{
    public partial class Form1 : Form
    {
        private int sumaLiczb;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var n1 = int.TryParse(liczba_a.Text, out int a);
            var n2 = int.TryParse(liczba_b.Text, out int b);
            var n3 = int.TryParse(liczba_c.Text, out int c);
            if (!n1 || !n2 || !n3)
                return;
            sumaLiczb = a + b + c;
            suma.Text = sumaLiczb.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(sumaLiczb.ToString()))
                return;
            double n=0;
            if (sumaLiczb < 0){
                kwadrat.Text = "Suma nie jest naturalna";
            }else{
                while (true)
                {
                    if (n * n == sumaLiczb)
                    {
                        kwadrat.Text = "Suma jest kwadratem liczby " + n.ToString();
                        return;
                    }
                    if (n * n > sumaLiczb)
                    {
                        kwadrat.Text = "Suma nie jest kwadratem liczby naturalnej";
                        return;
                    }
                    n++;
                }
            }
        }
    }
}
