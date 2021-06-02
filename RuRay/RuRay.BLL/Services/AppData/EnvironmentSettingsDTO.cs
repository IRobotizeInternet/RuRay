using System.Collections.Generic;
using System.Drawing;

namespace RuRayFacebook.Services
{
    /// <summary>
    /// Defines the <see cref="EnvironmentSettingsDTO" />.
    /// </summary>
    public class EnvironmentSettingsDTO
    {
        /// <summary>
        /// Gets or sets the ProcessId.
        /// </summary>
        public string ProcessId { get; set; }

        /// <summary>
        /// Gets or sets the ScreenScale.
        /// </summary>
        public Rectangle ScreenScale { get; set; }

        /// <summary>
        /// Defines the ScreenCoordinates.
        /// </summary>
        public Dictionary<int, Point> ScreenCoordinates = new Dictionary<int, Point>();

        /// <summary>
        /// Gets or sets the xAxis.
        /// </summary>
        public int xAxis { get; set; }

        /// <summary>
        /// Gets or sets the yAxis.
        /// </summary>
        public int yAxis { get; set; }
    }
}
