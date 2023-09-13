using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViX
{
    class Utils
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeigthEllipse
        );
        public static void CreateRoundedCorners(Control control, int controlWidth, int controlHeight)
        {
            control.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, controlWidth, controlHeight, 20, 20));
        }
    }
}
