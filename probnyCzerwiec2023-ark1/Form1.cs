using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace probnyCzerwiec2023_ark1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = Properties.Resources.pocztowka;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked){
                pictureBox1.Image = Properties.Resources.pocztowka;
                label4.Text = "Cena: 1 zł";
            }else if (radioButton2.Checked){
                pictureBox1.Image = Properties.Resources.list;
                label4.Text = "Cena: 1.5 zł";
            }else if (radioButton3.Checked) {
                pictureBox1.Image = Properties.Resources.paczka;
                label4.Text = "Cena: 10 zł";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string kodPocztowy = textBox2.Text;
            if (kodPocztowy.Length < 6){
                MessageBox.Show("Nieprawidłowa liczba cyfr w kodzie pocztowym");
            }else{
                if (kodPocztowy.All(char.IsDigit)){
                    MessageBox.Show("Dane przesyłki zostały wprowadzone");
                }else {
                    MessageBox.Show("Kod pocztowy powinien składać się z samych cyfr");
                }
            }
        }
    }
}
