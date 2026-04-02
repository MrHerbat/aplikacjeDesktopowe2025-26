using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularz4
{
    public partial class Form2 : Form
    {
        public static int punkty;
        public string surname;
        public Form2()
        {
            InitializeComponent();
        }

        private void finish_Click(object sender, EventArgs e)
        {
            punkty = 0;
            int zad3Punkty = 0;
            if (zadanie1_comboBox.SelectedIndex == 3)
                punkty += 1;
            if (odpowiedz_c.Checked)
                punkty += 1;
            foreach (var item in zadanie3_checkedListBox.SelectedItems)
            {
                if(item.ToString().Equals("Praca") || item.ToString().Equals("Energia Kinetyczna"))
                {
                    zad3Punkty -= 1;
                }
                else
                {
                    zad3Punkty += 1;
                }
            }
            if (zad3Punkty >= 3)
            {
                punkty += 2;
            }else if (zad3Punkty >= 1)
            {
                punkty += 1;
            }
            if (zadanie4_textBox.Text.Contains("100") && zadanie4_textBox.Text.Contains("J"))
                punkty += 2;

            var path = "../../wyniki.txt";
            int temp = searchFile(surname);
            if (temp!=-1)
            {
                lineChanger(surname + " " + punkty + "pkt", path, temp);
            }
            else
            {
                File.AppendAllText(path, "\n" + surname + " " + punkty + "pkt");
            }
            this.Close();
        }
        static void lineChanger(string newText, string fileName, int line_to_edit)
        {
            string[] arrLine = File.ReadAllLines(fileName);
            arrLine[line_to_edit] = newText;
            File.WriteAllLines(fileName, arrLine);
        }
        public int searchFile(string surname)
        {
            var file = File.OpenRead("../../wyniki.txt");
            int x = 0;
            var sr = new StreamReader(file);
            string line = sr.ReadLine();
            while (line != null)
            {
                string temp = line.Split(' ')[0];
                if (temp.Equals(surname))
                {
                    sr.Close();
                    return x;
                }
                x++;
                line = sr.ReadLine();
            }
            sr.Close();
            return -1;
        }
    }

}
