using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularz3
{
    public partial class Form1 : Form
    {
        string password = "";

        private void complete_button_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(firstName_textBox.Text)
                || string.IsNullOrEmpty(surname_textBox.Text)
                || string.IsNullOrEmpty(position_comboBox.SelectedText))
            {
                return;
            }
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Nie wygenerowano hasła!");
                return;
            }
            MessageBox.Show("Dane pracownika" + firstName_textBox.Text + " "
                + surname_textBox.Text + " "
                + position_comboBox.SelectedText + " Hasło: " +
                password);
                
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void generatePass_button_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(passLength_textBox.Text))
                return;
            var n = int.TryParse(passLength_textBox.Text, out int passLength);
            if(!n)
                return;
            string letters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ",
                    numbers = "1234567890",
                    special = "!@#$%^&*()_+-=",
                    rollPool = "";

            bool lettersAllowed = letters_checkBox.Checked, 
                numAllowed = numbers_checkBox.Checked, 
                specialAllowed = specialCharacters_checkBox.Checked;

            if (lettersAllowed)
                rollPool += letters;
            if (numAllowed)
                rollPool += numbers;
            if (specialAllowed)
                rollPool += special;

            Random rand = new Random();
            if (passLength > 3)
            {
                for (int i = 0; i < passLength; i++)
                {
                    if (i == 0 && numAllowed)
                    {
                        password += numbers[rand.Next(0, numbers.Length)];
                    }
                    else if (i == passLength - 1 && specialAllowed)
                    {
                        password += special[rand.Next(0, special.Length)];
                    }
                    else
                    {
                        password += rollPool[rand.Next(0, rollPool.Length)];
                    }  
                }
                MessageBox.Show(password);
            }
            else
            {
                MessageBox.Show("Za krótkie hasło");
            }
            
        }
    }
}
