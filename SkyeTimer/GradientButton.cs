using System.Drawing.Drawing2D;
namespace SkyeTimer
{
    public class GradientButton : Button
    {
        private Color startColor = Color.LightBlue;
        private Color endColor = Color.DarkBlue;
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

        public GradientButton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(120, 40);
            this.BackColor = startColor;
            this.ForeColor = Color.White;
            this.Paint += RoundedGradientButton_Paint;
        }

        private void RoundedGradientButton_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath path = GetRoundRectPath(this.ClientRectangle, 10); // Adjust the radius as needed

            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, StartColor, EndColor, GradientMode))
            {
                e.Graphics.FillPath(brush, path);
            }

            TextRenderer.DrawText(e.Graphics, this.Text, this.Font, this.ClientRectangle, this.ForeColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }

        private GraphicsPath GetRoundRectPath(Rectangle rectangle, int radius)
        {
            GraphicsPath path = new GraphicsPath();

            path.AddArc(rectangle.X, rectangle.Y, radius * 2, radius * 2, 180, 90);  // Top-left corner
            path.AddArc(rectangle.Right - radius * 2, rectangle.Y, radius * 2, radius * 2, 270, 90);  // Top-right corner
            path.AddArc(rectangle.Right - radius * 2, rectangle.Bottom - radius * 2, radius * 2, radius * 2, 0, 90);  // Bottom-right corner
            path.AddArc(rectangle.X, rectangle.Bottom - radius * 2, radius * 2, radius * 2, 90, 90);  // Bottom-left corner
            path.CloseFigure();

            return path;
        }
    }
}
