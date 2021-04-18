using System;
using System.Collections.Generic;
using System.Drawing;

namespace RobotizeFacebook.Services
{
    public class EnvironmentSettingsDTO
    {
        public string ProcessId { get; set; }
        public Rectangle ScreenScale { get; set; }
        public Dictionary<int, Point> ScreenCoordinates = new Dictionary<int, Point>();
        public int xAxis { get; set; }
        public int yAxis { get; set; }
    }
}
