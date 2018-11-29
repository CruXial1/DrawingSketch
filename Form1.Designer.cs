namespace DrawingSketch
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.SizePlus = new System.Windows.Forms.Button();
            this.SizeMinus = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.changecolor = new System.Windows.Forms.Button();
            this.eraser = new System.Windows.Forms.Button();
            this.pen = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Help = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(13, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 431);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // SizePlus
            // 
            this.SizePlus.BackColor = System.Drawing.Color.DarkGray;
            this.SizePlus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SizePlus.Location = new System.Drawing.Point(659, 7);
            this.SizePlus.Name = "SizePlus";
            this.SizePlus.Size = new System.Drawing.Size(55, 63);
            this.SizePlus.TabIndex = 1;
            this.SizePlus.Text = "Size +";
            this.SizePlus.UseVisualStyleBackColor = false;
            this.SizePlus.Click += new System.EventHandler(this.SizePlus_Click);
            // 
            // SizeMinus
            // 
            this.SizeMinus.BackColor = System.Drawing.Color.DarkGray;
            this.SizeMinus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SizeMinus.Location = new System.Drawing.Point(741, 7);
            this.SizeMinus.Name = "SizeMinus";
            this.SizeMinus.Size = new System.Drawing.Size(55, 63);
            this.SizeMinus.TabIndex = 2;
            this.SizeMinus.Text = "Size -";
            this.SizeMinus.UseVisualStyleBackColor = false;
            this.SizeMinus.Click += new System.EventHandler(this.SizeMinus_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(659, 209);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(137, 20);
            this.textBox1.TabIndex = 3;
            // 
            // changecolor
            // 
            this.changecolor.BackColor = System.Drawing.SystemColors.ControlDark;
            this.changecolor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.changecolor.Location = new System.Drawing.Point(659, 373);
            this.changecolor.Name = "changecolor";
            this.changecolor.Size = new System.Drawing.Size(137, 65);
            this.changecolor.TabIndex = 4;
            this.changecolor.Text = "Change Color";
            this.changecolor.UseVisualStyleBackColor = false;
            this.changecolor.Click += new System.EventHandler(this.changecolor_Click);
            // 
            // eraser
            // 
            this.eraser.BackColor = System.Drawing.SystemColors.ControlDark;
            this.eraser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.eraser.Location = new System.Drawing.Point(741, 91);
            this.eraser.Name = "eraser";
            this.eraser.Size = new System.Drawing.Size(54, 60);
            this.eraser.TabIndex = 5;
            this.eraser.Text = "Eraser";
            this.eraser.UseVisualStyleBackColor = false;
            this.eraser.Click += new System.EventHandler(this.eraser_Click);
            // 
            // pen
            // 
            this.pen.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pen.Location = new System.Drawing.Point(659, 91);
            this.pen.Name = "pen";
            this.pen.Size = new System.Drawing.Size(54, 60);
            this.pen.TabIndex = 6;
            this.pen.Text = "Pen";
            this.pen.UseVisualStyleBackColor = false;
            this.pen.Click += new System.EventHandler(this.pen_Click);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.SystemColors.ControlDark;
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clear.Location = new System.Drawing.Point(659, 304);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(137, 63);
            this.clear.TabIndex = 7;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // reset
            // 
            this.reset.BackColor = System.Drawing.SystemColors.ControlDark;
            this.reset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.reset.Location = new System.Drawing.Point(660, 235);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(137, 63);
            this.reset.TabIndex = 8;
            this.reset.Text = "Reset Size";
            this.reset.UseVisualStyleBackColor = false;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(660, 157);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(136, 20);
            this.textBox2.TabIndex = 9;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Location = new System.Drawing.Point(659, 183);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(137, 20);
            this.textBox3.TabIndex = 10;
            // 
            // Help
            // 
            this.Help.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Help.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Help.Location = new System.Drawing.Point(720, 444);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(75, 23);
            this.Help.TabIndex = 11;
            this.Help.Text = "Help";
            this.Help.UseVisualStyleBackColor = false;
            this.Help.Click += new System.EventHandler(this.Help_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(808, 479);
            this.Controls.Add(this.Help);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.pen);
            this.Controls.Add(this.eraser);
            this.Controls.Add(this.changecolor);
            this.Controls.Add(this.SizeMinus);
            this.Controls.Add(this.SizePlus);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Crux Paint";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SizePlus;
        private System.Windows.Forms.Button SizeMinus;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button changecolor;
        private System.Windows.Forms.Button eraser;
        private System.Windows.Forms.Button pen;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button Help;
    }
}

