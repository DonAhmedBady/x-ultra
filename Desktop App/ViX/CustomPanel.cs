using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controller
{
    class CustomPanel : Panel
    {
        private Color color1 = Color.SteelBlue;
        private Color color2 = Color.DarkBlue;
        private int color1Transparent = 30;
        private int color2Transparent = 60;
        private int angle = 90;
        public Color StartColor
        {
            get { return color1; }
            set { color1 = value; Invalidate(); }
        }
        public Color EndColor
        {
            get { return color2; }
            set { color2 = value; Invalidate(); }
        }
        public int Transparent1
        {
            get { return color1Transparent; }
            set
            {
                color1Transparent = value;
                if (color1Transparent > 255)
                {
                    color1Transparent = 255;
                    Invalidate();
                }
                else
                    Invalidate();
            }
        }
        public int Transparent2
        {
            get { return color2Transparent; }
            set
            {
                color2Transparent = value;
                if (color2Transparent > 255)
                {
                    color2Transparent = 255;
                    Invalidate();
                }
                else
                    Invalidate();
            }
        }
        public int GradientAngle
        {
            get { return angle; }
            set { angle = value; Invalidate(); }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Color c1 = Color.FromArgb(color1Transparent, color1);
            Color c2 = Color.FromArgb(color2Transparent, color2);
            Brush b = new System.Drawing.Drawing2D.LinearGradientBrush(ClientRectangle, c1, c2, angle);
            e.Graphics.FillRectangle(b, ClientRectangle);
            b.Dispose();
        }
        private Point mousePoint;
        protected override void OnMouseDown(MouseEventArgs mea)
        {
            mousePoint = new Point(-mea.X, -mea.Y);
            base.OnMouseDown(mea);
        }
        protected override void OnMouseMove(MouseEventArgs mea)
        {
            if (mea.Button == MouseButtons.Left)
            {
                Point mousePosition = Control.MousePosition;
                mousePosition.Offset(mousePoint.X, mousePoint.Y);
                this.FindForm().Location = mousePosition;
            }
            base.OnMouseMove(mea);
        }
    }
}
