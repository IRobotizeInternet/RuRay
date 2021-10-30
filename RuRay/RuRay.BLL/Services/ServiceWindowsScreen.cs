using System.Threading.Tasks;
using RuRay.BLL.Contracts;
using RuRayFacebook.Services;

namespace RuRay.BLL.Services
{
    /// <summary>
    /// Defines the <see cref="ServiceWindowsScreen" />.
    /// </summary>
    public class ServiceWindowsScreen : IServiceWindowsScreen
    {
        /// <summary>
        /// The WindowClick.
        /// </summary>
        /// <param name="gridCoordinates">The gridCoordinates<see cref="int"/>.</param>
        /// <returns>The <see cref="Task{bool}"/>.</returns>
        public Task<bool> WindowClick(int gridCoordinates)
        {
            return Task.FromResult(true);
        }

        /// <summary>
        /// The WindowGrid.
        /// </summary>
        /// <param name="gridVisibility">The gridVisibility<see cref="GridVisibility"/>.</param>
        /// <returns>The <see cref="Task{bool}"/>.</returns>
        public Task<bool> WindowGrid(GridVisibility gridVisibility)
        {
            const string serviceName = "WindowGrid.exe";
            if (gridVisibility == GridVisibility.OFF)
            {
                ServiceTask.CloseTask(serviceName.Substring(0, serviceName.Length-4));
            }
            else
            {
                ServiceTask.RunScript(serviceName, runFromBinFolder: true, copyToAppFolder: false);
            }

            // set the previously open window to focused.
            ServiceTask.RunScript(ServiceKeyboard.keyStrokesScript, args: "{%{TAB}}");

            return Task.FromResult(true);
        }
    }
}
