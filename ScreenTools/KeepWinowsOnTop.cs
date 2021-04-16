using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;
using RobotizeFacebook.Services;
using RobotizeFacebook.Utilities;
using System.Runtime.InteropServices;
using System;

namespace ScreenTools
{
    public class KeepWinowsOnTop
    {
        /// <summary>
        /// <see cref="https://stackoverflow.com/questions/683330/how-to-make-a-window-always-stay-on-top-in-net"/>
        /// </summary>
        // Variables for keeping the window always on top.
        private static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);
        private const uint SWP_NOSIZE = 0x0001;
        private const uint SWP_NOMOVE = 0x0002;
        private const uint TOPMOST_FLAGS = SWP_NOMOVE | SWP_NOSIZE;

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

        
        public static void SetWindowAlwaysOnTop(IntPtr handle)
        {
            SetWindowPos(handle, HWND_TOPMOST, 0, 0, 0, 0, TOPMOST_FLAGS);
        }
    }
}
