using System.Drawing.Drawing2D;
using System;
using System.IO;
using System.Media;
using System.Reflection;
using Timer = System.Windows.Forms.Timer;
namespace SkyeTimer
{
    public class CircleClockTimer : Control
    {
        private Timer timer;
        private int secondsElapsed;
        private int timeLimitInSeconds;
        private Color startColor = Color.Blue;
        private Color endColor  = Color.Red;
        private LinearGradientMode gradientMode = LinearGradientMode.Horizontal;
        private Color textColor = Color.Teal;
        private Color pieColor = Color.White;
        private Color borderColor = Color.Black;
        private Font font = new Font(FontFamily.GenericSansSerif, 16);

        public Color StartColor
        {
            get { return startColor; }
            set
            {
                startColor = value;
                Invalidate();
            }
        }

        public Color EndColor
        {
            get { return endColor; }
            set
            {
                endColor = value;
                Invalidate();
            }
        }

        public LinearGradientMode GradientMode
        {
            get { return gradientMode; }
            set
            {
                gradientMode = value;
                Invalidate();
            }
        }

        public Color TextColor
        {
            get { return textColor; }
            set
            {
                textColor = value;
                Invalidate();
            }
        }

        public Color PieColor
        {
            get { return pieColor; }
            set
            {
                pieColor = value;
                Invalidate();
            }
        }

        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                Invalidate();
            }
        }

        public Font Font
        {
            get { return font; }
            set
            {
                font = value;
                Invalidate();
            }
        }

        public int TimeLimitInMinutes
        {
            get { return timeLimitInSeconds / 60; }
            set
            {
                timeLimitInSeconds = value * 60;
                Invalidate();
            }
        }

        public CircleClockTimer()
        {
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            this.DoubleBuffered = true;
            this.Size = new Size(300, 300);
            this.BackColor = Color.White;
            this.TimeLimitInMinutes = 5;

            timer.Stop();
            this.Invalidate();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            secondsElapsed++;
            this.Invalidate();
            if (secondsElapsed >= timeLimitInSeconds)
            {
                timer.Stop();
                SoundPlayer soundPlayer = new SoundPlayer("ring.wav");
                soundPlayer.Play();
            }
        }

        public void Start()
        {
            timer.Start();
        }

        public void Stop()
        {
            timer.Stop();
        }

        public void Reset()
        {
            timer.Stop();
            secondsElapsed = 0;
            this.Invalidate();
        }

        public void Pause()
        {
            timer.Stop();
        }

        public void Resume()
        {
            timer.Start();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            using (LinearGradientBrush brush = new LinearGradientBrush(
               this.ClientRectangle, StartColor, EndColor, GradientMode))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
            int centerX = this.Width / 2;
            int centerY = this.Height / 2;
            int radius = Math.Min(this.Width, this.Height) / 2 - 10;

            float progress = (float)secondsElapsed / timeLimitInSeconds;
            float angle = progress * 360;

            int borderThickness = 5;
            int reducedRadius = radius - borderThickness / 2;

            using (GraphicsPath outerCirclePath = new GraphicsPath())
            {
                outerCirclePath.AddEllipse(centerX - reducedRadius, centerY - reducedRadius, 2 * reducedRadius, 2 * reducedRadius);
                e.Graphics.DrawEllipse(new Pen(this.borderColor, borderThickness), centerX - reducedRadius, centerY - reducedRadius, 2 * reducedRadius, 2 * reducedRadius);
            }

            if (progress > 0)
            {
                using (Pen borderPen = new Pen(this.PieColor, borderThickness))
                {
                    e.Graphics.DrawArc(borderPen, centerX - reducedRadius, centerY - reducedRadius, 2 * reducedRadius, 2 * reducedRadius, -90, angle);
                }
            }

            string timeText = $"{secondsElapsed / 60:D2}:{secondsElapsed % 60:D2}";
            SizeF textSize = e.Graphics.MeasureString(timeText, font);
            PointF textLocation = new PointF(centerX - textSize.Width / 2, centerY - textSize.Height / 2);
            e.Graphics.DrawString(timeText, font, new SolidBrush(this.TextColor), textLocation);
        }

    }
}
