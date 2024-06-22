using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace NET_L3_Zad5_v2
{
    // Importowanie metod z WinAPI
    internal class Win32API
    {
        [DllImport("gdi32.dll")]
        public static extern bool SetPixel(IntPtr hdc, int x, int y, int color);
    }
}
