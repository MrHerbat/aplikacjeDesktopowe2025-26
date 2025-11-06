using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Tablica
{
    public partial class Form1 : Form
    {
        private int[] array;
        public Form1()
        {
            InitializeComponent();
        }

        private void fillArray(object sender, EventArgs e)
        {
            Random rand = new Random();
            array = new int[dataGridView1.ColumnCount];
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                dataGridView1.Rows[0].Cells[i].Value = rand.Next(1, 101);
                array[i] = Int32.Parse(dataGridView1.Rows[0].Cells[i].Value.ToString());
            }
            label1.Visible = false;
            textBox1.Visible = false;
            dataGridView2.Visible = false;
        }

        private void getMinValue(object sender, EventArgs e)
        {
            if (array == null || array.Length == 0)
                return;
            int temp;
            temp = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < temp)
                {
                    temp = array[i];
                }
            }
            label1.Visible = true;
            label1.Text = "Min Value:";
            textBox1.Visible = true;
            textBox1.Text = temp.ToString();
        }

        private void getMaxValue(object sender, EventArgs e)
        {

            if (array == null || array.Length == 0)
                return;
            int temp = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > temp)
                {
                    temp = array[i];
                }
            }
            label1.Visible = true;
            label1.Text = "Max Value:";
            textBox1.Visible = true;
            textBox1.Text = temp.ToString();
        }

        private void sortAscending(object sender, EventArgs e)
        {
            if (array == null || array.Length == 0)
                return;
            int temp = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];

                        array[i] = array[j];

                        array[j] = temp;
                    }
                }
                dataGridView2.Rows[0].Cells[i].Value = array[i];
            }
            dataGridView2.Visible = true;
            button5.Visible = true;
            label2.Visible = true;
            textBox2.Visible = true;
        }

        private int? binarySearch(int[] arr, int search)
        {
            int start = 0, end = arr.Length, mid = (end + start) / 2;
            while (start != end || (mid >= 0 && mid < arr.Length))
            {
                if (arr[mid] == search)
                {
                    return mid;
                }
                if (arr[mid] < search)
                {
                    end = mid - 1;
                }
                else if (arr[mid] > search)
                {
                    start = mid + 1;
                }
                mid = (end + start) / 2;
            }
            return null;
        }

        private void searchFor(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox2.Text))
                return;
            int? indexOfSearched = binarySearch(array, Int32.Parse(textBox2.Text));
            textBox3.Text = indexOfSearched.ToString();
            label3.Visible = true;
            textBox3.Visible = true;
        }

        private void mergeSort_onClick(object sender, EventArgs e)
        {
            if (array == null || array.Length == 0)
                return;
            mergeSort(array);
            for (int i = 0; i < array.Length; i++)
            {
                dataGridView2.Rows[0].Cells[i].Value = array[i];
            }
            dataGridView2.Visible = true;
            button5.Visible = true;
            label2.Visible = true;
            textBox2.Visible = true;
        }
        public static void mergeSort(int[] array)
        {
            if (array == null || array.Length < 2) return;
            var aux = new int[array.Length];
            mergeSort(array, aux, 0, array.Length - 1);
        }

        private static void mergeSort(int[] arr, int[] aux, int left, int right)
        {
            if (left >= right) return;
            int mid = left + (right - left) / 2;
            mergeSort(arr, aux, left, mid);
            mergeSort(arr, aux, mid + 1, right);
            Merge(arr, aux, left, mid, right);
        }

        private static void Merge(int[] arr, int[] aux, int left, int mid, int right)
        {
            int i = left, j = mid + 1, k = left;
            while (i <= mid && j <= right)
            {
                if (arr[i] <= arr[j])
                    aux[k++] = arr[i++];
                else
                    aux[k++] = arr[j++];
            }
            while (i <= mid) aux[k++] = arr[i++];
            while (j <= right) aux[k++] = arr[j++];

            for (int idx = left; idx <= right; idx++) arr[idx] = aux[idx];
        }
    }
}
