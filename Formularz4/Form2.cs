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
            if (zadanie1_comboBox.SelectedIndex == 3)
                punkty += 1;
            if (odpowiedz_c.Checked)
                punkty += 1;
            foreach (var item in zadanie3_checkedListBox.SelectedItems)
            {
                if(!item.ToString().Equals("Praca") || !item.ToString().Equals("Energia Kinetyczna"))
                {
                    punkty++;
                }
            }
            if (zadanie4_textBox.Text.Equals("100J") || zadanie4_textBox.Text.Equals("100 J"))
                punkty += 2;

            var path = "../../wyniki.txt";
            File.AppendAllText(path, "\n"+surname+" "+punkty+"pkt");

            this.Close();
        }
    }
}
