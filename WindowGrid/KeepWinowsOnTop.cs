using System;
using System.Runtime.InteropServices;

namespace WindowGrid
{
    /// <summary>
    /// Defines the <see cref="KeepWinowsOnTop" />.
    /// </summary>
    public class KeepWinowsOnTop
    {
        /// <summary>
        /// <see cref="https://stackoverflow.com/questions/683330/how-to-make-a-window-always-stay-on-top-in-net"/>.
        /// </summary>
        private static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);

        /// <summary>
        /// Defines the SWP_NOSIZE.
        /// </summary>
        private const uint SWP_NOSIZE = 0x0001;

        /// <summary>
        /// Defines the SWP_NOMOVE.
        /// </summary>
        private const uint SWP_NOMOVE = 0x0002;

        /// <summary>
        /// Defines the TOPMOST_FLAGS.
        /// </summary>
        private const uint TOPMOST_FLAGS = SWP_NOMOVE | SWP_NOSIZE;

        /// <summary>
        /// The SetWindowPos.
        /// </summary>
        /// <param name="hWnd">The hWnd<see cref="IntPtr"/>.</param>
        /// <param name="hWndInsertAfter">The hWndInsertAfter<see cref="IntPtr"/>.</param>
        /// <param name="X">The X<see cref="int"/>.</param>
        /// <param name="Y">The Y<see cref="int"/>.</param>
        /// <param name="cx">The cx<see cref="int"/>.</param>
        /// <param name="cy">The cy<see cref="int"/>.</param>
        /// <param name="uFlags">The uFlags<see cref="uint"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

        /// <summary>
        /// The SetWindowAlwaysOnTop.
        /// </summary>
        /// <param name="handle">The handle<see cref="IntPtr"/>.</param>
        public static void SetWindowAlwaysOnTop(IntPtr handle)
        {
            SetWindowPos(handle, HWND_TOPMOST, 0, 0, 0, 0, TOPMOST_FLAGS);
        }
    }
}
