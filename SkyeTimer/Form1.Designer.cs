namespace SkyeTimer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            toolStrip1 = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            toolStripLabel2 = new ToolStripDropDownButton();
            setTextColorToolStripMenuItem = new ToolStripMenuItem();
            setFontSizeToolStripMenuItem = new ToolStripMenuItem();
            setRingColorToolStripMenuItem = new ToolStripMenuItem();
            setRingProgressColorToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            setBackgroundColorAToolStripMenuItem = new ToolStripMenuItem();
            setBackgroundColorBToolStripMenuItem = new ToolStripMenuItem();
            setGradientTypeToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            setButtonColorAToolStripMenuItem = new ToolStripMenuItem();
            setButtonColorBToolStripMenuItem = new ToolStripMenuItem();
            setGradientTypeToolStripMenuItem1 = new ToolStripMenuItem();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            gradientPanel1 = new GradientPanel();
            gradientButton4 = new GradientButton();
            gradientButton3 = new GradientButton();
            gradientButton2 = new GradientButton();
            gradientButton1 = new GradientButton();
            circleClockTimer1 = new CircleClockTimer();
            panel1 = new Panel();
            colorDialog1 = new ColorDialog();
            fontDialog1 = new FontDialog();
            toolStrip1.SuspendLayout();
            gradientPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.AccessibleRole = AccessibleRole.TitleBar;
            toolStrip1.BackColor = Color.Transparent;
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel1, toolStripLabel2, toolStripButton1, toolStripButton2, toolStripButton3 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(691, 27);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "SkyeTimer";
            toolStrip1.MouseDown += ToolStrip1_MouseDown;
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.AutoSize = false;
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(16, 22);
            toolStripLabel1.Text = "   ";
            // 
            // toolStripLabel2
            // 
            toolStripLabel2.DropDownItems.AddRange(new ToolStripItem[] { setTextColorToolStripMenuItem, setFontSizeToolStripMenuItem, setRingColorToolStripMenuItem, setRingProgressColorToolStripMenuItem, toolStripMenuItem1, setBackgroundColorAToolStripMenuItem, setBackgroundColorBToolStripMenuItem, setGradientTypeToolStripMenuItem, toolStripMenuItem2, setButtonColorAToolStripMenuItem, setButtonColorBToolStripMenuItem, setGradientTypeToolStripMenuItem1 });
            toolStripLabel2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toolStripLabel2.ForeColor = Color.Teal;
            toolStripLabel2.Image = Properties.Resources.focus;
            toolStripLabel2.Name = "toolStripLabel2";
            toolStripLabel2.Size = new Size(111, 24);
            toolStripLabel2.Text = "SkyeTimer";
            // 
            // setTextColorToolStripMenuItem
            // 
            setTextColorToolStripMenuItem.Name = "setTextColorToolStripMenuItem";
            setTextColorToolStripMenuItem.Size = new Size(244, 24);
            setTextColorToolStripMenuItem.Text = "Set Text Color";
            setTextColorToolStripMenuItem.Click += setTextColorToolStripMenuItem_Click;
            // 
            // setFontSizeToolStripMenuItem
            // 
            setFontSizeToolStripMenuItem.Name = "setFontSizeToolStripMenuItem";
            setFontSizeToolStripMenuItem.Size = new Size(244, 24);
            setFontSizeToolStripMenuItem.Text = "Set Font";
            setFontSizeToolStripMenuItem.Click += setFontSizeToolStripMenuItem_Click;
            // 
            // setRingColorToolStripMenuItem
            // 
            setRingColorToolStripMenuItem.Name = "setRingColorToolStripMenuItem";
            setRingColorToolStripMenuItem.Size = new Size(244, 24);
            setRingColorToolStripMenuItem.Text = "Set Ring Color";
            setRingColorToolStripMenuItem.Click += setRingColorToolStripMenuItem_Click;
            // 
            // setRingProgressColorToolStripMenuItem
            // 
            setRingProgressColorToolStripMenuItem.Name = "setRingProgressColorToolStripMenuItem";
            setRingProgressColorToolStripMenuItem.Size = new Size(244, 24);
            setRingProgressColorToolStripMenuItem.Text = "Set Ring Progress Color";
            setRingProgressColorToolStripMenuItem.Click += setRingProgressColorToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(241, 6);
            // 
            // setBackgroundColorAToolStripMenuItem
            // 
            setBackgroundColorAToolStripMenuItem.Name = "setBackgroundColorAToolStripMenuItem";
            setBackgroundColorAToolStripMenuItem.Size = new Size(244, 24);
            setBackgroundColorAToolStripMenuItem.Text = "Set Background Color A";
            setBackgroundColorAToolStripMenuItem.Click += setBackgroundColorAToolStripMenuItem_Click;
            // 
            // setBackgroundColorBToolStripMenuItem
            // 
            setBackgroundColorBToolStripMenuItem.Name = "setBackgroundColorBToolStripMenuItem";
            setBackgroundColorBToolStripMenuItem.Size = new Size(244, 24);
            setBackgroundColorBToolStripMenuItem.Text = "Set Background Color B";
            setBackgroundColorBToolStripMenuItem.Click += setBackgroundColorBToolStripMenuItem_Click;
            // 
            // setGradientTypeToolStripMenuItem
            // 
            setGradientTypeToolStripMenuItem.Name = "setGradientTypeToolStripMenuItem";
            setGradientTypeToolStripMenuItem.Size = new Size(244, 24);
            setGradientTypeToolStripMenuItem.Text = "Set Gradient Type";
            setGradientTypeToolStripMenuItem.Click += setGradientTypeToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(241, 6);
            // 
            // setButtonColorAToolStripMenuItem
            // 
            setButtonColorAToolStripMenuItem.Name = "setButtonColorAToolStripMenuItem";
            setButtonColorAToolStripMenuItem.Size = new Size(244, 24);
            setButtonColorAToolStripMenuItem.Text = "Set Button Color A";
            setButtonColorAToolStripMenuItem.Click += setButtonColorAToolStripMenuItem_Click;
            // 
            // setButtonColorBToolStripMenuItem
            // 
            setButtonColorBToolStripMenuItem.Name = "setButtonColorBToolStripMenuItem";
            setButtonColorBToolStripMenuItem.Size = new Size(244, 24);
            setButtonColorBToolStripMenuItem.Text = "Set Button Color B";
            setButtonColorBToolStripMenuItem.Click += setButtonColorBToolStripMenuItem_Click;
            // 
            // setGradientTypeToolStripMenuItem1
            // 
            setGradientTypeToolStripMenuItem1.Name = "setGradientTypeToolStripMenuItem1";
            setGradientTypeToolStripMenuItem1.Size = new Size(244, 24);
            setGradientTypeToolStripMenuItem1.Text = "Set Gradient Type";
            setGradientTypeToolStripMenuItem1.Click += setGradientTypeToolStripMenuItem1_Click;
            // 
            // toolStripButton1
            // 
            toolStripButton1.Alignment = ToolStripItemAlignment.Right;
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            toolStripButton1.ForeColor = Color.Teal;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Margin = new Padding(0, 1, 0, 0);
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(23, 26);
            toolStripButton1.Text = "x";
            toolStripButton1.ToolTipText = "Close";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.Alignment = ToolStripItemAlignment.Right;
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            toolStripButton2.ForeColor = Color.Teal;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Margin = new Padding(0, 1, 0, 0);
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(23, 26);
            toolStripButton2.Text = "_";
            toolStripButton2.ToolTipText = "Minimize";
            toolStripButton2.Click += toolStripButton2_Click;
            // 
            // toolStripButton3
            // 
            toolStripButton3.Alignment = ToolStripItemAlignment.Right;
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            toolStripButton3.ForeColor = Color.Teal;
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Margin = new Padding(0, 1, 0, 0);
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(23, 26);
            toolStripButton3.Text = "?";
            toolStripButton3.ToolTipText = "About";
            toolStripButton3.Click += toolStripButton3_Click;
            // 
            // gradientPanel1
            // 
            gradientPanel1.Controls.Add(gradientButton4);
            gradientPanel1.Controls.Add(gradientButton3);
            gradientPanel1.Controls.Add(gradientButton2);
            gradientPanel1.Controls.Add(gradientButton1);
            gradientPanel1.Controls.Add(circleClockTimer1);
            gradientPanel1.EndColor = Color.FromArgb(64, 64, 64);
            gradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            gradientPanel1.Location = new Point(12, 45);
            gradientPanel1.Name = "gradientPanel1";
            gradientPanel1.Size = new Size(667, 346);
            gradientPanel1.StartColor = Color.FromArgb(43, 44, 49);
            gradientPanel1.TabIndex = 4;
            gradientPanel1.MouseDown += ToolStrip1_MouseDown;
            // 
            // gradientButton4
            // 
            gradientButton4.BackColor = Color.Transparent;
            gradientButton4.EndColor = Color.Black;
            gradientButton4.FlatAppearance.BorderSize = 0;
            gradientButton4.FlatStyle = FlatStyle.Flat;
            gradientButton4.ForeColor = Color.White;
            gradientButton4.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            gradientButton4.Location = new Point(3, 254);
            gradientButton4.Name = "gradientButton4";
            gradientButton4.Size = new Size(72, 72);
            gradientButton4.StartColor = Color.Teal;
            gradientButton4.TabIndex = 4;
            gradientButton4.Text = "Reset";
            gradientButton4.UseCompatibleTextRendering = true;
            gradientButton4.UseVisualStyleBackColor = false;
            gradientButton4.Click += gradientButton4_Click;
            // 
            // gradientButton3
            // 
            gradientButton3.BackColor = Color.Transparent;
            gradientButton3.EndColor = Color.Black;
            gradientButton3.FlatAppearance.BorderSize = 0;
            gradientButton3.FlatStyle = FlatStyle.Flat;
            gradientButton3.ForeColor = Color.White;
            gradientButton3.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            gradientButton3.Location = new Point(3, 176);
            gradientButton3.Name = "gradientButton3";
            gradientButton3.Size = new Size(72, 72);
            gradientButton3.StartColor = Color.Teal;
            gradientButton3.TabIndex = 3;
            gradientButton3.Text = "Set Time";
            gradientButton3.UseCompatibleTextRendering = true;
            gradientButton3.UseVisualStyleBackColor = false;
            gradientButton3.Click += gradientButton3_Click;
            // 
            // gradientButton2
            // 
            gradientButton2.BackColor = Color.Transparent;
            gradientButton2.EndColor = Color.Black;
            gradientButton2.FlatAppearance.BorderSize = 0;
            gradientButton2.FlatStyle = FlatStyle.Flat;
            gradientButton2.ForeColor = Color.White;
            gradientButton2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            gradientButton2.Location = new Point(3, 98);
            gradientButton2.Name = "gradientButton2";
            gradientButton2.Size = new Size(72, 72);
            gradientButton2.StartColor = Color.Teal;
            gradientButton2.TabIndex = 2;
            gradientButton2.Text = "Stop";
            gradientButton2.UseCompatibleTextRendering = true;
            gradientButton2.UseVisualStyleBackColor = false;
            gradientButton2.Click += gradientButton2_Click;
            // 
            // gradientButton1
            // 
            gradientButton1.BackColor = Color.Transparent;
            gradientButton1.EndColor = Color.Black;
            gradientButton1.FlatAppearance.BorderSize = 0;
            gradientButton1.FlatStyle = FlatStyle.Flat;
            gradientButton1.ForeColor = Color.White;
            gradientButton1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            gradientButton1.Location = new Point(3, 20);
            gradientButton1.Name = "gradientButton1";
            gradientButton1.Size = new Size(72, 72);
            gradientButton1.StartColor = Color.Teal;
            gradientButton1.TabIndex = 1;
            gradientButton1.Text = "Start";
            gradientButton1.UseCompatibleTextRendering = true;
            gradientButton1.UseVisualStyleBackColor = false;
            gradientButton1.Click += gradientButton1_Click;
            // 
            // circleClockTimer1
            // 
            circleClockTimer1.BackColor = Color.White;
            circleClockTimer1.BorderColor = Color.White;
            circleClockTimer1.EndColor = Color.FromArgb(64, 64, 64);
            circleClockTimer1.ForeColor = Color.Teal;
            circleClockTimer1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            circleClockTimer1.Location = new Point(183, 0);
            circleClockTimer1.Name = "circleClockTimer1";
            circleClockTimer1.PieColor = Color.Yellow;
            circleClockTimer1.Size = new Size(300, 346);
            circleClockTimer1.StartColor = Color.FromArgb(43, 44, 49);
            circleClockTimer1.TabIndex = 0;
            circleClockTimer1.Text = "circleClockTimer1";
            circleClockTimer1.TextColor = Color.Lime;
            circleClockTimer1.TimeLimitInMinutes = 1;
            circleClockTimer1.MouseDown += ToolStrip1_MouseDown;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 27);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(20, 0, 20, 0);
            panel1.Size = new Size(691, 2);
            panel1.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 44, 49);
            ClientSize = new Size(691, 403);
            Controls.Add(panel1);
            Controls.Add(gradientPanel1);
            Controls.Add(toolStrip1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "SkyeTimer";
            MouseDown += ToolStrip1_MouseDown;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            gradientPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private GradientPanel gradientPanel1;
        private Panel panel1;
        private ToolStripButton toolStripButton3;
        private CircleClockTimer circleClockTimer1;
        private ToolStripDropDownButton toolStripLabel2;
        private ToolStripMenuItem setTextColorToolStripMenuItem;
        private ToolStripMenuItem setRingColorToolStripMenuItem;
        private ToolStripMenuItem setRingProgressColorToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem setBackgroundColorAToolStripMenuItem;
        private ToolStripMenuItem setBackgroundColorBToolStripMenuItem;
        private ToolStripMenuItem setGradientTypeToolStripMenuItem;
        private GradientButton gradientButton1;
        private ToolStripSeparator toolStripMenuItem2;
        private GradientButton gradientButton3;
        private GradientButton gradientButton2;
        private ToolStripMenuItem setButtonColorAToolStripMenuItem;
        private ToolStripMenuItem setButtonColorBToolStripMenuItem;
        private ToolStripMenuItem setGradientTypeToolStripMenuItem1;
        private GradientButton gradientButton4;
        private ToolStripMenuItem setFontSizeToolStripMenuItem;
        private ColorDialog colorDialog1;
        private FontDialog fontDialog1;
    }
}
