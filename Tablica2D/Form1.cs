using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tablica2D
{
    public partial class Form1 : Form
    {
        private int rowCount = 5;
        public Form1()
        {
            InitializeComponent();
            dataGridView1.RowCount = rowCount;
        }
        private void fillArray(Object sender, EventArgs e)
        {
            Random ran = new Random();
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = ran.Next(0, 10);
                }
            }
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
        }

        private void sumByRows(object sender, EventArgs e)
        {
            dataGridView2.RowCount=rowCount;
            int sum;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                sum = 0;
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    sum += Int32.Parse(dataGridView1.Rows[i].Cells[j].Value.ToString());         
                }
                dataGridView2.Rows[i].Cells[0].Value = sum;
            }
            dataGridView2.Visible = true;
        }
        private void sumByColumns(object sender, EventArgs e)
        {
            dataGridView3.ColumnCount = dataGridView1.ColumnCount;
            int sum;
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                sum = 0;
                for (int j = 0; j < dataGridView1.RowCount; j++)
                {
                    sum += Int32.Parse(dataGridView1.Rows[j].Cells[i].Value.ToString());
                }
                dataGridView3.Rows[0].Cells[i].Value = sum;
            }
            dataGridView3.Visible = true;
        }
    }
}
