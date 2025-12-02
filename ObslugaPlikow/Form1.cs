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

namespace ObslugaPlikow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Otwórz Plik";
            ofd.Filter = "Pliki tekstowe|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string path = ofd.FileName;

                try
                {
                    string value = File.ReadAllText(path);

                    richTextBox1.Text = value;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Wystąpił błąd w trakcie otwierania pliku: " + ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Zapisz plik";
            sfd.Filter = "Pliki tekstowe|*.txt";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string path = sfd.FileName;

                try
                {
                    File.AppendAllText(path+"\n", textBox1.Text);
                    MessageBox.Show("Zapisano zawartość do pliku");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Wystąpił błąd w trakcie zapisywania pliku: " + ex.Message);
                }
            }
        }
    }
}
