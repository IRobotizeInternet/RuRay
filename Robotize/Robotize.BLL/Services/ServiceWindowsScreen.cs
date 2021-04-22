using System.Threading.Tasks;
using Robotize.BLL.Contracts;
using RobotizeFacebook.Services;

namespace Robotize.BLL.Services
{
    public class ServiceWindowsScreen : IServiceWindowsScreen
    {
        public Task<bool> WindowClick(int gridCoordinates)
        {
            return Task.FromResult(true);
        }

        public Task<bool> WindowGrid(GridVisibility gridVisibility)
        {
            const string serviceName = "WindowGrid";
            if (gridVisibility == GridVisibility.OFF) ServiceTask.CloseTask(serviceName);
            else ServiceTask.RunScript(serviceName, copyToAppFolder: false);

            // set the previously open window to focused.
            ServiceTask.RunScript(ServiceKeyboard.keyStrokesScript, "{%{TAB}}");

            return Task.FromResult(true);
        }
    }
}
