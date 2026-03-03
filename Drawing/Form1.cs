using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Drawing
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                drawCircle(e, 100 + i * 10, Color.Gray, i, i);
            }
        }
        void drawCircle(PaintEventArgs e,int size, Color color, int xPos, int yPos)
        {
            Pen myPen = new Pen(color, 10);
            Brush brush = new SolidBrush(color);
            Graphics g;
            g = this.CreateGraphics();
            g.FillEllipse(brush, new Rectangle(xPos, yPos, size, size));
            myPen.Dispose();
            Thread.Sleep(100);
            g.Clear(Color.White);
            g.Dispose();
            myPen.Dispose();
            brush.Dispose();
        }
    }
}
