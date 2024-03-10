using System.Drawing.Drawing2D;
namespace SkyeTimer
{
    public class MySR : ToolStripSystemRenderer
    {
        public MySR()
        {
        }

        protected override void OnRenderButtonBackground(ToolStripItemRenderEventArgs e)
        {
            if (e.Item.Selected)
            {
                Rectangle rc = new Rectangle(0, 1, e.Item.Width - 1, e.Item.Height - 2);
                FillRoundedRectangle(e.Graphics, rc, 10, SystemBrushes.GradientActiveCaption);
                DrawRoundedRectangle(e.Graphics, rc, 5, new Pen(Color.Snow));
            }
        }

        private void MySR_RenderMenuItemBackground(object sender, ToolStripItemRenderEventArgs e)
        {
            Rectangle rc = new Rectangle(Point.Empty, e.Item.Size);
            Color backgroundColor = Color.FromArgb(34, 33, 37);

            if (e.Item.Selected || e.Item.Pressed)
            {
                backgroundColor = Color.Gray; // Change this to the desired background color
                e.Item.BackColor = backgroundColor; // Set the BackColor property
            }
            else
            {
                e.Item.BackColor = Color.Transparent; // Set the BackColor to Transparent for non-selected items
            }

            using (SolidBrush brush = new SolidBrush(backgroundColor))
            {
                e.Graphics.FillRectangle(brush, rc);
            }
        }


        protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
        {
            //base.OnRenderToolStripBorder(e);
        }

        protected override void OnRenderItemBackground(ToolStripItemRenderEventArgs e)
        {
            //base.OnRenderItemBackground(e);
        }

        protected override void OnRenderDropDownButtonBackground(ToolStripItemRenderEventArgs e)
        {
            //base.OnRenderDropDownButtonBackground(e);
        }

        protected override void OnRenderArrow(ToolStripArrowRenderEventArgs e)
        {
            e.ArrowColor = Color.LightGray;
            base.OnRenderArrow(e);
        }

        protected override void OnRenderSeparator(ToolStripSeparatorRenderEventArgs e)
        {
            e.Graphics.DrawLine(new Pen(SystemColors.ControlDark), new Point(0, e.Item.Bounds.Top + 5), new Point(0, e.Item.Bounds.Bottom - 5));
        }


        public void DrawRoundedRectangle(Graphics g, Rectangle r, int d, Pen p)
        {
            g.DrawArc(p, r.X, r.Y, d, d, 180, 90);
            g.DrawLine(p, r.X + d / 2, r.Y, r.X + r.Width - d / 2, r.Y);
            g.DrawArc(p, r.X + r.Width - d, r.Y, d, d, 270, 90);
            g.DrawLine(p, r.X, r.Y + d / 2, r.X, r.Y + r.Height - d / 2);
            g.DrawLine(p, r.X + r.Width, r.Y + d / 2, r.X + r.Width, r.Y + r.Height - d / 2);
            g.DrawLine(p, r.X + d / 2, r.Y + r.Height, r.X + r.Width - d / 2, r.Y + r.Height);
            g.DrawArc(p, r.X, r.Y + r.Height - d, d, d, 90, 90);
            g.DrawArc(p, r.X + r.Width - d, r.Y + r.Height - d, d, d, 0, 90);
        }

        public void FillRoundedRectangle(Graphics g, Rectangle r, int d, Brush b)
        {
            SmoothingMode mode = g.SmoothingMode;
            g.SmoothingMode = SmoothingMode.HighSpeed;
            g.FillPie(b, r.X, r.Y, d, d, 180, 90);
            g.FillPie(b, r.X + r.Width - d, r.Y, d, d, 270, 90);
            g.FillPie(b, r.X, r.Y + r.Height - d, d, d, 90, 90);
            g.FillPie(b, r.X + r.Width - d, r.Y + r.Height - d, d, d, 0, 90);
            g.FillRectangle(b, r.X + d / 2, r.Y, r.Width - d, d / 2);
            g.FillRectangle(b, r.X, r.Y + d / 2, r.Width, r.Height - d);
            g.FillRectangle(b, r.X + d / 2, r.Y + r.Height - d / 2, r.Width - d, d / 2);
            g.SmoothingMode = mode;
        }

        private void MySR_RenderSeparator(object sender, ToolStripSeparatorRenderEventArgs e)
        {
            Rectangle rc = new Rectangle(Point.Empty, e.Item.Size);
            Color c = Color.FromArgb(34, 33, 37);

            using (SolidBrush brush = new SolidBrush(c))
            {
                e.Graphics.FillRectangle(brush, rc);
            }
        }
    }

}
