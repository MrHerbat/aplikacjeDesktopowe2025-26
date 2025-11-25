using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadanie3
{
    public partial class Form1 : Form
    {
        int[][] arr = new int[7][];
        public Form1()
        {
            InitializeComponent();
            for(int i = 0; i < 6; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView2.Rows.Add();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new int[5];
                for(int j = 0;  j < arr[i].Length; j++)
                {
                    arr[i][j] = rand.Next(100, 1000);
                    dataGridView1.Rows[i].Cells[j].Value = arr[i][j];
                }
            }
            button2.Visible = true;
            dataGridView2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int max = 0;
                for (int j = 0; j < arr[i].Length; j++)
                {
                    if (max <= arr[i][j])
                    {
                        max = arr[i][j];
                    }
                }
                dataGridView2.Rows[i].Cells[0].Value = max;
            }
        }
    }
}
