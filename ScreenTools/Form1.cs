using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;
using RobotizeFacebook.Services;
using RobotizeFacebook.Utilities;
using System.Runtime.InteropServices;
using System;
using System.Linq;
using System.Threading;

namespace ScreenTools
{
    public partial class ScreenGrid : Form
    {
        Dictionary<int, Point> Coordinates = new Dictionary<int, Point>();

        public ScreenGrid(string[] args)
        {
            // This is where we keep the coordinates, so web api's can read from.
            AppSettings.EnvironmentSettingsFile = ConfigurationManager.AppSettings[nameof(AppSettings.EnvironmentSettingsFile)];
            int index = 1;

            InitializeComponent();

            // Remove the min max top bar from window.
            FormBorderStyle = FormBorderStyle.None;

            // Hide the icon taskbar
            ShowInTaskbar = false;
            WindowState = FormWindowState.Maximized;
           
            // Keep the application always on top and focused.
            KeepWinowsOnTop.SetWindowAlwaysOnTop(Handle);

            var screenScale = Screen.FromControl(this).Bounds;
            

            // Make backbroud transparent.
            TransparencyKey = BackColor;

            var sizeValue = args.Any() ? int.Parse(args[0]) : 100;
            // Fill the windows screen with label. 
            for (var i = 0; i < screenScale.Width; i += sizeValue)
            {
                for (var j = 0; j < screenScale.Height - sizeValue; j += sizeValue)
                {
                    Controls.Add(new Label
                    {
                        Location = new Point(i, j),
                        Text = $"{index++}",
                        Size = new Size(sizeValue, sizeValue),
                        BorderStyle = BorderStyle.FixedSingle,
                        Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0)
                    });
                }
            }

            var indexx = 1;
            foreach (Label control in Controls)
            {
                //control.Text = control.Text + " " + control.PointToScreen(Point.Empty);
                // Find and add coordinates for each control on the window.
                Coordinates.Add(indexx++, control.PointToScreen(Point.Empty));
            }

            // Save the coordinates to the file.
            var details = EnvironmentSettings.SettingsData.Details ?? new EnvironmentSettingsDTO ();
            details.ScreenCoordinates = Coordinates;
            details.ScreenScale = screenScale;
            EnvironmentSettings.SettingsData.Details = details; 
        }
    }

    //public class Clicker
    //{
    //    //https://msdn.microsoft.com/en-us/library/windows/desktop/ms646270(v=vs.85).aspx
    //    [StructLayout(LayoutKind.Sequential)]
    //    struct INPUT
    //    {
    //        public int type; // 0 = INPUT_MOUSE,
    //                         // 1 = INPUT_KEYBOARD
    //                         // 2 = INPUT_HARDWARE
    //        public MOUSEINPUT mi;
    //    }

    //    //https://msdn.microsoft.com/en-us/library/windows/desktop/ms646273(v=vs.85).aspx
    //    [StructLayout(LayoutKind.Sequential)]
    //    struct MOUSEINPUT
    //    {
    //        public int dx;
    //        public int dy;
    //        public int mouseData;
    //        public int dwFlags;
    //        public int time;
    //        public IntPtr dwExtraInfo;
    //    }

    //    //This covers most use cases although complex mice may have additional buttons
    //    //There are additional constants you can use for those cases, see the msdn page
    //    const int MOUSEEVENTF_MOVED = 0x0001;
    //    const int MOUSEEVENTF_LEFTDOWN = 0x0002;
    //    const int MOUSEEVENTF_LEFTUP = 0x0004;
    //    const int MOUSEEVENTF_RIGHTDOWN = 0x0008;
    //    const int MOUSEEVENTF_RIGHTUP = 0x0010;
    //    const int MOUSEEVENTF_MIDDLEDOWN = 0x0020;
    //    const int MOUSEEVENTF_MIDDLEUP = 0x0040;
    //    const int MOUSEEVENTF_WHEEL = 0x0080;
    //    const int MOUSEEVENTF_XDOWN = 0x0100;
    //    const int MOUSEEVENTF_XUP = 0x0200;
    //    const int MOUSEEVENTF_ABSOLUTE = 0x8000;

    //    const int screen_length = 0x10000;

    //    //https://msdn.microsoft.com/en-us/library/windows/desktop/ms646310(v=vs.85).aspx
    //    [DllImport("user32.dll")]
    //    extern static uint SendInput(uint nInputs, INPUT[] pInputs, int cbSize);

    //    public static void LeftClickAtPoint(int x, int y)
    //    {
    //        //Move the mouse
    //        INPUT[] input = new INPUT[3];
    //        input[0].mi.dx = x * (65535 / System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width);
    //        input[0].mi.dy = y * (65535 / System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height);
    //        input[0].mi.dwFlags = MOUSEEVENTF_MOVED | MOUSEEVENTF_ABSOLUTE;
    //        //Left mouse button down
    //        input[1].mi.dwFlags = MOUSEEVENTF_LEFTDOWN;
    //        //Left mouse button up
    //        input[2].mi.dwFlags = MOUSEEVENTF_LEFTUP;
    //        SendInput(3, input, Marshal.SizeOf(input[0]));
    //    }

    //    public static void RightClickAtPoint(int x, int y)
    //    {
    //        //Move the mouse
    //        INPUT[] input = new INPUT[3];
    //        input[0].mi.dx = x * (65535 / System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width);
    //        input[0].mi.dy = y * (65535 / System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height);
    //        input[0].mi.dwFlags = MOUSEEVENTF_MOVED | MOUSEEVENTF_ABSOLUTE;
    //        //Left mouse button down
    //        input[1].mi.dwFlags = MOUSEEVENTF_RIGHTDOWN;
    //        //Left mouse button up
    //        input[2].mi.dwFlags = MOUSEEVENTF_RIGHTUP;
    //        SendInput(3, input, Marshal.SizeOf(input[0]));
    //    }
    //}
}
