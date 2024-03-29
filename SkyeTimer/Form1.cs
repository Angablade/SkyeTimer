using Microsoft.VisualBasic;
using System.Drawing.Drawing2D;
using System.Media;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SkyeTimer
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            toolStrip1.Renderer = new MySR();
            try
            {
                Font savedFont = new Font(Properties.Settings.Default.fontname, Properties.Settings.Default.fontsize, (FontStyle)Properties.Settings.Default.fontstyle);
                circleClockTimer1.Font = savedFont;
                circleClockTimer1.TextColor = Color.FromArgb(Properties.Settings.Default.textcolor);
                circleClockTimer1.BorderColor = Color.FromArgb(Properties.Settings.Default.ringcolor);
                circleClockTimer1.PieColor = Color.FromArgb(Properties.Settings.Default.ringprogresscolor);

                gradientPanel1.StartColor = Color.FromArgb(Properties.Settings.Default.bgcolorA);
                circleClockTimer1.StartColor = Color.FromArgb(Properties.Settings.Default.bgcolorA);
                gradientPanel1.EndColor = Color.FromArgb(Properties.Settings.Default.bgcolorB);
                circleClockTimer1.EndColor = Color.FromArgb(Properties.Settings.Default.bgcolorB);

                if (Enum.TryParse(Properties.Settings.Default.bggradtype, out LinearGradientMode gradientMode1))
                {
                    gradientPanel1.GradientMode = gradientMode1;
                    circleClockTimer1.GradientMode = gradientMode1;
                }

                gradientButton1.StartColor = Color.FromArgb(Properties.Settings.Default.btncolorA);
                gradientButton2.StartColor = Color.FromArgb(Properties.Settings.Default.btncolorA);
                gradientButton3.StartColor = Color.FromArgb(Properties.Settings.Default.btncolorA);
                gradientButton4.StartColor = Color.FromArgb(Properties.Settings.Default.btncolorA);
                gradientButton5.StartColor = Color.FromArgb(Properties.Settings.Default.btncolorA);
                gradientButton6.StartColor = Color.FromArgb(Properties.Settings.Default.btncolorA);
                gradientButton7.StartColor = Color.FromArgb(Properties.Settings.Default.btncolorA);
                gradientButton8.StartColor = Color.FromArgb(Properties.Settings.Default.btncolorA);

                gradientButton1.EndColor = Color.FromArgb(Properties.Settings.Default.btncolorB);
                gradientButton2.EndColor = Color.FromArgb(Properties.Settings.Default.btncolorB);
                gradientButton3.EndColor = Color.FromArgb(Properties.Settings.Default.btncolorB);
                gradientButton4.EndColor = Color.FromArgb(Properties.Settings.Default.btncolorB);
                gradientButton5.EndColor = Color.FromArgb(Properties.Settings.Default.btncolorB);
                gradientButton6.EndColor = Color.FromArgb(Properties.Settings.Default.btncolorB);
                gradientButton7.EndColor = Color.FromArgb(Properties.Settings.Default.btncolorB);
                gradientButton8.EndColor = Color.FromArgb(Properties.Settings.Default.btncolorB);

                if (Enum.TryParse(Properties.Settings.Default.btngradtype, out LinearGradientMode gradientMode2))
                {
                    gradientButton1.GradientMode = gradientMode2;
                    gradientButton2.GradientMode = gradientMode2;
                    gradientButton3.GradientMode = gradientMode2;
                    gradientButton4.GradientMode = gradientMode2;
                    gradientButton5.GradientMode = gradientMode2;
                    gradientButton6.GradientMode = gradientMode2;
                    gradientButton7.GradientMode = gradientMode2;
                    gradientButton8.GradientMode = gradientMode2;
                }
            }
            catch (Exception) { }
            InitializeHotKeyManager();
        }

        public KeyboardHook KbHook = new KeyboardHook();
        
        private void InitializeHotKeyManager()
        {
            KbHook.RegisterHotKey(Keys.F9, args => { }, args =>
            {
                if (KeyboardHook.IsShiftPressed())
                {
                    this.Focus();

                    if (this.WindowState == FormWindowState.Minimized)
                    {
                        this.WindowState = FormWindowState.Normal;
                    }

                    if (Properties.Settings.Default.beeper)
                    {
                        SystemSounds.Beep.Play();
                    }

                    gradientButton5_Click(this, EventArgs.Empty);
                }
            });


            KbHook.RegisterHotKey(Keys.F10, args => { }, args =>
            {
                if (KeyboardHook.IsShiftPressed())
                {
                    this.Focus();

                    if (this.WindowState == FormWindowState.Minimized)
                    {
                        this.WindowState = FormWindowState.Normal;
                    }

                    if (Properties.Settings.Default.beeper)
                    {
                        SystemSounds.Beep.Play();
                    }

                    gradientButton6_Click(this, EventArgs.Empty);
                }
            });


            KbHook.RegisterHotKey(Keys.F11, args => { }, args =>
            {
                if (KeyboardHook.IsShiftPressed())
                {
                    this.Focus();

                    if (this.WindowState == FormWindowState.Minimized)
                    {
                        this.WindowState = FormWindowState.Normal;
                    }

                    if (Properties.Settings.Default.beeper)
                    {
                        SystemSounds.Beep.Play();
                    }

                    gradientButton7_Click(this, EventArgs.Empty);
                }
            });


            KbHook.RegisterHotKey(Keys.F12, args => { }, args =>
            {
                if (KeyboardHook.IsShiftPressed())
                {
                    this.Focus();

                    if (this.WindowState == FormWindowState.Minimized)
                    {
                        this.WindowState = FormWindowState.Normal;
                    }

                    if (Properties.Settings.Default.beeper)
                    {
                        SystemSounds.Beep.Play();
                    }

                    gradientButton8_Click(this, EventArgs.Empty);
                }
            });

            KbHook.RegisterHotKey(Keys.Escape, args => { }, args =>
            {
                if (KeyboardHook.IsShiftPressed())
                {
                    this.Focus();

                    if (this.WindowState == FormWindowState.Minimized)
                    {
                        this.WindowState = FormWindowState.Normal;
                    }

                    if (Properties.Settings.Default.beeper)
                    {
                        SystemSounds.Beep.Play();
                    }

                    gradientButton2_Click(this, EventArgs.Empty);
                }
            });
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
            WindowState = FormWindowState.Minimized;
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
            try
            {
                colorDialog1 = new ColorDialog();
                colorDialog1.Color = circleClockTimer1.TextColor;
                colorDialog1.ShowDialog();
                circleClockTimer1.TextColor = colorDialog1.Color;
                Properties.Settings.Default.textcolor = colorDialog1.Color.ToArgb();
                Properties.Settings.Default.Save();
            }
            catch (Exception) { }
        }

        private void setRingColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                colorDialog1 = new ColorDialog();
                colorDialog1.Color = circleClockTimer1.BorderColor;
                colorDialog1.ShowDialog();
                circleClockTimer1.BorderColor = colorDialog1.Color;
                Properties.Settings.Default.ringcolor = colorDialog1.Color.ToArgb();
                Properties.Settings.Default.Save();
            }
            catch (Exception) { }
        }

        private void setRingProgressColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                colorDialog1 = new ColorDialog();
                colorDialog1.Color = circleClockTimer1.PieColor;
                colorDialog1.ShowDialog();
                circleClockTimer1.PieColor = colorDialog1.Color;
                Properties.Settings.Default.ringprogresscolor = colorDialog1.Color.ToArgb();
                Properties.Settings.Default.Save();
            }
            catch (Exception) { }
        }

        private void setButtonColorAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                colorDialog1 = new ColorDialog();
                colorDialog1.Color = gradientButton1.StartColor;
                colorDialog1.ShowDialog();
                gradientButton1.StartColor = colorDialog1.Color;
                gradientButton2.StartColor = colorDialog1.Color;
                gradientButton3.StartColor = colorDialog1.Color;
                gradientButton4.StartColor = colorDialog1.Color;
                gradientButton5.StartColor = colorDialog1.Color;
                gradientButton6.StartColor = colorDialog1.Color;
                gradientButton7.StartColor = colorDialog1.Color;
                gradientButton8.StartColor = colorDialog1.Color;
                Properties.Settings.Default.btncolorA = colorDialog1.Color.ToArgb();
                Properties.Settings.Default.Save();
            }
            catch (Exception) { }
        }

        private void setButtonColorBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                colorDialog1 = new ColorDialog();
                colorDialog1.Color = gradientButton1.EndColor;
                colorDialog1.ShowDialog();
                gradientButton1.EndColor = colorDialog1.Color;
                gradientButton2.EndColor = colorDialog1.Color;
                gradientButton3.EndColor = colorDialog1.Color;
                gradientButton4.EndColor = colorDialog1.Color;
                gradientButton5.EndColor = colorDialog1.Color;
                gradientButton6.EndColor = colorDialog1.Color;
                gradientButton7.EndColor = colorDialog1.Color;
                gradientButton8.EndColor = colorDialog1.Color;
                Properties.Settings.Default.btncolorB = colorDialog1.Color.ToArgb();
                Properties.Settings.Default.Save();
            }
            catch (Exception) { }
        }

        private void setFontSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                fontDialog1 = new FontDialog();
                fontDialog1.Font = circleClockTimer1.Font;
                fontDialog1.ShowDialog();
                circleClockTimer1.Font = fontDialog1.Font;
                Properties.Settings.Default.fontname = fontDialog1.Font.Name;
                Properties.Settings.Default.fontsize = fontDialog1.Font.Size;
                Properties.Settings.Default.fontstyle = (int)fontDialog1.Font.Style;
                Properties.Settings.Default.Save();
            }
            catch (Exception) { }
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
                    gradientButton5.GradientMode = (System.Drawing.Drawing2D.LinearGradientMode)selectedGradient;
                    gradientButton6.GradientMode = (System.Drawing.Drawing2D.LinearGradientMode)selectedGradient;
                    gradientButton7.GradientMode = (System.Drawing.Drawing2D.LinearGradientMode)selectedGradient;
                    gradientButton8.GradientMode = (System.Drawing.Drawing2D.LinearGradientMode)selectedGradient;
                    Properties.Settings.Default.btngradtype = selectedGradient.ToString();
                    Properties.Settings.Default.Save();
                }
            }
        }

        private void setBackgroundColorAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                colorDialog1 = new ColorDialog();
                colorDialog1.Color = gradientPanel1.StartColor;
                colorDialog1.ShowDialog();
                gradientPanel1.StartColor = colorDialog1.Color;
                circleClockTimer1.StartColor = colorDialog1.Color;
                Properties.Settings.Default.bgcolorA = colorDialog1.Color.ToArgb();
                Properties.Settings.Default.Save();
            }
            catch (Exception) { }
        }

        private void setBackgroundColorBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                colorDialog1 = new ColorDialog();
                colorDialog1.Color = gradientPanel1.EndColor;
                colorDialog1.ShowDialog();
                gradientPanel1.EndColor = colorDialog1.Color;
                circleClockTimer1.EndColor = colorDialog1.Color;
                Properties.Settings.Default.bgcolorB = colorDialog1.Color.ToArgb();
                Properties.Settings.Default.Save();
            }
            catch (Exception) { }
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
                    Properties.Settings.Default.bggradtype = selectedGradient.ToString();
                    Properties.Settings.Default.Save();
                }
            }
        }

        private void gradientButton5_Click(object sender, EventArgs e)
        {
            circleClockTimer1.TimeLimitInMinutes = 1;
            circleClockTimer1.Reset();
            circleClockTimer1.Start();
        }

        private void gradientButton6_Click(object sender, EventArgs e)
        {
            circleClockTimer1.TimeLimitInMinutes = 3;
            circleClockTimer1.Reset();
            circleClockTimer1.Start();
        }

        private void gradientButton7_Click(object sender, EventArgs e)
        {
            circleClockTimer1.TimeLimitInMinutes = 5;
            circleClockTimer1.Reset();
            circleClockTimer1.Start();
        }

        private void gradientButton8_Click(object sender, EventArgs e)
        {
            circleClockTimer1.TimeLimitInMinutes = 10;
            circleClockTimer1.Reset();
            circleClockTimer1.Start();
        }
        private void trueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.beeper = true;
            Properties.Settings.Default.Save();
        }

        private void falseToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Properties.Settings.Default.beeper = false; 
           Properties.Settings.Default.Save();
        }
    }
}
