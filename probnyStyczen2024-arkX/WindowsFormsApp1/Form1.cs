using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Properties;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = Resources._000_zdjecie;
            pictureBox2.Image = Resources._000_odcisk;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            if (text.Equals("111"))
            {
                pictureBox1.Image = Properties.Resources._111_zdjecie;
                pictureBox2.Image = Properties.Resources._111_odcisk;
            }
            else if (text.Equals("333"))
            {
                pictureBox1.Image = Resources._333_zdjecie;
                pictureBox2.Image = Resources._333_odcisk;
            }
            else if (text.Equals("000"))
            {
                pictureBox1.Image = Resources._000_zdjecie;
                pictureBox2.Image = Resources._000_odcisk;
            }
            else
            {
                pictureBox1.Image = null;
                pictureBox2.Image = null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string imie = textBox2.Text;
            string nazwisko = textBox3.Text;
            string oczy = "";
            if (radioButton1.Checked) {
                oczy = radioButton1.Text;
            }else if (radioButton2.Checked){
                oczy = radioButton2.Text;
            }else if (radioButton3.Checked){
                oczy = radioButton3.Text;
            }
            if(string.IsNullOrWhiteSpace(imie) || string.IsNullOrWhiteSpace(nazwisko)){
                MessageBox.Show("Wprowadź dane");
            }
            else{
                MessageBox.Show(imie + " " + nazwisko + " kolor oczu " + oczy);
            }
        }
    }
}
