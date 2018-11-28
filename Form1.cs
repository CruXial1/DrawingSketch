using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawingSketch
{
    public partial class Form1 : Form
    {
        string currentTool = "Pen";

        float width = 5;
        public Color c = new Color();

        public Point current = new Point();
        public Point old = new Point();
        public Pen p = new Pen(Color.Black, 5);
        public Graphics g;

        public Form1()
        {
            InitializeComponent();

            c = Color.Black;
            p = new Pen(c, width);

            textBox1.BackColor = c;
            textBox1.ReadOnly = true;

            textBox2.ReadOnly = true;
            textBox2.Text = $"Size: {width}";

            textBox3.ReadOnly = true;
            textBox3.Text = $"Current Tool: {currentTool}";

            panel1.BorderStyle = BorderStyle.FixedSingle;

            g = panel1.CreateGraphics();

            p.SetLineCap(LineCap.Round, LineCap.Round, DashCap.Round);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            old = e.Location;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                p.SetLineCap(LineCap.Round, LineCap.Round, DashCap.Round);

                current = e.Location;
                g.DrawLine(p, old, current);
                old = current;
            }
        }

        private void SizePlus_Click(object sender, EventArgs e)
        {
            width = width + 1;
            p = new Pen(c, width);
            textBox2.Text = $"Size: {width}";
            p.SetLineCap(LineCap.Round, LineCap.Round, DashCap.Round);
        }

        private void SizeMinus_Click(object sender, EventArgs e)
        {
            width = width - 1;
            p = new Pen(c, width);

            p.SetLineCap(LineCap.Round, LineCap.Round, DashCap.Round);

            if (width < 1) width = 1;

            textBox2.Text = $"Size: {width}";
        }

        private void changecolor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();

            if (colorDialog1.Color == Color.White) colorDialog1.Color = Color.Black;

            textBox1.BackColor = colorDialog1.Color;

            c = colorDialog1.Color;
            p = new Pen(c, width);

            p.SetLineCap(LineCap.Round, LineCap.Round, DashCap.Round);
        }

        private void eraser_Click(object sender, EventArgs e)
        {
            currentTool = "eraser";

            textBox1.BackColor = Color.White;

            c = Form1.DefaultBackColor;
            p = new Pen(c, width);

            textBox3.Text = $"Current Tool: {currentTool}";

            p.SetLineCap(LineCap.Round, LineCap.Round, DashCap.Round);
        }

        private void pen_Click(object sender, EventArgs e)
        {
            currentTool = "Pen";

            c = colorDialog1.Color;
            p = new Pen(c, width);

            textBox3.Text = $"Current Tool: {currentTool}";

            p.SetLineCap(LineCap.Round, LineCap.Round, DashCap.Round);
        }

        private void reset_Click(object sender, EventArgs e)
        {
            width = 5;
            p = new Pen(c, width);

            textBox2.Text = $"Size: {width}";

            p.SetLineCap(LineCap.Round, LineCap.Round, DashCap.Round);
        }

        private void clear_Click(object sender, EventArgs e)
        {
            var answer = MessageBox.Show("Are you sure you wanna delete your masterpiece?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (answer == DialogResult.No) return;
            else
            {
                panel1.Invalidate();
                p.SetLineCap(LineCap.Round, LineCap.Round, DashCap.Round);
            }
        }
    }
}
