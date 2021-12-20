using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AllTours
{
    public static class DragForm
    {
        //код для реализации перетаскивания
        [DllImport("user32", CharSet = CharSet.Auto)]
        internal extern static bool PostMessage(IntPtr hWnd, uint Msg, uint WParam, uint LParam);

        [DllImport("user32", CharSet = CharSet.Auto)]
        internal extern static bool ReleaseCapture();

        public const uint WM_SYSCOMMAND = 0x0112;
        public const uint DOMOVE = 0xF012;
        public const uint DOSIZE = 0xF008;
        //код для реализации перетаскивания
    }
}
