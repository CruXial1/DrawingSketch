using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace DrawingSketch
{
    public partial class Form1 : Form
    {
        string currentTool = "Pen";

        Point lastPoint = Point.Empty;
        bool isMouseDown = false;

        float width = 5;
        public Color c = new Color();
        Color savedColor = Color.Black;

        public Point current = new Point();
        public Point old = new Point();
        public Pen p = new Pen(Color.Black, 5);
        public static Graphics g;

        public Form1()
        {
            InitializeComponent();

            Cursor.Current = Cursors.Cross;

            c = Color.Black;
            p = new Pen(c, width);

            textBox1.BackColor = c;
            textBox1.ReadOnly = true;

            textBox2.ReadOnly = false;
            textBox2.Text = $"{width}";

            textBox3.ReadOnly = true;
            textBox3.Text = $"{currentTool}";

            p.SetLineCap(LineCap.Round, LineCap.Round, DashCap.Round);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = e.Location;
            isMouseDown = true;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if(isMouseDown == true)
            {
                if(lastPoint != null)
                {
                    if(pictureBox1.Image == null)
                    {
                        Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);

                        pictureBox1.Image = bmp;
                    }
                    using (Graphics g = Graphics.FromImage(pictureBox1.Image))
                    {
                        c = savedColor;
                        textBox1.BackColor = c;

                        g.DrawLine(p, lastPoint, e.Location);

                        p.SetLineCap(LineCap.Round, LineCap.Round, DashCap.Round);
                    }
                    pictureBox1.Invalidate();

                    lastPoint = e.Location;
                }
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
            lastPoint = Point.Empty;
        }

        private void SizePlus_Click(object sender, EventArgs e)
        {
            width = width + 1;
            p = new Pen(c, width);
            textBox2.Text = $"{width}";
            p.SetLineCap(LineCap.Round, LineCap.Round, DashCap.Round);
        }

        private void SizeMinus_Click(object sender, EventArgs e)
        {
            width = width - 1;
            p = new Pen(c, width);

            p.SetLineCap(LineCap.Round, LineCap.Round, DashCap.Round);

            if (width < 1) width = 1;

            textBox2.Text = $"{width}";
        }

        private void changecolor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();

            if (colorDialog1.Color == Color.White) colorDialog1.Color = Color.Black;

            textBox1.BackColor = colorDialog1.Color;

            c = colorDialog1.Color;
            p = new Pen(c, width);

            savedColor = c;

            p.SetLineCap(LineCap.Round, LineCap.Round, DashCap.Round);
        }

        private void eraser_Click(object sender, EventArgs e)
        {
            currentTool = "Eraser";

            changecolor.Enabled = false;

            Color color = textBox1.BackColor = DefaultBackColor;

            c = Form1.DefaultBackColor;
            p = new Pen(c, width);

            textBox3.Text = $"{currentTool}";

            p.SetLineCap(LineCap.Round, LineCap.Round, DashCap.Round);
        }

        private void pen_Click(object sender, EventArgs e)
        {
            if(savedColor == DefaultBackColor)
            {
                MessageBox.Show("Color was set to background color. \nThe color has been set back to default.", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                savedColor = Color.Black;
            }

            changecolor.Enabled = true;

            currentTool = "Pen";

            textBox1.BackColor = savedColor;
            c = savedColor;
            p = new Pen(c, width);

            textBox3.Text = $"{currentTool}";

            p.SetLineCap(LineCap.Round, LineCap.Round, DashCap.Round);
        }

        private void reset_Click(object sender, EventArgs e)
        {
            width = 5;
            p = new Pen(c, width);

            textBox2.Text = $"{width}";

            p.SetLineCap(LineCap.Round, LineCap.Round, DashCap.Round);
        }

        private void clear_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            var answer = MessageBox.Show("Are you sure you wanna delete your masterpiece?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (answer == DialogResult.No) return;
            else
            {
                pictureBox1.Image = null;
                Invalidate();
                p.SetLineCap(LineCap.Round, LineCap.Round, DashCap.Round);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string Width = width.ToString();

            string content = textBox2.Text;

            var contentNumbers = Regex.Matches(Width, @"[a-zA-Z]").Count;

            var letters = contentNumbers.ToString();

            string filtered = Regex.Replace(content, @"Size:\s*", "").Trim();

            if (!int.TryParse(filtered, out int value))
            {
                return;
            }

            Width = filtered;

            var output = float.Parse(Width);

            c = savedColor;

            width = output;
        }

        private void Help_Click(object sender, EventArgs e)
        {
            string response = "Hello, I see you are new to Crux Paint? Keep reading to get some information about the different features in Crux Paint!\n\nButtons:\n\n1. Size +: Increases the size by 1.\n2. Size -: Decreases the size by 1.\n3. Pen: Selects the pen tool.\n4. Eraser: Selects the eraser tool. \n\n Fields: \n\n1. Size: Shows the current size, you can also change the size with this field.\n2. Current Tool: Displays the selected tool.\n3. Color: Displayes the selected color. \n\n Buttons 2:\n\n1. Reset Size: Resets the size to the default value (5)\n2. Clear: Clears all work on screen.\n3. Change Color: Opens up a dialog for changing colors with the Pen tool.\n4. Save Image: Saves you masterpiece to a .jpg file (still W.I.P)";

            MessageBox.Show(response, "Informaion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Save_Click(object sender, EventArgs e)
        {
            int picWidth = pictureBox1.Width;
            int picHeight = pictureBox1.Height;

            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "JPEG Image (.jpeg) | *.jpg";

            pictureBox1.DrawToBitmap(bmp, new Rectangle(0, 0, picWidth, picHeight));

            if(sf.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            var path = sf.FileName;

            bmp.Save(path, ImageFormat.Jpeg);
        }
    }
}