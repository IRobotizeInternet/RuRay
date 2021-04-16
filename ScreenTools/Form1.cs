using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;
using RobotizeFacebook.Services;
using RobotizeFacebook.Utilities;

namespace ScreenTools
{
    public partial class ScreenGrid : Form
    {
        Dictionary<int, Point> Coordinates = new Dictionary<int, Point>();

        public ScreenGrid()
        {
            AppSettings.EnvironmentSettingsFile = ConfigurationManager.AppSettings[nameof(AppSettings.EnvironmentSettingsFile)];
            InitializeComponent();
            var screenScale = Screen.FromControl(this).Bounds;
            int index = 1;
            TransparencyKey = BackColor;
            for (var i = 0; i < screenScale.Width; i += 150)
            {
                for (var j = 0; j < screenScale.Height - 150; j += 150)
                {
                    Controls.Add(new Label
                    {
                        Location = new Point(i, j),
                        Text = $"{index++}",
                        Size = new Size(150, 150),
                        BorderStyle = BorderStyle.FixedSingle,
                        Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, 0)
                    });
                }
            }

            var indexx = 1;
            foreach (Label control in Controls)
            {
                //control.Text = control.Text + " " + control.PointToScreen(Point.Empty);
                Coordinates.Add(indexx++, control.PointToScreen(Point.Empty));
            }

            var details = EnvironmentSettings.SettingsData.Details ?? new EnvironmentSettingsDTO ();
            details.ScreenCoordinates = Coordinates;
            EnvironmentSettings.SettingsData.Details = details;
        }
    }
}
