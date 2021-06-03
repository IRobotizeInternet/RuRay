using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using RuRay.BLL.Contracts;
using RuRayFacebook.Services;
using RuRayFacebook.Utilities;

namespace RuRay.BLL.Services.Keyboard
{
    /// <summary>
    /// Defines the <see cref="ServiceMouse" />.
    /// </summary>
    public class ServiceMouse : IServiceMouse
    {
        /// <summary>
        /// Gets or sets the ScreenScale.
        /// </summary>
        internal static Rectangle ScreenScale { get; set; }

        /// <summary>
        /// Defines the Coordinates.
        /// </summary>
        internal readonly Dictionary<int, Point> Coordinates = new Dictionary<int, Point>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceMouse"/> class.
        /// </summary>
        public ServiceMouse()
        {
            // TODO: Make this values avaliable in buffer for quick access.
            AppSettings.EnvironmentSettingsFile = ConfigurationManager.AppSettings[nameof(AppSettings.EnvironmentSettingsFile)];
            ScreenScale = EnvironmentSettings.SettingsData().Details.ScreenScale;
            Coordinates = EnvironmentSettings.SettingsData().Details.ScreenCoordinates;
        }

        //https://msdn.microsoft.com/en-us/library/windows/desktop/ms646270(v=vs.85).aspx
        /// <summary>
        /// Defines the <see cref="INPUT" />.
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        struct INPUT
        {
            /// <summary>
            /// Defines the type.
            /// </summary>
            public int type;// 0 = INPUT_MOUSE,

            // 1 = INPUT_KEYBOARD
            // 2 = INPUT_HARDWARE
            /// <summary>
            /// Defines the mi.
            /// </summary>
            public MOUSEINPUT mi;
        }

        //https://msdn.microsoft.com/en-us/library/windows/desktop/ms646273(v=vs.85).aspx
        /// <summary>
        /// Defines the <see cref="MOUSEINPUT" />.
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        struct MOUSEINPUT
        {
            /// <summary>
            /// Defines the dx.
            /// </summary>
            public int dx;

            /// <summary>
            /// Defines the dy.
            /// </summary>
            public int dy;

            /// <summary>
            /// Defines the mouseData.
            /// </summary>
            public int mouseData;

            /// <summary>
            /// Defines the dwFlags.
            /// </summary>
            public int dwFlags;

            /// <summary>
            /// Defines the time.
            /// </summary>
            public int time;

            /// <summary>
            /// Defines the dwExtraInfo.
            /// </summary>
            public IntPtr dwExtraInfo;
        }

        /// <summary>
        /// Defines the <see cref="ScrollWindowEx" />.
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        struct ScrollWindowEx
        {
            /// <summary>
            /// Defines the hWnd.
            /// </summary>
            internal readonly IntPtr hWnd;

            /// <summary>
            /// Defines the dx.
            /// </summary>
            internal readonly int dx;

            /// <summary>
            /// Defines the dy.
            /// </summary>
            internal readonly int dy;

            /// <summary>
            /// Defines the prcScroll.
            /// </summary>
            internal readonly IntPtr prcScroll;

            /// <summary>
            /// Defines the prcClip.
            /// </summary>
            internal readonly IntPtr prcClip;

            /// <summary>
            /// Defines the hrgnUpdate.
            /// </summary>
            internal readonly IntPtr hrgnUpdate;

            /// <summary>
            /// Defines the prcUpdate.
            /// </summary>
            internal readonly IntPtr prcUpdate;

            /// <summary>
            /// Defines the flags.
            /// </summary>
            internal readonly short flags;
        }

        //This covers most use cases although complex mice may have additional buttons
        //There are additional constants you can use for those cases, see the msdn page
        /// <summary>
        /// Defines the MOUSEEVENTF_MOVED.
        /// </summary>
        internal const int MOUSEEVENTF_MOVED = 0x0001;

        /// <summary>
        /// Defines the MOUSEEVENTF_LEFTDOWN.
        /// </summary>
        internal const int MOUSEEVENTF_LEFTDOWN = 0x0002;

        /// <summary>
        /// Defines the MOUSEEVENTF_LEFTUP.
        /// </summary>
        internal const int MOUSEEVENTF_LEFTUP = 0x0004;

        /// <summary>
        /// Defines the MOUSEEVENTF_RIGHTDOWN.
        /// </summary>
        internal const int MOUSEEVENTF_RIGHTDOWN = 0x0008;

        /// <summary>
        /// Defines the MOUSEEVENTF_RIGHTUP.
        /// </summary>
        internal const int MOUSEEVENTF_RIGHTUP = 0x0010;

        /// <summary>
        /// Defines the MOUSEEVENTF_MIDDLEDOWN.
        /// </summary>
        internal const int MOUSEEVENTF_MIDDLEDOWN = 0x0020;

        /// <summary>
        /// Defines the MOUSEEVENTF_MIDDLEUP.
        /// </summary>
        internal const int MOUSEEVENTF_MIDDLEUP = 0x0040;

        /// <summary>
        /// Defines the MOUSEEVENTF_WHEEL.
        /// </summary>
        internal const int MOUSEEVENTF_WHEEL = 0x0080;

        /// <summary>
        /// Defines the MOUSEEVENTF_XDOWN.
        /// </summary>
        internal const int MOUSEEVENTF_XDOWN = 0x0100;

        /// <summary>
        /// Defines the MOUSEEVENTF_XUP.
        /// </summary>
        internal const int MOUSEEVENTF_XUP = 0x0200;

        /// <summary>
        /// Defines the MOUSEEVENTF_ABSOLUTE.
        /// </summary>
        internal const int MOUSEEVENTF_ABSOLUTE = 0x8000;

        /// <summary>
        /// Defines the screen_length.
        /// </summary>
        internal const int screen_length = 0x10000;

        //https://msdn.microsoft.com/en-us/library/windows/desktop/ms646310(v=vs.85).aspx
        /// <summary>
        /// The SendInput.
        /// </summary>
        /// <param name="nInputs">The nInputs<see cref="uint"/>.</param>
        /// <param name="pInputs">The pInputs<see cref="INPUT[]"/>.</param>
        /// <param name="cbSize">The cbSize<see cref="int"/>.</param>
        /// <returns>The <see cref="uint"/>.</returns>
        [DllImport("user32.dll")]
        private extern static uint SendInput(uint nInputs, INPUT[] pInputs, int cbSize);

        /// <summary>
        /// The LeftClickAtPoint.
        /// </summary>
        /// <param name="index">The index<see cref="int"/>.</param>
        /// <returns>The <see cref="Task{bool}"/>.</returns>
        public Task<bool> LeftClickAtPoint(int index)
        {
            //Move the mouse
            INPUT[] input = new INPUT[3];
            input[0].mi.dx = Coordinates[index].X * (65535 / ScreenScale.Width);
            input[0].mi.dy = Coordinates[index].Y * (65535 / ScreenScale.Height);
            input[0].mi.dwFlags = MOUSEEVENTF_MOVED | MOUSEEVENTF_ABSOLUTE;
            //Left mouse button down
            input[1].mi.dwFlags = MOUSEEVENTF_LEFTDOWN;
            //Left mouse button up
            input[2].mi.dwFlags = MOUSEEVENTF_LEFTUP;
            SendInput(3, input, Marshal.SizeOf(input[0]));
            return Task.FromResult(true);
        }

        /// <summary>
        /// The RightClickAtPoint.
        /// </summary>
        /// <param name="index">The index<see cref="int"/>.</param>
        /// <returns>The <see cref="Task{bool}"/>.</returns>
        public Task<bool> RightClickAtPoint(int index)
        {
            GoToXY(index);
            //Move the mouse
            INPUT[] input = new INPUT[3];
            //input[0].mi.dwFlags = MOUSEEVENTF_MOVED | MOUSEEVENTF_ABSOLUTE;
            //Left mouse button down
            input[1].mi.dwFlags = MOUSEEVENTF_RIGHTDOWN;
            //Left mouse button up
            input[2].mi.dwFlags = MOUSEEVENTF_RIGHTUP;
            SendInput(3, input, Marshal.SizeOf(input[0]));
            return Task.FromResult(true);
        }

        /// <summary>
        /// Gets or sets the Position.
        /// </summary>
        public static Point Position { get; set; }

        /// <summary>
        /// The GoToXY.
        /// </summary>
        /// <param name="index">The index<see cref="int"/>.</param>
        /// <returns>The <see cref="Task{bool}"/>.</returns>
        public Task<bool> GoToXY(int index)
        {
            const string serviceName = "PS1\\CursorPostion.ps1";
            AppSettings.PowerShellOutputFile = ConfigurationManager.AppSettings[nameof(AppSettings.PowerShellOutputFile)];
            ServiceTask.RunScript(serviceName, Path.Combine(EnvironmentSettings.DirectoryPath, AppSettings.PowerShellOutputFile));
            var details = EnvironmentSettings.SettingsData(AppSettings.PowerShellOutputFile).Details;

            INPUT[] input = new INPUT[3];
            input[0].mi.dx = Coordinates[index].X * (65535 / ScreenScale.Width);
            input[0].mi.dy = Coordinates[index].Y * (65535 / ScreenScale.Height);
            input[0].mi.dwFlags = MOUSEEVENTF_MOVED | MOUSEEVENTF_ABSOLUTE;
            SendInput(3, input, Marshal.SizeOf(input[0]));

            // TODO: Complete this random moving of cursor from src to destination.
            var xDistance = Math.Abs(Coordinates[index].X) - Math.Abs(details.xAxis);
            var yDistance = Math.Abs(Coordinates[index].Y) - Math.Abs(details.yAxis);
            int totalDistanceToTravel = (int)Math.Sqrt((xDistance * xDistance) + (yDistance * yDistance));
            var random = new Random();
            // move the cursor in steps based on the number below.
            //var availableStep = new List<int> { 0, 1, 2, 3 };
            //for(var i=0;i< totalDistanceToTravel;i++)
            //{
            //    int newxStep = random.Next(availableStep.Count);

            //    input[0].mi.dx = Coordinates[index].X * (65535 / ScreenScale.Width);
            //    input[0].mi.dy = Coordinates[index].Y * (65535 / ScreenScale.Height);
            //    input[0].mi.dwFlags = MOUSEEVENTF_MOVED | MOUSEEVENTF_ABSOLUTE;
            //    SendInput(3, input, Marshal.SizeOf(input[0]));
            //}

            return Task.FromResult(true);
        }

        /// <summary>
        /// The ScrollUp.
        /// </summary>
        /// <param name="index">The index<see cref="int"/>.</param>
        /// <returns>The <see cref="Task{bool}"/>.</returns>
        public Task<bool> ScrollUp(int index)
        {
            GoToXY(index);
            //Move the mouse
            INPUT[] input = new INPUT[3];

            //Left mouse button down
            input[1].mi.dwFlags = MOUSEEVENTF_WHEEL;
            //Left mouse button up
            input[2].mi.mouseData = screen_length;
            SendInput(3, input, Marshal.SizeOf(input[0]));
            return Task.FromResult(true);
        }
    }
}
