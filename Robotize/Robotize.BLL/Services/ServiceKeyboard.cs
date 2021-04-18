using System.Configuration;
using System.Threading.Tasks;
using Robotize.BLL.Contracts;
using RobotizeFacebook.Services;
using RobotizeFacebook.Utilities;

namespace Robotize.BLL.Services
{
    public class ServiceKeyboard : IServiceKeyboard
    {
        /// <summary>
        /// Left click on the specified location.
        /// </summary>
        /// <param name="coordinates"></param>
        /// <returns></returns>
        public Task<bool> LeftClick(int coordinateIndex)
        {
            // TODO: Make this values avaliable in buffer for quick access.
            // This is where we keep the coordinates, so web api's can read from.
            AppSettings.EnvironmentSettingsFile = ConfigurationManager.AppSettings[nameof(AppSettings.EnvironmentSettingsFile)];
            var coordinate = EnvironmentSettings.SettingsData().Details.ScreenCoordinates[coordinateIndex];

            var clickerScript = "PS1\\Clicker";
            ServiceTask.RunScript(clickerScript, $"{coordinate.X} {coordinate.Y}");

            return Task.FromResult(true);
        }
    }
}
