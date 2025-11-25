using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadanie2
{
    public partial class Form1 : Form
    {
        int[] arr1 = new int[10];
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = rand.Next(10,100);
                dataGridView1.Rows[0].Cells[i].Value = arr1[i].ToString();
            }
            dataGridView2.Visible = true;
            button2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < arr1.Length; i++)
            {
                string temp = "";
                for(int j = 1; j >= 0; j--)
                {
                    temp += arr1[i].ToString()[j];
                }
                dataGridView2.Rows[0].Cells[i].Value = temp;
            }
        }
    }
}
