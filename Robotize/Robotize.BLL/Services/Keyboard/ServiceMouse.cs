using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Robotize.BLL.Contracts;
using RobotizeFacebook.Services;
using RobotizeFacebook.Utilities;
using WindowGrid.Services;

namespace Robotize.BLL.Services.Keyboard
{
    public class ServiceMouse : IServiceMouse
    {
        static Rectangle ScreenScale { get; set; }
        Dictionary<int, Point> Coordinates = new Dictionary<int, Point>();
        public ServiceMouse()
        {
            // TODO: Make this values avaliable in buffer for quick access.
            AppSettings.EnvironmentSettingsFile = ConfigurationManager.AppSettings[nameof(AppSettings.EnvironmentSettingsFile)];
            ScreenScale = EnvironmentSettings.SettingsData.Details.ScreenScale;
            Coordinates = EnvironmentSettings.SettingsData.Details.ScreenCoordinates;
        }

        //https://msdn.microsoft.com/en-us/library/windows/desktop/ms646270(v=vs.85).aspx
        [StructLayout(LayoutKind.Sequential)]
        struct INPUT
        {
            public int type; // 0 = INPUT_MOUSE,
                             // 1 = INPUT_KEYBOARD
                             // 2 = INPUT_HARDWARE
            public MOUSEINPUT mi;
        }

        //https://msdn.microsoft.com/en-us/library/windows/desktop/ms646273(v=vs.85).aspx
        [StructLayout(LayoutKind.Sequential)]
        struct MOUSEINPUT
        {
            public int dx;
            public int dy;
            public int mouseData;
            public int dwFlags;
            public int time;
            public IntPtr dwExtraInfo;
        }

        [StructLayout(LayoutKind.Sequential)]
        struct ScrollWindowEx {
            IntPtr hWnd;
            int dx;
            int dy;
            IntPtr prcScroll;
            IntPtr prcClip;
            IntPtr hrgnUpdate;
            IntPtr prcUpdate;
            short flags;
        }

        //This covers most use cases although complex mice may have additional buttons
        //There are additional constants you can use for those cases, see the msdn page
        const int MOUSEEVENTF_MOVED = 0x0001;
        const int MOUSEEVENTF_LEFTDOWN = 0x0002;
        const int MOUSEEVENTF_LEFTUP = 0x0004;
        const int MOUSEEVENTF_RIGHTDOWN = 0x0008;
        const int MOUSEEVENTF_RIGHTUP = 0x0010;
        const int MOUSEEVENTF_MIDDLEDOWN = 0x0020;
        const int MOUSEEVENTF_MIDDLEUP = 0x0040;
        const int MOUSEEVENTF_WHEEL = 0x0080;
        const int MOUSEEVENTF_XDOWN = 0x0100;
        const int MOUSEEVENTF_XUP = 0x0200;
        const int MOUSEEVENTF_ABSOLUTE = 0x8000;

        const int screen_length = 0x10000;

        //https://msdn.microsoft.com/en-us/library/windows/desktop/ms646310(v=vs.85).aspx
        [DllImport("user32.dll")]
        extern static uint SendInput(uint nInputs, INPUT[] pInputs, int cbSize);


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

        public static Point Position { get; set; }

        public Task<bool> GoToXY(int index)
        {
            var currentPostion = PSServiceMouse.GetCursorPostions();
            INPUT[] input = new INPUT[3];
            input[0].mi.dx = Coordinates[index].X * (65535 / ScreenScale.Width);
            input[0].mi.dy = Coordinates[index].Y * (65535 / ScreenScale.Height);
            return Task.FromResult(true);
        }

        public Task<bool> ScrollUp(int index)
        {
            GoToXY(index);
            //Move the mouse
            INPUT[] input = new INPUT[3];

            //input[0].mi.dx = Coordinates[index].X * (65535 / ScreenScale.Width);
            //input[0].mi.dy = Coordinates[index].Y * (65535 / ScreenScale.Height);
            //input[0].mi.dwFlags = MOUSEEVENTF_MOVED | MOUSEEVENTF_ABSOLUTE;
            //Left mouse button down
            input[1].mi.dwFlags = MOUSEEVENTF_WHEEL;
            //Left mouse button up
            input[2].mi.mouseData = screen_length;
            SendInput(3, input, Marshal.SizeOf(input[0]));
            return Task.FromResult(true);
        }
    }
}
