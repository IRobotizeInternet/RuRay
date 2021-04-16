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
    public partial class ScreenGrid : Form
    {
        Dictionary<int, Point> Coordinates = new Dictionary<int, Point>();

        public ScreenGrid()
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

            var sizeValue = 150;
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
            EnvironmentSettings.SettingsData.Details = details;
        }
    }
}
