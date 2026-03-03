using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace spr03._03._2026
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hasoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int passLength = Int16.Parse(File.ReadAllText("../../haslo.txt"));
            string letters = "qwertyuiopasdfghjklzxcvbnm",
                   numbers = "1234567890",
                   special = "!@#$%^&*()_+<>?",
                   password = "";
            Random rnd = new Random();
            for (int i = 0; i < passLength; i++)
            {
                if (i == 0)
                    password += letters[rnd.Next(letters.Length)].ToString().ToUpper();
                else if (i == 1)
                    password += numbers[rnd.Next(numbers.Length)];
                else if (i == 2)
                    password += special[rnd.Next(special.Length)];
                else
                    password += letters[rnd.Next(letters.Length)];
            }
            MessageBox.Show(password);
        }

        private void daneOsoboweToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nazwisko = textBox1.Text;
            string uczelnia = listBox2.SelectedItem.ToString();
            string tryb = "";
            if (radioButton1.Checked)
                tryb = radioButton1.Text;
            else tryb = radioButton2.Text;
            MessageBox.Show(String.Format("Nazwisko: {0}\nUczelnia: {1}\nTryb Studiowania: {2}",
                nazwisko,uczelnia,tryb));

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string path = "../../dane_studenta.txt";
            
            string nazwisko = textBox1.Text;
            string uczelnia = listBox1.SelectedItem.ToString();
            string tryb = "";
            if (radioButton1.Checked)
                tryb = radioButton1.Text;
            else tryb = radioButton2.Text;
            string toWrite = string.Format("Nazwisko: {0} | Uczelnia: {1} | Tryb Studiowania: {2}\n",
                nazwisko, uczelnia, tryb);

            File.AppendAllText(path, toWrite);
        }

        private void inneInformacjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string jezyki = "",
                    hobby = "";
            foreach (var item in listBox1.SelectedItems)
            {
                jezyki += item.ToString()+", ";
            }
            foreach (var item in checkedListBox1.CheckedItems)
            {
                hobby += item.ToString() + ", ";
            }
            MessageBox.Show(string.Format("Znane języki: {0}\nHobby: {1}",jezyki,hobby));
        }
    }
}
