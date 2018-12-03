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
            this.Save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AssignWidth = new System.Windows.Forms.TextBox();
            this.AssignHeight = new System.Windows.Forms.TextBox();
            this.ImgWidth = new System.Windows.Forms.Label();
            this.ImgHeight = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SizePlus
            // 
            this.SizePlus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SizePlus.BackColor = System.Drawing.Color.DarkGray;
            this.SizePlus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SizePlus.Location = new System.Drawing.Point(740, 7);
            this.SizePlus.Name = "SizePlus";
            this.SizePlus.Size = new System.Drawing.Size(55, 63);
            this.SizePlus.TabIndex = 1;
            this.SizePlus.Text = "Size +";
            this.SizePlus.UseVisualStyleBackColor = false;
            this.SizePlus.Click += new System.EventHandler(this.SizePlus_Click);
            // 
            // SizeMinus
            // 
            this.SizeMinus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SizeMinus.BackColor = System.Drawing.Color.DarkGray;
            this.SizeMinus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SizeMinus.Location = new System.Drawing.Point(822, 7);
            this.SizeMinus.Name = "SizeMinus";
            this.SizeMinus.Size = new System.Drawing.Size(55, 63);
            this.SizeMinus.TabIndex = 2;
            this.SizeMinus.Text = "Size -";
            this.SizeMinus.UseVisualStyleBackColor = false;
            this.SizeMinus.Click += new System.EventHandler(this.SizeMinus_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(785, 209);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(92, 20);
            this.textBox1.TabIndex = 3;
            // 
            // changecolor
            // 
            this.changecolor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.changecolor.BackColor = System.Drawing.SystemColors.ControlDark;
            this.changecolor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.changecolor.Location = new System.Drawing.Point(743, 426);
            this.changecolor.Name = "changecolor";
            this.changecolor.Size = new System.Drawing.Size(137, 65);
            this.changecolor.TabIndex = 4;
            this.changecolor.Text = "Change Color";
            this.changecolor.UseVisualStyleBackColor = false;
            this.changecolor.Click += new System.EventHandler(this.changecolor_Click);
            // 
            // eraser
            // 
            this.eraser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.eraser.BackColor = System.Drawing.SystemColors.ControlDark;
            this.eraser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.eraser.Location = new System.Drawing.Point(822, 91);
            this.eraser.Name = "eraser";
            this.eraser.Size = new System.Drawing.Size(54, 60);
            this.eraser.TabIndex = 5;
            this.eraser.Text = "Eraser";
            this.eraser.UseVisualStyleBackColor = false;
            this.eraser.Click += new System.EventHandler(this.eraser_Click);
            // 
            // pen
            // 
            this.pen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pen.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pen.Location = new System.Drawing.Point(740, 91);
            this.pen.Name = "pen";
            this.pen.Size = new System.Drawing.Size(54, 60);
            this.pen.TabIndex = 6;
            this.pen.Text = "Pen";
            this.pen.UseVisualStyleBackColor = false;
            this.pen.Click += new System.EventHandler(this.pen_Click);
            // 
            // clear
            // 
            this.clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clear.BackColor = System.Drawing.SystemColors.ControlDark;
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clear.Location = new System.Drawing.Point(743, 357);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(137, 63);
            this.clear.TabIndex = 7;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // reset
            // 
            this.reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.reset.BackColor = System.Drawing.SystemColors.ControlDark;
            this.reset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.reset.Location = new System.Drawing.Point(743, 288);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(137, 63);
            this.reset.TabIndex = 8;
            this.reset.Text = "Reset Size";
            this.reset.UseVisualStyleBackColor = false;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(785, 157);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(92, 20);
            this.textBox2.TabIndex = 9;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Location = new System.Drawing.Point(785, 183);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(92, 20);
            this.textBox3.TabIndex = 10;
            // 
            // Help
            // 
            this.Help.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Help.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Help.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Help.Location = new System.Drawing.Point(801, 497);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(75, 23);
            this.Help.TabIndex = 11;
            this.Help.Text = "Help";
            this.Help.UseVisualStyleBackColor = false;
            this.Help.Click += new System.EventHandler(this.Help_Click);
            // 
            // Save
            // 
            this.Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Save.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Save.Location = new System.Drawing.Point(13, 497);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 12;
            this.Save.Text = "Save Image";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(744, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Size:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(743, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tool:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(740, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Color:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBox1.Location = new System.Drawing.Point(13, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(711, 484);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.SizeChanged += new System.EventHandler(this.pictureBox1_SizeChanged);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // AssignWidth
            // 
            this.AssignWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AssignWidth.BackColor = System.Drawing.SystemColors.ControlDark;
            this.AssignWidth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AssignWidth.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AssignWidth.Location = new System.Drawing.Point(785, 235);
            this.AssignWidth.Name = "AssignWidth";
            this.AssignWidth.Size = new System.Drawing.Size(92, 20);
            this.AssignWidth.TabIndex = 18;
            // 
            // AssignHeight
            // 
            this.AssignHeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AssignHeight.BackColor = System.Drawing.SystemColors.ControlDark;
            this.AssignHeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AssignHeight.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AssignHeight.Location = new System.Drawing.Point(785, 262);
            this.AssignHeight.Name = "AssignHeight";
            this.AssignHeight.Size = new System.Drawing.Size(92, 20);
            this.AssignHeight.TabIndex = 19;
            // 
            // ImgWidth
            // 
            this.ImgWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ImgWidth.AutoSize = true;
            this.ImgWidth.Cursor = System.Windows.Forms.Cursors.Default;
            this.ImgWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ImgWidth.ForeColor = System.Drawing.Color.White;
            this.ImgWidth.Location = new System.Drawing.Point(738, 236);
            this.ImgWidth.Name = "ImgWidth";
            this.ImgWidth.Size = new System.Drawing.Size(48, 17);
            this.ImgWidth.TabIndex = 20;
            this.ImgWidth.Text = "Width:";
            // 
            // ImgHeight
            // 
            this.ImgHeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ImgHeight.AutoSize = true;
            this.ImgHeight.Cursor = System.Windows.Forms.Cursors.Default;
            this.ImgHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ImgHeight.ForeColor = System.Drawing.Color.White;
            this.ImgHeight.Location = new System.Drawing.Point(732, 263);
            this.ImgHeight.Name = "ImgHeight";
            this.ImgHeight.Size = new System.Drawing.Size(53, 17);
            this.ImgHeight.TabIndex = 21;
            this.ImgHeight.Text = "Height:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(885, 528);
            this.Controls.Add(this.ImgHeight);
            this.Controls.Add(this.ImgWidth);
            this.Controls.Add(this.AssignHeight);
            this.Controls.Add(this.AssignWidth);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Save);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Crux Paint";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox AssignWidth;
        private System.Windows.Forms.TextBox AssignHeight;
        private System.Windows.Forms.Label ImgWidth;
        private System.Windows.Forms.Label ImgHeight;
    }
}

