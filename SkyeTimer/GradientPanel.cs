    using System.Drawing.Drawing2D;
namespace SkyeTimer
{
    public class GradientPanel : Panel
    {
        private Color startColor;
        private Color endColor;
        private LinearGradientMode gradientMode;

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

        public GradientPanel()
        {
            StartColor = Color.FromArgb(255, 255, 255);
            EndColor = Color.FromArgb(192, 192, 192);
            GradientMode = LinearGradientMode.ForwardDiagonal;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            using (LinearGradientBrush brush = new LinearGradientBrush(
                this.ClientRectangle, StartColor, EndColor, GradientMode))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }
    }

}
