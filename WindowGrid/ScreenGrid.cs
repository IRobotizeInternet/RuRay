using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RobotizeFacebook.Services;

namespace WindowGrid
{
    public partial class ScreenGrid : Form
    {
        public ScreenGrid(string[] args = null)
        {
            InitializeComponent();
            SetGrid(args);
        }

        Dictionary<int, Point> Coordinates = new Dictionary<int, Point>();
        
        public void SetGrid(string[] args = null)
        {
            // This is where we keep the coordinates, so web api's can read from.
            //AppSettings.EnvironmentSettingsFile = ConfigurationManager.AppSettings[nameof(AppSettings.EnvironmentSettingsFile)];
            int index = 1;

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

            var sizeValue = args != null && args.Any() ? int.Parse(args[0]) : 100;
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
            var details = EnvironmentSettings.SettingsData().Details ?? new EnvironmentSettingsDTO();
            details.ScreenCoordinates = Coordinates;
            details.ScreenScale = screenScale;
            EnvironmentSettings.SettingsData().Details = details;
        }

        private void label1_Click(object sender, EventArgs e)
        {
             
        }
    }
}
