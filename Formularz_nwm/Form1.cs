using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Formularz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ankietaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox_ankieta.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_nazwisko.Text.ToString())) {
                MessageBox.Show("Nie wpisano swojego nazwiska!", "Błąd przy wypełnianiu");
                return;
            }
            string nazwisko = textBox_nazwisko.Text;
            string wiek;
            if (radioButton1.Checked){
                wiek = radioButton1.Text;
            }else if(radioButton2.Checked){ 
                wiek = radioButton2.Text; 
            }else if(radioButton3.Checked){ 
                wiek = radioButton3.Text;
            }else{
                MessageBox.Show("Nie wybrano swojego wieku!", "Błąd przy wypełnianiu");
                return;
            }
            string hobby = "";
            foreach (var item in listBox1.SelectedItems)
            {
                hobby += item.ToString() + ", ";
            }
            var path = "../../daneAnkiety.txt";
            string formatedInfo = ("Nazwisko: " + nazwisko + " | Wiek: " + wiek + " | Hobby: " + hobby);
            File.AppendAllText(path,formatedInfo+'\n');
            MessageBox.Show(formatedInfo,"Podane dane do ankiety");
        }

        private void hasłoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            var path = "../../haslo.txt";
            string value = File.ReadAllText(path);
            if(!int.TryParse(value,out int l))
            {
                return;
            }
            string capitalLetters = "ABCDEFGHIJKLMNOPQRSTVWUXYZ";
            string smallLetters = "abcdefgijklmnopqrstvwuxyz";
            string specialCharacters = "!@#$%^&*()_+-=?";
            string password = "";
            for (int i = 0; i < l; i++)
            {
                if (i == 0)
                {
                    password += capitalLetters[rand.Next(capitalLetters.Length - 1)];
                }
                else if (i == l - 1) {
                    password += specialCharacters[rand.Next(specialCharacters.Length - 1)];
                }
                else
                {
                    password += smallLetters[rand.Next(smallLetters.Length - 1)];
                }
            }
            MessageBox.Show(password, "Hasło");
        }
    }
}
