using Microsoft.VisualBasic;
using System.Runtime.InteropServices;

namespace SkyeTimer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            toolStrip1.Renderer = new MySR();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void MoveWithMouse(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void ToolStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            MoveWithMouse(e);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.WindowState = FormWindowState.Minimized;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Build for @SkyeGreytv, By @Angablade");
        }

        private void gradientButton1_Click(object sender, EventArgs e)
        {
            circleClockTimer1.Start();
        }

        private void gradientButton2_Click(object sender, EventArgs e)
        {
            circleClockTimer1.Stop();
        }

        private void gradientButton3_Click(object sender, EventArgs e)
        {
            string userInput = Interaction.InputBox("Please enter the number of minutes", "Set Time limit", "3");
            if (int.TryParse(userInput, out int mins))
            {
                circleClockTimer1.TimeLimitInMinutes = mins;
            }
            else
            {
                Interaction.MsgBox("There was an error setting time. No changes made.");
            }
        }

        private void gradientButton4_Click(object sender, EventArgs e)
        {
            circleClockTimer1.Reset();
        }

        private void setTextColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1 = new ColorDialog();
            colorDialog1.Color = circleClockTimer1.TextColor;
            colorDialog1.ShowDialog();
            circleClockTimer1.TextColor = colorDialog1.Color;
        }

        private void setRingColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1 = new ColorDialog();
            colorDialog1.Color = circleClockTimer1.BorderColor;
            colorDialog1.ShowDialog();
            circleClockTimer1.BorderColor = colorDialog1.Color;
        }

        private void setRingProgressColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1 = new ColorDialog();
            colorDialog1.Color = circleClockTimer1.PieColor;
            colorDialog1.ShowDialog();
            circleClockTimer1.PieColor = colorDialog1.Color;
        }

        private void setButtonColorAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1 = new ColorDialog();
            colorDialog1.Color = gradientButton1.StartColor;
            colorDialog1.ShowDialog();
            gradientButton1.StartColor = colorDialog1.Color;
            gradientButton2.StartColor = colorDialog1.Color;
            gradientButton3.StartColor = colorDialog1.Color;
            gradientButton4.StartColor = colorDialog1.Color;
        }

        private void setButtonColorBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1 = new ColorDialog();
            colorDialog1.Color = gradientButton1.EndColor;
            colorDialog1.ShowDialog();
            gradientButton1.EndColor = colorDialog1.Color;
            gradientButton2.EndColor = colorDialog1.Color;
            gradientButton3.EndColor = colorDialog1.Color;
            gradientButton4.EndColor = colorDialog1.Color;
        }

        private void setFontSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1 = new FontDialog();
            fontDialog1.Font = circleClockTimer1.Font;
            fontDialog1.ShowDialog();
            circleClockTimer1.Font = fontDialog1.Font;
        }

        private void setGradientTypeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (var form = new GradientForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    GradientType selectedGradient = form.SelectedGradient;
                    gradientButton1.GradientMode = (System.Drawing.Drawing2D.LinearGradientMode)selectedGradient;
                    gradientButton2.GradientMode = (System.Drawing.Drawing2D.LinearGradientMode)selectedGradient;
                    gradientButton3.GradientMode = (System.Drawing.Drawing2D.LinearGradientMode)selectedGradient;
                    gradientButton4.GradientMode = (System.Drawing.Drawing2D.LinearGradientMode)selectedGradient;
                }
            }
        }

        private void setBackgroundColorAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1 = new ColorDialog();
            colorDialog1.Color = gradientPanel1.StartColor;
            colorDialog1.ShowDialog();
            gradientPanel1.StartColor = colorDialog1.Color;
            circleClockTimer1.StartColor = colorDialog1.Color;
        }

        private void setBackgroundColorBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1 = new ColorDialog();
            colorDialog1.Color = gradientPanel1.EndColor;
            colorDialog1.ShowDialog();
            gradientPanel1.EndColor = colorDialog1.Color;
            circleClockTimer1.EndColor = colorDialog1.Color;
        }

        private void setGradientTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new GradientForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    GradientType selectedGradient = form.SelectedGradient;
                    gradientPanel1.GradientMode = (System.Drawing.Drawing2D.LinearGradientMode)selectedGradient;
                    circleClockTimer1.GradientMode = (System.Drawing.Drawing2D.LinearGradientMode)selectedGradient;
                }
            }
        }
    }
}
