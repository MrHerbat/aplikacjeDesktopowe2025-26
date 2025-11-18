using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_accept_Click(object sender, EventArgs e)
        {
            string hobby="",jezyki="",plec="";
            foreach (var item in checkedList_hobby.CheckedItems)
            {
                hobby += item.ToString() + ", ";
            }
            foreach (var item in checkedList_jezyki.CheckedItems)
            {
                jezyki += item.ToString() + ", ";
            }
            if (radioButton_k.Checked)
            {
                plec = "Kobieta";
            }else if (radioButton_m.Checked)
            {
                plec = "Mężczyzna";
            }
            string formated = string.Format("Nazwisko: {0}\nWiek: {1} lat/lata\nPłeć: {2}\n{3}",
                textBox_nazwisko.Text,
                textBox_wiek.Text,
                plec,
                checkBox1.Checked ? "Student" : "");
            textBox1.Text = formated;
            textBox_hobby.Text = hobby;
            textBox_jezyki.Text = jezyki;
        }
    }
}
