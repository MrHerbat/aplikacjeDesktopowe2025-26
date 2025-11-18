using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularz2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_zatwierdz_Click(object sender, EventArgs e)
        {
            int indexSzkola = listBox1.SelectedIndex;
            string output = string.Format("Zamieszkanie: {0}\nSzkoła: {1}",
                comboBox_zamieszkanie.SelectedItem.ToString(),
                listBox1.Items[indexSzkola].ToString());
            textBox_output.Text = output;
        }
    }
}
