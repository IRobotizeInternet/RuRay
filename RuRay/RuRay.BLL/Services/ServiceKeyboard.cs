using System.Configuration;
using System.Threading.Tasks;
using EnumsNET;
using RuRay.BLL.Contracts;
using RuRayFacebook.Services;
using RuRayFacebook.Utilities;

namespace RuRay.BLL.Services
{
    /// <summary>
    /// Defines the <see cref="ServiceKeyboard" />.
    /// </summary>
    public class ServiceKeyboard : IServiceKeyboard
    {
        /// <summary>
        /// Defines the keyStrokesScript.
        /// </summary>
        public static string keyStrokesScript = "PS1\\KeyPress";

        /// <summary>
        /// Defines the clickerScript.
        /// </summary>
        public static string clickerScript = "PS1\\Clicker";

        /// <summary>
        /// Left click on the specified location.
        /// </summary>
        /// <param name="coordinateIndex">The coordinateIndex<see cref="int"/>.</param>
        /// <returns>.</returns>
        public Task<bool> LeftClick(int coordinateIndex)
        {
            // TODO: Make this values avaliable in buffer for quick access.
            // This is where we keep the coordinates, so web api's can read from.
            AppSettings.EnvironmentSettingsFile = ConfigurationManager.AppSettings[nameof(AppSettings.EnvironmentSettingsFile)];
            var coordinate = EnvironmentSettings.SettingsData().Details.ScreenCoordinates[coordinateIndex];

            ServiceTask.RunScript(clickerScript, $"{coordinate.X} {coordinate.Y}");

            return Task.FromResult(true);
        }

        /// <summary>
        /// The SendKey.
        /// </summary>
        /// <param name="sendKeys">The sendKeys<see cref="KeyStrokes"/>.</param>
        /// <returns>The <see cref="Task{bool}"/>.</returns>
        public Task<bool> SendKey(KeyStrokes sendKeys)
        {
            ServiceTask.RunScript(keyStrokesScript, sendKeys.AsString(EnumFormat.Description));
            return Task.FromResult(true);
        }
    }
}
